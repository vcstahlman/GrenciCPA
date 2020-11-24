using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Reflection;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.IO;
using System.CodeDom;
using System.Data.SqlClient;
using System.Runtime.Remoting;

// Justin Bloss
// The purpose of this form is to allow the user to create and either print or email an invoice to a client, amounts are generated based on what is entered
// on the JobScreen form in terms of costs.
namespace GrenciCPA
{
    public partial class InvoiceScreen : Form
    {
        private int jobID;
        private string connectionString;
        private SqlCommand command;
        private SqlConnection connection;

        private AClient ClientsObj;
        private int parentID;
        private int clientID;
        private decimal finalTotal;
        private decimal cumulativeTotal = 0;

        private List<AComp> componentList = new List<AComp>();
        private List<string> service_names = new List<string>();
        private List<decimal> service_totals = new List<decimal>();
        private List<string> service_sentences = new List<string>();

        private string clientFirstName;
        private string clientLastName;
        private string clientAddress;
        private string clientCity;
        private string clientState;
        private string clientZip;
        private string clientEmail;

        private string filePath;

        public InvoiceScreen()
        {
            InitializeComponent();

        }
        public InvoiceScreen(int pJob, decimal pTotal)
        {
            InitializeComponent();
            jobID = pJob;
            finalTotal = pTotal;
            CreateJobs(jobID);
            txtName.Text = clientFirstName + " " + clientLastName;

            for (int i = 0; i < service_names.Count; i++)
            {
                if (i == 0) dgvInvoice.Rows.Add(service_sentences[i], string.Format("{0:#,0.00}", service_totals[i]));
                else if (service_sentences[i] == service_sentences[i - 1]) 
                {
                    decimal last = 0;
                    decimal.TryParse(dgvInvoice.Rows[dgvInvoice.Rows.Count-1].Cells[1].Value.ToString(), out last);

                    dgvInvoice.Rows[dgvInvoice.Rows.Count-1].Cells[1].Value = string.Format("{0:#,0.00}", last + service_totals[i]);//puts this into the latest row
                }
                else { dgvInvoice.Rows.Add(service_sentences[i], string.Format("{0:#,0.00}", service_totals[i])); }
                cumulativeTotal = service_totals[i] + cumulativeTotal;
            }
            decimal sum = 0;

            for (int i = 0; i < dgvInvoice.Rows.Count; ++i)

            {
                try
                {
                    sum += Convert.ToDecimal(dgvInvoice.Rows[i].Cells[1].Value);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("The sum did not finish converting \nError: " + ex.Message);
                }

            }

            txtAmtOwed.Text = "Total sum is: $" + string.Format("{0:#,0.00}", sum);
            service_names.Add("Other ");
            service_sentences.Add("Other Costs: ");
            service_totals.Add(finalTotal - cumulativeTotal);
            dgvInvoice.Rows.Add("Other Costs", string.Format("{0:#,0.00}", finalTotal - cumulativeTotal));
            txtAmtOwed.Text = '$'+ string.Format("{0:#,0.00}", finalTotal);

            btnEmail.Enabled = false;
            btnPrint.Enabled = false;
        }
        public void CreateJobs(int pJob)
        {
            string GetJobSQL = "SELECT JOB_COMPONENT_TABLE.SERV_ID, JOB_COMPONENT_TABLE.TOTAL, JOB_COMPONENT_TABLE.JOB_ID, SERVICE_TABLE.SERV_NAME, SERVICE_TABLE.SERV_SENTENCE, CLIENT_TABLE.CLIENT_ID, " +
                "CLIENT_TABLE.CLIENT_ID, CLIENT_TABLE.FIRST_NAME, CLIENT_TABLE.LAST_NAME, CLIENT_TABLE.ST_ADDRESS, CLIENT_TABLE.CITY, CLIENT_TABLE.STATE_AB, CLIENT_TABLE.ZIP, CLIENT_TABLE.EMAIL " +
                "FROM JOB_COMPONENT_TABLE INNER JOIN JOB_TABLE ON JOB_COMPONENT_TABLE.JOB_ID = JOB_TABLE.JOB_ID INNER JOIN SERVICE_TABLE ON JOB_COMPONENT_TABLE.SERV_ID = SERVICE_TABLE.SERV_ID " +
                "INNER JOIN CLIENT_TABLE ON JOB_TABLE.CLIENT_ID = CLIENT_TABLE.CLIENT_ID " +
                "WHERE JOB_COMPONENT_TABLE.JOB_ID = " + jobID + " " +
                "ORDER BY JOB_COMPONENT_TABLE.SERV_ID;";

            int lastServID = 0;
            connectionString = Properties.Settings.Default.GrenciDBConnectionString;
            try
            {
                connection = new SqlConnection(connectionString);
                command = new SqlCommand(GetJobSQL, connection);
                //Open the connection
                connection.Open();
                //Create a SQL Data Reader object
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                //Keep reading as long as I have data from the database to read


                int i = 0;
                while (reader.Read())//reads in all the data assotiated with the 
                {
                    AComp tempComp = new AComp();
                    AClient tempClient = new AClient();

                    if (reader["SERV_ID"] != DBNull.Value)
                    {
                        tempComp.Serv_ID = (reader["SERV_ID"] as int?) ?? 0;
                    }
                    if (reader["SERV_NAME"] != DBNull.Value)
                    {
                        tempComp.Serv_Name = (reader["SERV_NAME"] as string);
                        service_names.Add(reader["SERV_NAME"] as string);
                    }
                    if (reader["TOTAL"] != DBNull.Value)
                    {
                        tempComp.Total = (reader["TOTAL"] as decimal?) ?? 0.00m;
                        service_totals.Add(tempComp.Total);
                    }
                    if (reader["SERV_SENTENCE"] != DBNull.Value)
                    {
                        tempComp.Serv_Sentence = (reader["SERV_SENTENCE"] as string);
                        service_sentences.Add(reader["SERV_SENTENCE"] as string);
                    }
                    if (reader["CLIENT_ID"] != DBNull.Value)
                    {
                        tempClient.ClientID = (reader["CLIENT_ID"] as int?) ?? 0;
                        clientID = (reader["CLIENT_ID"] as int?) ?? 0;
                    }
                    if (reader["FIRST_NAME"] != DBNull.Value)
                    {
                        tempClient.FirstName = reader["FIRST_NAME"] as string;
                        clientFirstName = reader["FIRST_NAME"] as string;
                    }
                    if (reader["LAST_NAME"] != DBNull.Value)
                    {
                        tempClient.LastName = reader["LAST_NAME"] as string;
                        clientLastName = reader["LAST_NAME"] as string;
                    }
                    if (reader["ST_ADDRESS"] != DBNull.Value)
                    {
                        tempClient.Address = reader["ST_ADDRESS"] as string;
                        clientAddress = reader["ST_ADDRESS"] as string;
                    }
                    if (reader["CITY"] != DBNull.Value)
                    {
                        tempClient.City = reader["CITY"] as string;
                        clientCity = reader["CITY"] as string;
                    }
                    if (reader["STATE_AB"] != DBNull.Value)
                    {
                        tempClient.State = reader["STATE_AB"] as string;
                        clientState = reader["STATE_AB"] as string;
                    }
                    if (reader["ZIP"] != DBNull.Value)
                    {
                        tempClient.Zip = reader["ZIP"] as string;
                        clientZip = reader["ZIP"] as string;
                    }
                    if (reader["EMAIL"] != DBNull.Value)
                    {
                        tempClient.Email = reader["EMAIL"] as string;
                        clientEmail = reader["EMAIL"] as string;

                    }
                    else clientEmail = "";
                    //this is used for a comparason for in the save function
                    tempComp.Row = i;
                    i++;
                    if (componentList.Count == 0)
                    {
                        componentList.Add(tempComp);//add no mater what
                        lastServID = tempComp.Serv_ID;
                    }
                    else if (lastServID == tempComp.Serv_ID && tempComp.Serv_ID != 0)// if new is same as old add to the total but not another row.
                    {
                        componentList[componentList.Count - 1].Total += tempComp.Total;
                        lastServID = tempComp.Serv_ID;
                    }

                    else
                    {
                        componentList.Add(tempComp);
                        lastServID = tempComp.Serv_ID;
                    }
                    ClientsObj = tempClient;
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not retrieve services from Database.! \n Error reads: " + ex.Message);
            }
        }


        private void btnEmail_Click(object sender, EventArgs e)
        {
            CreateMailItem();
        }

        private void CreateMailItem()
        {
            Outlook.Application oApp = new Outlook.Application();
            Outlook._MailItem oMailItem = (Outlook._MailItem)oApp.CreateItem(Outlook.OlItemType.olMailItem);
            oMailItem.To = clientEmail;
            oMailItem.Subject = "Grenci CPA Invoice";

            List<string> attachments = new List<string>();

            oMailItem.Attachments.Add(@filePath);
            oMailItem.Display(true);
        }

        private void btnMakeInvoice_Click_1(object sender, EventArgs e)
        {


            //will save invoice on the path of the id
            string inString = "";
            int invoice = 0;

            for (int i = 0; i < service_names.Count; i++)
            {
                string sentence = service_sentences[i];
                decimal total = service_totals[i];

                inString += sentence + ": $" + string.Format("{0:#,0.00}", total )+ "\n";

            }
            string SetInvoiceSQL = "INSERT INTO INVOICE_TABLE (JOB_ID, AMOUNT_OWED, AMOUNT_PAID, INVOICE_TEXT, FILE_PATH, DATE_SENT) " +
                "OUTPUT INSERTED.INVOICE_ID " +
                "VALUES (@JOB_ID, @OWED, @PAID, @TEXT, @PATH, @DATE); ";

            filePath = "C:/Invoices/" + clientFirstName + clientLastName + clientID +"/"+ jobID + clientLastName + DateTime.Now.Year.ToString() + ".pdf";

            connectionString = Properties.Settings.Default.GrenciDBConnectionString;
            try
            {
                connection = new SqlConnection(connectionString);
                command = new SqlCommand(SetInvoiceSQL, connection);
                //Open the connection
                connection.Open();


                command.Parameters.AddWithValue("@JOB_ID", jobID);
                command.Parameters.AddWithValue("@OWED", finalTotal);
                command.Parameters.AddWithValue("@PAID", 0);
                command.Parameters.AddWithValue("@TEXT", inString);
                command.Parameters.AddWithValue("@PATH", filePath);
                command.Parameters.AddWithValue("@DATE", DateTime.Now);



                var lastID = command.ExecuteScalar(); //this gets the data of the client that was just added into the system
                invoice = Convert.ToInt32(lastID);


                connection.Close();
                // Once this button is clicked, it will generated a new pdf and save it to the user's computer, in case they want to print it out or
                // save it for later on

                command = new SqlCommand("UPDATE JOB_TABLE SET JOB_ACTIVE = @active WHERE JOB_ID = " + jobID + ";", connection);

                connection.Open();
                command.Parameters.AddWithValue("@JOB_ACTIVE", 0);

                connection.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Could not make invoice! \nError: " + ex.Message);
                return;//stops the creation of an invoice file if it fails
            }

            Document document = new Document();

            // we need to gothrough the name and update it to fit and not save over the old
            //also need a filenetwork based off of clients

            Directory.CreateDirectory(Path.GetDirectoryName(filePath));

            PdfWriter.GetInstance(document, new FileStream(@filePath, FileMode.Create));
            document.Open();
            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(@"GrenciHeader.jpg");
            iTextSharp.text.Image img2 = iTextSharp.text.Image.GetInstance(@"GrenciFooter.jpg");
            img.Alignment = Element.ALIGN_CENTER;
            img2.Alignment = Element.ALIGN_CENTER;
            img.ScaleToFit(450f, 1500f);
            img2.ScaleToFit(450f, 1500f);
            document.Add(img);
            var normalFont = FontFactory.GetFont(FontFactory.TIMES, 12);
            var boldFont = FontFactory.GetFont(FontFactory.TIMES_BOLD, 12);
            var h1 = new Paragraph();
            h1.Alignment = Element.ALIGN_CENTER;
            h1.Add(new Chunk("\n" + "\n" + "INVOICE " + "\n", boldFont));
            Paragraph date = new Paragraph(DateTime.Now.ToLongDateString(), normalFont);
            Paragraph p1 = new Paragraph("\n" + clientFirstName + " " + clientLastName, normalFont);
            Paragraph p2 = new Paragraph(clientAddress, normalFont);
            Paragraph p3 = new Paragraph(clientCity + ", " + clientState + " " + clientZip + "\n\n", normalFont);
            document.Add(h1);
            document.Add(date);
            document.Add(p1);
            document.Add(p2);
            document.Add(p3);
            Paragraph p4;
            for (int i = 0; i < service_names.Count; i++)
            {
                string sentence = service_sentences[i];
                decimal total = service_totals[i];
                cumulativeTotal = total + cumulativeTotal;
                p4 = new Paragraph(sentence + ": $" + string.Format("{0:#,0.00}", total) + "\n", normalFont);
                document.Add(p4);
            }
            //Comes from the sum of the job
            Paragraph p5 = new Paragraph("\n" + "Total Amount Due: $" + string.Format("{0:#,0.00}",finalTotal), boldFont);
            Paragraph p6 = new Paragraph("\n\n" + "Thank you for your business!" + "\n\n", normalFont);
            document.Add(p5);
            document.Add(p6);
            document.Add(img2);
            document.Close();

            btnMakeInvoice.Text = "Invoice made";
            btnEmail.Enabled = true;
            btnPrint.Enabled = true;



            string setPaymentSQL = "UPDATE JOB_TABLE SET JOB_ACTIVE = 0  WHERE JOB_ID = " + jobID + ";";
            //we are going through and updating the prices that we need to pull

            //Pulled from App.config
            connectionString = Properties.Settings.Default.GrenciDBConnectionString;
            try
            {
                connection = new SqlConnection(connectionString);
                command = new SqlCommand(setPaymentSQL, connection);
                //Open the connection
                connection.Open();
                command.ExecuteNonQuery();//tells ya if it worked

                connection.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not deactivate job \nError: " + ex.Message);
            }

            btnClose.Text = "Close";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@filePath);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Edit")
            {

                double total = 0.0;
                txtName.ReadOnly = false;
                btnEdit.Text = "Finish Editing";
                string clientFullName = txtName.Text;
                string[] splitName = clientFullName.Split(' ');
                this.clientFirstName = splitName[0];
                this.clientLastName = splitName[1];


                txtAmtOwed.Text = total.ToString();
            }

            else
            {

                txtName.ReadOnly = true;
                btnEdit.Text = "Edit";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            decimal sum = 0;

            for (int i = 0; i < dgvInvoice.Rows.Count; i++)
            {
                service_sentences[i] = dgvInvoice.Rows[i].Cells[0].Value.ToString();
                service_totals[i] = Convert.ToDecimal(dgvInvoice.Rows[i].Cells[1].Value);
                sum += Convert.ToDecimal(dgvInvoice.Rows[i].Cells[1].Value);

            }

            txtAmtOwed.Text = sum.ToString();
            finalTotal = sum;
        }
    }
}