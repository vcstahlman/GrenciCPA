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
    public partial class Reports : Form
    {

        //sql stuff
        private string connectionString;
        private SqlCommand command;
        private SqlConnection connection;

        private List<AClient> ClientsObjList = new List<AClient>();
        private List<AServ> serviceList = new List<AServ>();
        private List<AChar> characteristicList = new List<AChar>();

        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            lbxReport.Items.Clear();
            GetServChar();


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvReports.Rows.Clear();
            ClientsObjList.Clear();

            string makeReportSQL = "SELECT CLIENT_TABLE.CLIENT_ID, CLIENT_TABLE.FIRST_NAME, CLIENT_TABLE.LAST_NAME, CLIENT_TABLE.COMPANY_NAME, JOB_TABLE.TOTAL_BILL, " +
                "INVOICE_TABLE.AMOUNT_OWED, INVOICE_TABLE.AMOUNT_PAID, INVOICE_TABLE.DATE_SENT " +
                "FROM  JOB_COMPONENT_TABLE INNER JOIN CHARACTERISTIC_TABLE ON JOB_COMPONENT_TABLE.CHAR_ID = CHARACTERISTIC_TABLE.CHAR_ID " +
                "INNER JOIN JOB_TABLE INNER JOIN CLIENT_TABLE ON JOB_TABLE.CLIENT_ID = CLIENT_TABLE.CLIENT_ID INNER JOIN INVOICE_TABLE ON " +
                "JOB_TABLE.JOB_ID = INVOICE_TABLE.JOB_ID ON JOB_COMPONENT_TABLE.JOB_ID = JOB_TABLE.JOB_ID ";
            string makeReportSQLChar = " ";
            if (tbxName.Text != "")
            {
                string search = tbxName.Text;
                makeReportSQL += " WHERE (CLIENT_TABLE.LAST_NAME LIKE '" + search + "%') ";
                makeReportSQLChar = " AND (";
            }
            else if (tbxMisc.Text != "")
            {
                string search = tbxName.Text;
                makeReportSQL += " WHERE (CLIENT_TABLE.COMPANY_NAME LIKE '" + search + "%') ";
                makeReportSQLChar = " AND (";
            }
            else
            {

                makeReportSQLChar = " WHERE (";
            }


            bool isFirst = true;
            bool charFound = false;
            for (int i = 0; i < clbLabels.CheckedItems.Count; i++)
            {
                
                // Do unselected stuff
                foreach (AChar chara in characteristicList)
                {
                    if (clbLabels.CheckedItems[i].ToString() == chara.CharName)
                    {
                        if (isFirst)
                        {
                            makeReportSQLChar += " CHARACTERISTIC_TABLE.CHAR_ID = " + chara.CharID + " ";
                            isFirst = false;
                            charFound = true;
                        }
                        else makeReportSQLChar += " AND CHARACTERISTIC_TABLE.CHAR_ID = " + chara.CharID + " ";
                    }
                } 
                
            }
            if (charFound) makeReportSQLChar += ") ";//if there was a char then it adds this to end
            else makeReportSQLChar = "";//if not then it clears the string

            makeReportSQL += makeReportSQLChar + " GROUP BY CLIENT_TABLE.CLIENT_ID, CLIENT_TABLE.FIRST_NAME , CLIENT_TABLE.LAST_NAME, COMPANY_NAME, TOTAL_BILL , AMOUNT_OWED, AMOUNT_PAID, DATE_SENT;";

            connectionString = Properties.Settings.Default.GrenciDBConnectionString;

            try
            {

                connection = new SqlConnection(connectionString);
                command = new SqlCommand(makeReportSQL, connection);
                //Open the connection
                connection.Open();
                //Create a SQL Data Reader object
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                //Keep reading as long as I have data from the database to read
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
                    if (reader["COMPANY_NAME"] != DBNull.Value)
                    {
                        tempClient.Company = reader["COMPANY_NAME"] as string;
                    }                    
                    if(reader["TOTAL_BILL"] != DBNull.Value)
                    {
                        tempClient.TotalBill = (reader["TOTAL_BILL"] as decimal?) ?? 0.00m;
                    }
                    if (reader["AMOUNT_OWED"] != DBNull.Value)
                    {
                        tempClient.Balance = (reader["AMOUNT_OWED"] as decimal?) ?? 0.00m;
                    }
                    if (reader["AMOUNT_PAID"] != DBNull.Value)
                    {
                        tempClient.PaymentAmount = (reader["AMOUNT_PAID"] as decimal?) ?? 0.00m;
                    }

                    if (reader["DATE_SENT"] != DBNull.Value)
                    {
                        DateTime dateSent = (DateTime)reader["DATE_SENT"];
                        tempClient.DateSent = dateSent.ToShortDateString();
                    }



                    //Add the temporary plot stuff from list.
                    ClientsObjList.Add(tempClient);

                    tempClient = null;
                }

                FillReport();

                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Could not retrieve clients from Database.! \n Error reads: " + ex.Message);
            }


            
        }

        private void GetServChar() //this makes a list of the char and serv at the begining of the
        {

            clbLabels.Items.Clear();
            string GetCharSQL = "select * from SERVICE_TABLE st inner join CHARACTERISTIC_TABLE ct on " +
                "st.SERV_ID = ct.SERV_ID  order by st.SERV_NAME, ct.CHAR_NAME";

            //Pulled from App.config
            connectionString = Properties.Settings.Default.GrenciDBConnectionString;
            try
            {
                connection = new SqlConnection(connectionString);
                command = new SqlCommand(GetCharSQL, connection);
                //Open the connection
                connection.Open();
                //Create a SQL Data Reader object
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                //Keep reading as long as I have data from the database to read


                int i = 0;
                while (reader.Read())//reads in all the data assotiated with the 
                {
                    AChar tempChar = new AChar();


                    if (reader["CHAR_ID"] != DBNull.Value)
                    {
                        tempChar.CharID = (reader["CHAR_ID"] as int?) ?? 0;
                    }
                    if (reader["CHAR_NAME"] != DBNull.Value)
                    {
                        tempChar.CharName = (reader["CHAR_NAME"] as string);
                    }
                    if (reader["CHAR_MIN"] != DBNull.Value)
                    {
                        tempChar.CharMini = (reader["CHAR_MIN"] as int?) ?? 0;
                    }
                    if (reader["CHAR_COST"] != DBNull.Value)
                    {
                        tempChar.CharCost = (reader["CHAR_COST"] as decimal?) ?? 0.00m;
                    }
                    if (reader["SERV_ID"] != DBNull.Value)
                    {
                        tempChar.CharAsso = (reader["SERV_ID"] as int?) ?? 0;

                    }
                    if (reader["CHAR_ACTIVE"] != DBNull.Value)
                    {
                        if (!reader.GetBoolean(reader.GetOrdinal("CHAR_ACTIVE"))) tempChar = null;//if not active then it will delete the temp so it is not added
                    }

                    if (tempChar != null)
                    {
                        
                        characteristicList.Add(tempChar);
                    }

                    i++;

                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not retrieve characteristics from Database.! \n Error reads: " + ex.Message);
            }

            foreach (AChar charactor in characteristicList) {
                clbLabels.Items.Add(charactor.CharName);

            }
        }

        private string GetServ(int pClient)
        {
            string returning = "";
            string GetParentSQL = "SELECT SERVICE_TABLE.SERV_NAME FROM SERVICE_TABLE INNER JOIN JOB_COMPONENT_TABLE ON SERVICE_TABLE.SERV_ID = JOB_COMPONENT_TABLE.SERV_ID " +
                "INNER JOIN JOB_TABLE ON JOB_COMPONENT_TABLE.JOB_ID = JOB_TABLE.JOB_ID WHERE JOB_TABLE.CLIENT_ID =" + pClient + "" +
                "GROUP BY SERV_NAME;";
            //Pulled from App.config
            connectionString = Properties.Settings.Default.GrenciDBConnectionString;
            try
            {
                connection = new SqlConnection(connectionString);
                command = new SqlCommand(GetParentSQL, connection);
                //Open the connection
                connection.Open();
                //Create a SQL Data Reader object
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                //Keep reading as long as I have data from the database to read



                while (reader.Read())
                {

                    if (reader["SERV_NAME"] != DBNull.Value)
                    {
                        returning += reader["SERV_NAME"] as string + " \n";
                    }

                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not retrieve services for the client from Database.! \n Error reads: " + ex.Message);
            }
            return returning;
        }

        private void FillReport() 
        {
            if (ClientsObjList.Count > 0)
            {
                decimal total = 0.00m;
                decimal payment = 0.00m;
                decimal avgBal = 0.00m;

                foreach (AClient client in ClientsObjList)
                {
                    dgvReports.Rows.Add(client.FirstName, client.LastName, client.Company, GetServ(client.ClientID), 
                        string.Format("{0:#,0.00}", client.TotalBill), 
                        string.Format("{0:#,0.00}", client.Balance), 
                        string.Format("{0:#,0.00}", client.PaymentAmount), client.DateSent);
                    total += client.TotalBill;
                    payment += client.PaymentAmount;

                    avgBal = avgBal + client.Balance;

                }
                lbxReport.Items.Add("Total Billing: "+ string.Format("{0:#,0.00}", total));
                lbxReport.Items.Add("Payments: " + string.Format("{0:#,0.00}", payment));
                lbxReport.Items.Add("Still Owed: " + string.Format("{0:#,0.00}", avgBal));
                

            }
            else dgvReports.Rows.Add("No clients found that match search");


        }
    }
}
