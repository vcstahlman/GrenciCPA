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
        private string connectionString;
        private SqlCommand command;
        private SqlConnection connection;

        private AClient ClientsObj;
        private List<AInvoice> InvoiceObjList;
        private int clientID;


        public Payments()
        {
            InitializeComponent();
        }

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

        private void Payments_Load(object sender, EventArgs e)
        {
            //dgvPayments.Rows.Add("1232", "$200.00");
            //dgvPayments.Rows.Add("1237", "$500.00");
            //lblTotal.Text = "$700.00";
        }

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

        //private void CreatePaymentList(int pClientID)
        //{

        //    string GetPaymentSQL = "SELECT PAYMENT_ID, PAYMENT_TYPE, PAYMENT_AMOUNT, DATE_PAID, pt.CLIENT_ID " +
        //        "FROM PAYMENT_TABLE pt INNER " +
        //        "JOIN CLIENT_TABLE ct on pt.CLIENT_ID = ct.CLIENT_ID WHERE pt.CLIENT_ID = " + pClientID + ";";


        //    connectionString = Properties.Settings.Default.GrenciDBConnectionString;
        //    try
        //    {
        //        connection = new SqlConnection(connectionString);
        //        command = new SqlCommand(GetPaymentSQL, connection);

        //        connection.Open();

        //        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

        //        while (reader.Read())
        //        {

        //            APayment tempPayment = new APayment();


        //            if (reader["PAYMENT_ID"] != DBNull.Value)
        //            {
        //                tempPayment.PaymentID = (reader["PAYMENT_ID"] as int?) ?? 0;
        //            }
        //            if (reader["CLIENT_ID"] != DBNull.Value)
        //            {
        //                tempPayment.ClientID = (reader["CLIENT_ID"] as int?) ?? 0;
        //            }
        //            if (reader["PAYMENT_TYPE"] != DBNull.Value)
        //            {
        //                tempPayment.PaymentType = reader["PAYMENT_TYPE"] as string;
        //            }
        //            if (reader["PAYMENT_AMOUNT"] != DBNull.Value)
        //            {
        //                tempPayment.PaymentAmt = (reader["PAYMENT_AMOUNT"] as double?) ?? 0.00;
        //            }
        //            if(reader["DATE_PAID"] != DBNull.Value)
        //            {
        //                tempPayment.DatePaid = (DateTime)reader["DATE_PAID"];
        //            }
                    
        //            PaymentObjList.Add(tempPayment);

        //            tempPayment = null;
        //        }
        //        connection.Close();

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

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
        private void FillPaymentInfo()
        {

            foreach(AInvoice anInvoice in InvoiceObjList)
            {
                dgvPayments.Rows.Add(anInvoice.InvoiceID.ToString(), "$" + string.Format("{0:#,0.00}",anInvoice.AmtOwed));
            }
            
        }

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
            {   if (paymentAmount > 0)
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
                        }
                        else//the payment is more than the owed
                        {
                            paymentAmount -= aninvoice.AmtOwed;
                            aninvoice.AmtPaid += aninvoice.AmtPaid;
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

                bal -= paymentAmount;
                
                command.Parameters.AddWithValue("@pOwed", bal);
                
                
                command.ExecuteNonQuery();//tells ya if it worked

                connection.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not update the table \nError: " + ex.Message);
            }


            MessageBox.Show("Payment of $" + txtOverride.Text + " made. \nIt went towards " + rowsaffected);
            this.Close();
        }
    }
}
