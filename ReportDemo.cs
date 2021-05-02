/// Grenci CPA 411 Project
/// Authors: Justin Bloss, Will Hoffman, Victor Stahlman, & Cameron Weaver
/// Project goal: make a program for Dr. Anthony Grenci to use at his CPA firm to keep track of billing, and automate the calculation process.
/// Page: This page is for vieing the listing of payments made
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
using System.IO;
using System.Text.RegularExpressions;

namespace GrenciCPA
{
    public partial class ReportDemo : Form
    {
        private string connectionString;
        private SqlCommand command;
        private SqlConnection connection;

        //private AClient ClientsObj;
        private List<APayment> PaymentObjList;
        private int clientID = 0;

        public ReportDemo()
        {
            InitializeComponent();

            PaymentObjList = new List<APayment>();
            CreatePaymentList();
            FillPaymentList();
        }


        public ReportDemo(int pClientID)
        {
            InitializeComponent();
            clientID = pClientID;
            PaymentObjList = new List<APayment>();

            CreatePaymentList();
            FillPaymentList();
        }

        //gets the payments and puts them in a list
        private void CreatePaymentList()
        {

            string GetPaymentSQL = "SELECT PAYMENT_ID, PAYMENT_TYPE, PAYMENT_AMOUNT, DATE_PAID, pt.CLIENT_ID, " +
                "ct.FIRST_NAME, ct.LAST_NAME, ct.COMPANY_NAME, ct.IS_BUSINESS, ct.OWED_BALANCE  " +
                "FROM PAYMENT_TABLE pt INNER " +
                "JOIN CLIENT_TABLE ct on pt.CLIENT_ID = ct.CLIENT_ID WHERE CLIENT_ACTIVE = 1;";
            if(clientID != 0) GetPaymentSQL = "SELECT PAYMENT_ID, PAYMENT_TYPE, PAYMENT_AMOUNT, DATE_PAID, pt.CLIENT_ID, " +
                "ct.FIRST_NAME, ct.LAST_NAME, ct.COMPANY_NAME, ct.IS_BUSINESS, ct.OWED_BALANCE  " +
                "FROM PAYMENT_TABLE pt INNER " +
                "JOIN CLIENT_TABLE ct on pt.CLIENT_ID = ct.CLIENT_ID WHERE CLIENT_ACTIVE = 1  AND ct.CLIENT_ID = " + clientID + ";";

            connectionString = Properties.Settings.Default.GrenciDBConnectionString;
            try
            {
                connection = new SqlConnection(connectionString);
                command = new SqlCommand(GetPaymentSQL, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                while (reader.Read())
                {

                    APayment tempPayment = new APayment();


                    if (reader["PAYMENT_ID"] != DBNull.Value)
                    {
                        tempPayment.PaymentID = (reader["PAYMENT_ID"] as int?) ?? 0;
                    }
                    if (reader["CLIENT_ID"] != DBNull.Value)
                    {
                        tempPayment.ClientID = (reader["CLIENT_ID"] as int?) ?? 0;
                    }
                    if (reader ["FIRST_NAME"] != DBNull.Value)
                    {
                        tempPayment.ClientFirst = reader["FIRST_NAME"] as string;
                    }
                    if (reader ["LAST_NAME"] != DBNull.Value)
                    {
                        tempPayment.ClientLast = reader["LAST_NAME"] as string;
                    }
                    if (reader ["COMPANY_NAME"] != DBNull.Value)
                    {
                        tempPayment.CompanyName = reader["COMPANY_NAME"] as string;
                    }
                    if (reader ["IS_BUSINESS"] != DBNull.Value)
                    {
                        tempPayment.IsBusiness = reader.GetBoolean(reader.GetOrdinal("IS_BUSINESS"));
                    }
                    if (reader ["OWED_BALANCE"] != DBNull.Value)
                    {
                        tempPayment.OwedBalance = (reader["OWED_BALANCE"] as decimal?) ?? 0.00m;
                    }
                    if (reader["PAYMENT_TYPE"] != DBNull.Value)
                    {
                        tempPayment.PaymentType = reader["PAYMENT_TYPE"] as string;
                    }
                    if (reader["PAYMENT_AMOUNT"] != DBNull.Value)
                    {
                        tempPayment.PaymentAmt = (reader["PAYMENT_AMOUNT"] as decimal?) ?? 0.00m;
                    }
                    if(reader["DATE_PAID"] != DBNull.Value)
                    {
                        tempPayment.DatePaid = (DateTime)reader["DATE_PAID"];
                    }

                    PaymentObjList.Add(tempPayment);

                    tempPayment = null;
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //fills the datagridview
        private void FillPaymentList()
        {
            foreach (APayment aPayment in PaymentObjList)
            {
                dgvReports.Rows.Add(aPayment.ClientID, aPayment.ClientFirst, aPayment.ClientLast, aPayment.CompanyName, aPayment.PaymentID, 
                    string.Format("{0:#,0.00}", aPayment.PaymentAmt), aPayment.PaymentType, string.Format("{0:#,0.00}", aPayment.OwedBalance));
            }
        }


        //closes the form when clicked
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvReports.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "PaymentsOutput" + DateTime.Now.Month + DateTime.Now.Year + ".csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dgvReports.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[dgvReports.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dgvReports.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;



                            for (int i = 1; (i - 1) < dgvReports.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += dgvReports.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }
                            

                            int k = 0;
                            foreach (String st in outputCsv)
                            {
                                outputCsv[k] = Regex.Replace(st, "\n", " ");
                                k++;
                            }


                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            //MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }
    }
}
