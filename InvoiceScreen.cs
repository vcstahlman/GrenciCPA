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
        private double finalTotal;

        private List<AComp> componentList = new List<AComp>();
        private List<string> service_names = new List<string>();
        private List<double> service_totals = new List<double>();
        private List<string> service_sentences = new List<string>();

        private string clientFirstName;
        private string clientLastName;
        private string clientAddress;
        private string clientCity;
        private string clientState;
        private string clientZip;
        private string clientEmail;

        public InvoiceScreen()
        {
            InitializeComponent();
            
        }
        public InvoiceScreen(int pJob, double pTotal)
        {
            InitializeComponent();
            jobID = pJob;
            finalTotal = pTotal;
            CreateJobs(jobID);
            lblName.Text = clientFirstName + " " + clientLastName;
            double cumulativeTotal = 0.0;
            for(int i = 0; i < service_names.Count; i++)
            {
                rtbServices.AppendText(service_names[i] + ": " + service_totals[i] +"\n");
                rtbServices.AppendText(service_sentences[i] + '\n');
                cumulativeTotal = service_totals[i] + cumulativeTotal;
            }
            rtbServices.AppendText("Other Costs: " + (finalTotal - cumulativeTotal));
            txtAmtOwed.Text = finalTotal.ToString();

        }
        public void CreateJobs(int pJob)
        {
            string GetJobSQL = "SELECT JOB_COMPONENT_TABLE.SERV_ID, JOB_COMPONENT_TABLE.TOTAL, JOB_COMPONENT_TABLE.JOB_ID, SERVICE_TABLE.SERV_NAME, SERVICE_TABLE.SERV_SENTENCE, CLIENT_TABLE.CLIENT_ID, " +
                "CLIENT_TABLE.FIRST_NAME, CLIENT_TABLE.LAST_NAME, CLIENT_TABLE.ST_ADDRESS, CLIENT_TABLE.CITY, CLIENT_TABLE.STATE_AB, CLIENT_TABLE.ZIP " +
                "FROM JOB_COMPONENT_TABLE INNER JOIN JOB_TABLE ON JOB_COMPONENT_TABLE.JOB_ID = JOB_TABLE.JOB_ID INNER JOIN SERVICE_TABLE ON JOB_COMPONENT_TABLE.SERV_ID = SERVICE_TABLE.SERV_ID " +
                "INNER JOIN CLIENT_TABLE ON JOB_TABLE.CLIENT_ID = CLIENT_TABLE.CLIENT_ID " + 
                "WHERE JOB_COMPONENT_TABLE.JOB_ID = " + jobID + " " +
                "GROUP BY JOB_TABLE.JOB_ID, CLIENT_TABLE.SERV_ID, SERVICE_TABLE.SERV_SENTENCE;";
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
                        tempComp.Total = (reader["TOTAL"] as float?) ?? 0.0;
                        service_totals.Add(tempComp.Total);
                    }
                    if (reader["SERV_SENTENCE"] != DBNull.Value)
                    {
                        tempComp.Serv_Sentence = (reader["SERV_SENTENCE"] as string);
                        service_sentences.Add(reader["SERV_SENTENCE"] as string);
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
                    componentList.Add(tempComp);
                    ClientsObj = tempClient;
                }
                connection.Close();
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not retrieve characteristics from Database.! \n Error reads: " + ex.Message);
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
            //attachments.Add(@"C:\Users\hoffmanw\Documents\Tests\test.txt");

            //oMailItem.Attachments.Add(attachments[0]);
            oMailItem.Display(true);
        }

        private void btnMakeInvoice_Click_1(object sender, EventArgs e)
        {
            // Once this button is clicked, it will generated a new pdf and save it to the user's computer, in case they want to print it out or
            // save it for later on


            //Will need to have these not hard code
            string name = "Joe & Joan Smith"; //From client database
            string address = "123 Center Avenue"; //From client database
            string city = "Butler, PA, 16001"; //From client database
            double cumulativeTotal = 0.0;
            Document document = new Document();

            // we need to gothrough the name and update it to fit and not save over the old
            //also need a filenetwork based off of clients
            PdfWriter.GetInstance(document, new FileStream("SampleInvoice.pdf", FileMode.Create));
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
            h1.Add(new Chunk("\n" + "\n" + "\n" + "INVOICE" + "\n", boldFont));
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
                double total = service_totals[i];
                cumulativeTotal = total + cumulativeTotal;
                p4 = new Paragraph("\n" + sentence + ": " + total + "\n", normalFont);
                document.Add(p4);
            }
            p4 = new Paragraph("Other costs: " + (finalTotal - cumulativeTotal), normalFont);
            document.Add(p4);
            //Comes from the sum of the job
            Paragraph p5 = new Paragraph("\n" + "Total Amount Due: " + finalTotal, boldFont);
            Paragraph p6 = new Paragraph("\n\n" + "Thank you for your business!" + "\n\n", normalFont);
            document.Add(p5);
            document.Add(p6);
            document.Add(img2);
            document.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}