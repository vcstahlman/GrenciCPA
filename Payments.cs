/// Grenci CPA 411 Project
/// Authors: Justin Bloss, Will Hoffman, Victor Stahlman, & Cameron Weaver
/// Project goal: make a program for Dr. Anthony Grenci to use at his CPA firm to keep track of billing, and automate the calculation process.
/// Page: This page is about making payments. the will be payed oldest to newest.
///

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GrenciCPA
{
    public partial class Payments : Form
    {

        //sql stuff
        private string connectionString;
        private SqlCommand command;
        private SqlConnection connection;


        //information keepers
        private AClient ClientsObj;
        private List<AInvoice> InvoiceObjList;
        private int clientID;


        //consteructor that sets up all the lists and infromation
        public Payments(int pClientID)
        {
            InitializeComponent();
            clientID = pClientID;
            InvoiceObjList = new List<AInvoice>();

            CreateClientList(clientID);
            CreateChargeList(clientID);
            FillClientInfo();
            FillPaymentInfo();
        }


        //for hardcoding the data in
        private void Payments_Load(object sender, EventArgs e)
        {
            //dgvPayments.Rows.Add("1232", "$200.00");
            //dgvPayments.Rows.Add("1237", "$500.00");
            //lblTotal.Text = "$700.00";
        }

        //this gets all the chagres to the account that are able to be payed
        private void CreateChargeList(int pClientID)
        {
            string GetPaymentSQL = "SELECT INVOICE_TABLE.* " +
                "FROM INVOICE_TABLE INNER JOIN JOB_TABLE  ON INVOICE_TABLE.JOB_ID = JOB_TABLE.JOB_ID " +
                "WHERE JOB_TABLE.CLIENT_ID = " + pClientID + " AND INVOICE_TABLE.AMOUNT_OWED > 0;";


            connectionString = Properties.Settings.Default.GrenciDBConnectionString;
            try
            {
                connection = new SqlConnection(connectionString);
                command = new SqlCommand(GetPaymentSQL, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                while (reader.Read())
                {

                     AInvoice tempinvoice = new AInvoice();


                    if (reader["INVOICE_ID"] != DBNull.Value)
                    {
                        tempinvoice.InvoiceID = (reader["INVOICE_ID"] as int?) ?? 0;
                    }
                    if (reader["JOB_ID"] != DBNull.Value)
                    {
                        tempinvoice.JobID = (reader["JOB_ID"] as int?) ?? 0;
                    }
                    if (reader["AMOUNT_OWED"] != DBNull.Value)
                    {
                        tempinvoice.AmtOwed = (reader["AMOUNT_OWED"] as decimal?) ?? 0.00m;
                    }
                    if (reader["AMOUNT_PAID"] != DBNull.Value)
                    {
                        tempinvoice.AmtPaid = (reader["AMOUNT_PAID"] as decimal?) ?? 0.00m;
                    }
                    if (reader["DATE_SENT"] != DBNull.Value)
                    {
                        tempinvoice.SentDate = (DateTime)reader["DATE_SENT"];
                    }

                    InvoiceObjList.Add(tempinvoice);
                    tempinvoice = null;
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //gets the clients information 
        private void CreateClientList(int pClientID)
        {

            string GetClientSQL = "SELECT CLIENT_ID, CLIENT_ACTIVE, FIRST_NAME, LAST_NAME, SS, BIRTHDATE, ST_ADDRESS, " +
                "CITY, STATE_AB, ZIP, COUNTY, SCHOOL, EMAIL, PHONE, IS_BUSINESS, COMPANY_NAME, PARENT_CLIENT, NOTES, OWED_BALANCE " +
                "FROM CLIENT_TABLE WHERE CLIENT_ID = " + pClientID + ";";

            connectionString = Properties.Settings.Default.GrenciDBConnectionString;
            try
            {
                connection = new SqlConnection(connectionString);
                command = new SqlCommand(GetClientSQL, connection);

                connection.Open();


                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);


                while (reader.Read())
                {
                    AClient tempClient = new AClient();

                    if (reader["CLIENT_ID"] != DBNull.Value)
                    {
                        tempClient.ClientID = (reader["CLIENT_ID"] as int?) ?? 0;
                    }
                    if (reader["FIRST_NAME"] != DBNull.Value)
                    {
                        tempClient.FirstName = reader["FIRST_NAME"] as string;
                    }
                    if (reader["LAST_NAME"] != DBNull.Value)
                    {
                        tempClient.LastName = reader["LAST_NAME"] as string;
                    }
                    if (reader["ST_ADDRESS"] != DBNull.Value)
                    {
                        tempClient.Address = reader["ST_ADDRESS"] as string;
                    }
                    if (reader["CITY"] != DBNull.Value)
                    {
                        tempClient.City = reader["CITY"] as string;
                    }
                    if (reader["STATE_AB"] != DBNull.Value)
                    {
                        tempClient.State = reader["STATE_AB"] as string;
                    }
                    if (reader["ZIP"] != DBNull.Value)
                    {
                        tempClient.Zip = reader["ZIP"] as string;
                    }
                    if (reader["COUNTY"] != DBNull.Value)
                    {
                        tempClient.County = reader["COUNTY"] as string;
                    }
                    if (reader["EMAIL"] != DBNull.Value)
                    {
                        tempClient.Email = reader["EMAIL"] as string;
                    }
                    if (reader["IS_BUSINESS"] != DBNull.Value)
                    {
                        tempClient.IsBusiness = reader.GetBoolean(reader.GetOrdinal("IS_BUSINESS"));
                    }
                    if (reader["COMPANY_NAME"] != DBNull.Value)
                    {
                        tempClient.Company = reader["COMPANY_NAME"] as string;
                    }
                    if (reader["CLIENT_ACTIVE"] != DBNull.Value)
                    {
                        tempClient.Active = reader.GetBoolean(reader.GetOrdinal("CLIENT_ACTIVE"));
                    }
                    if (reader["OWED_BALANCE"] != DBNull.Value)
                    {
                        tempClient.Balance = (reader["OWED_BALANCE"] as decimal?) ?? 0.00m;
                    }


                    ClientsObj = tempClient;

                    tempClient = null;
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //fills in the client information
        private void FillClientInfo()
        {
            AClient aClient = ClientsObj;

            if (aClient.IsBusiness) lblName.Text = aClient.Company;
            else lblName.Text = aClient.FirstName + " " + aClient.LastName;

            lblAddressSt.Text = aClient.Address;
            lblAddressCSZ.Text = aClient.City + ", " + aClient.State + " " + aClient.Zip;
            lblPhone.Text = aClient.Phone;
            lblEmail.Text = aClient.Email;
            txtOverride.Text = string.Format("{0:#,0.00}", aClient.Balance);

        }

        //fills in the payment information
        private void FillPaymentInfo()
        {

            foreach(AInvoice anInvoice in InvoiceObjList)
            {
                dgvPayments.Rows.Add(anInvoice.InvoiceID.ToString(), "$" + string.Format("{0:#,0.00}",anInvoice.AmtOwed));
            }
            
        }


        //this is for the close
        private void btnClose_Click(object sender, EventArgs e)
        {
            string message = "If you close now, any unsaved changes may be lost. Are you sure you want to continue?";
            string title = "Confirm Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }


        //this takes the payment and makes it towards 
        private void btnProcess_Click(object sender, EventArgs e)
        {
            string setPaymentSQL = "INSERT INTO PAYMENT_TABLE (CLIENT_ID, PAYMENT_TYPE, PAYMENT_AMOUNT, DATE_PAID)  " +
                        " VALUES (@pClientID, @pType, @pAmount, @pDate) ;";
            //Pulled from App.config
            connectionString = Properties.Settings.Default.GrenciDBConnectionString;
            try
            {
                connection = new SqlConnection(connectionString);
                command = new SqlCommand(setPaymentSQL, connection);
                //Open the connection
                connection.Open();
                //Create a SQL Data Reader object

                //Keep reading as long as I have data from the database to read

                command.Parameters.AddWithValue("@pClientID", clientID);
                if(cboType.SelectedItem != null) command.Parameters.AddWithValue("@pType", cboType.SelectedItem.ToString());
                else command.Parameters.AddWithValue("@pType", "none");
                command.Parameters.AddWithValue("@pDate", DateTime.Now);
                command.Parameters.AddWithValue("@pAmount", double.Parse(txtOverride.Text));


                int rowsAffected = command.ExecuteNonQuery();//tells ya if it worked

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not add payment.! \nError reads: " + ex.Message);
            }


            //makes the invoices 0 out if possible
            int rowsaffected = 0;
            decimal paymentAmount = 0;
            
            decimal.TryParse(txtOverride.Text, out paymentAmount);

            

            foreach (AInvoice aninvoice in InvoiceObjList)
            {   
                if (paymentAmount > 0)
                {
                    setPaymentSQL = "UPDATE INVOICE_TABLE SET AMOUNT_OWED = @pOwed, AMOUNT_PAID = @pPaid  WHERE INVOICE_ID = " + aninvoice.InvoiceID + ";";
                    //we are going through and updating the prices that we need to pull

                    //Pulled from App.config
                    connectionString = Properties.Settings.Default.GrenciDBConnectionString;
                    try
                    {
                        connection = new SqlConnection(connectionString);
                        command = new SqlCommand(setPaymentSQL, connection);
                        //Open the connection
                        connection.Open();

                        decimal payment = aninvoice.AmtOwed;
                        if (payment > paymentAmount)
                        {
                            aninvoice.AmtOwed -= paymentAmount;//if payment is left then put rest into it
                            aninvoice.AmtPaid += paymentAmount;

                            paymentAmount = 0;
                            //payment is less and therefore is logiclly zero here
                        }
                        else//the payment is more than the owed
                        {
                            paymentAmount -= aninvoice.AmtOwed;
                            aninvoice.AmtPaid = aninvoice.AmtOwed; //it sets payment to be fulle amount of owed
                            aninvoice.AmtOwed = 0;
                        }

                        command.Parameters.AddWithValue("@pOwed", aninvoice.AmtOwed);
                        command.Parameters.AddWithValue("@pPaid", aninvoice.AmtPaid);


                        rowsaffected = command.ExecuteNonQuery();//tells ya if it worked

                        connection.Close();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Could not update the table \nError: " + ex.Message);
                    }
                }
                else break;
            }

            setPaymentSQL = "UPDATE CLIENT_TABLE SET OWED_BALANCE = @pOwed  WHERE CLIENT_ID = " + clientID + ";";
            //we are going through and updating the prices that we need to pull

            //Pulled from App.config
            connectionString = Properties.Settings.Default.GrenciDBConnectionString;
            try
            {
                connection = new SqlConnection(connectionString);
                command = new SqlCommand(setPaymentSQL, connection);
                //Open the connection
                connection.Open();

                decimal bal = ClientsObj.Balance;

                decimal.TryParse(txtOverride.Text, out paymentAmount);

                bal -= paymentAmount;
                
                command.Parameters.AddWithValue("@pOwed", bal);
                
                
                command.ExecuteNonQuery();//tells ya if it worked

                connection.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not update client balance e \nError: " + ex.Message);
            }


            MessageBox.Show("Payment of $" + txtOverride.Text + " made. \nIt went towards " + rowsaffected + " invoice(s)");
            this.Close();
        }
    }
}
