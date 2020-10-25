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
    public partial class AddClient : Form
    {


        //sql stuff
        private string connectionString;
        private SqlCommand command;
        private SqlConnection connection;

        private bool isEdit = false;
        private int clientID = 0;

        //these are for the saving and editing of the characteristics tied to the client.
        private List<AChar> charList = new List<AChar>();
        


        public AddClient()
        {
            InitializeComponent();

            GetChar();

        }

        public AddClient(int pClientID)
        {
            
            InitializeComponent();
            clientID = pClientID;
            CreateClientList();
            FillClientInfo();
            isEdit = true;
        }

        private void CreateClientList()
        {

            
            string GetClientsSQL = "SELECT CLIENT_ID, CLIENT_ACTIVE, FIRST_NAME, LAST_NAME, SS, BIRTHDATE, ST_ADDRESS, " +
                "CITY, STATE_AB, ZIP, COUNTY, SCHOOL, EMAIL, PHONE, IS_BUSINESS, COMPANY_NAME, PARENT_CLIENT, NOTES, OWED_BALANCE " +
                "FROM CLIENT_TABLE WHERE CLIENT_ID = " + clientID + ";";
            
            

            //Pulled from App.config
            connectionString = Properties.Settings.Default.GrenciDBConnectionString;
            try
            {
                connection = new SqlConnection(connectionString);
                command = new SqlCommand(GetClientsSQL, connection);
                //Open the connection
                connection.Open();
                //Create a SQL Data Reader object
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                //Keep reading as long as I have data from the database to read



                while (reader.Read())
                {

                    AClient tempClient = new AClient();

                    
                        tbxFirst.Text = reader["FIRST_NAME"] as string;                    
                        tbxLast.Text = reader["LAST_NAME"] as string;
                    
                    
                        tbxAddress.Text  = reader["ST_ADDRESS"] as string;
                        tbxCity.Text = reader["CITY"] as string;                    
                        tbxState.Text = reader["STATE_AB"] as string;                    
                        tbxZip.Text =  reader["ZIP"] as string;                    
                        tbxCounty.Text  = reader["COUNTY"] as string;                    
                        tbxSchool.Text = reader["SCHOOL"] as string;
                     
                        tbxEmail.Text  = reader["EMAIL"] as string;                    
                        tbxCell.Text = reader["PHONE"] as string;
                        //preferred contact is in works
                        
                        tbxSSN.Text = reader["SS"] as string;
                        tbxBirth.Text = reader["BIRTHDATE"] as string;

                    if (reader["IS_BUSINESS"] != DBNull.Value)
                    {
                        tempClient.IsBusiness = reader.GetBoolean(reader.GetOrdinal("IS_BUSINESS"));
                    }
                    
                    tbxNotes.Text = reader["NOTES"] as string;

                    //still working on this stuff
                    
                    if (reader["COMPANY_NAME"] != DBNull.Value)
                    {
                        tempClient.Company = reader["COMPANY_NAME"] as string;
                    }
                    if (reader["PARENT_CLIENT"] != DBNull.Value)
                    {
                        tempClient.ParentID = (reader["PARENT_CLIENT"] as int?) ?? 0;
                    }
                    if (reader["CLIENT_ACTIVE"] != DBNull.Value)
                    {
                        tempClient.Active = reader.GetBoolean(reader.GetOrdinal("CLIENT_ACTIVE"));
                    }


                    //if (reader["PREFERRED_CON"] != DBNull.Value)
                    //{
                    //    cboContact.Text = reader["PREFERRED_CON"] as string;
                    //}
                    //else tempClient.Preferred = "Unset";


                    //Add the temporary plot stuff from list.


                    tempClient = null;
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not retrieve clients from Database.! \n Error reads: " + ex.Message);
            }



        }

        private string GetParent(int aClientID)//work in progress
        {
            string returning = "";
            string GetParentSQL = "SELECT FIRST_NAME, LAST_NAME FROM CLIENT_TABLE WHERE CLIENT_ID =" + aClientID + ";";
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

                    AClient tempClient = new AClient();


                    if (reader["FIRST_NAME"] != DBNull.Value)
                    {
                        tempClient.FirstName = reader["FIRST_NAME"] as string;
                    }
                    if (reader["LAST_NAME"] != DBNull.Value)
                    {
                        tempClient.LastName = reader["LAST_NAME"] as string;
                    }
                    if (reader["IS_BUSINESS"] != DBNull.Value)
                    {
                        tempClient.IsBusiness = reader.GetBoolean(reader.GetOrdinal("IS_BUSINESS"));
                    }
                    else tempClient.IsBusiness = false;
                    if (reader["COMPANY_NAME"] != DBNull.Value)
                    {
                        tempClient.Company = reader["COMPANY_NAME"] as string;
                    }

                    if (tempClient.IsBusiness) returning = tempClient.Company;
                    else returning = tempClient.FirstName + " " + tempClient.LastName;

                    tempClient = null;
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not retrieve parent client from Database.! \n Error reads: " + ex.Message);
            }
            return returning;
        }

        private void GetChar()
        {
            clbChar.Items.Clear();

            string GetCharSQL = "SELECT CHARACTERISTIC_TABLE.CHAR_ID, CHARACTERISTIC_TABLE.CHAR_NAME, CTC_TABLE.CTC_ID, CTC_TABLE.CLIENT_ID " +
                "FROM CHARACTERISTIC_TABLE LEFT OUTER JOIN CTC_TABLE ON CHARACTERISTIC_TABLE.CHAR_ID = CTC_TABLE.CHAR_ID" ;

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

                

                while (reader.Read())// this will read through all the info in the char table and add them to the checked list box
                                    // if it is a id 0 0  it is ment to be recycled into the system again.
                {
                    AChar tempchar = new AChar();

                    if (reader["CHAR_NAME"] != DBNull.Value)
                    {
                        if (clbChar.Items.Count == 0)
                        {
                            clbChar.Items.Add(reader["CHAR_NAME"] as string);

                            tempchar.CharName = reader["CHAR_NAME"] as string;
                            tempchar.CharID = (reader["CHAR_ID"] as int?) ?? 0;

                            if (reader["CLIENT_ID"] != DBNull.Value)
                            //if there is a char that has a ctc connection that is for the present client
                            {
                                if (reader["CLIENT_ID"].ToString() == clientID.ToString())//marked as being incoming
                                {
                                    tempchar.CharClient = clientID;//puts in the client id for the sorting and checking process
                                    tempchar.CharMini = (reader["CTC_ID"] as int?) ?? 0; //arbitrary but it marks it for recycling first 
                                }
                            }
                            charList.Add(tempchar);
                        }

                        else if (reader["CHAR_NAME"] as string != charList[charList.Count - 1].CharName ) 
                            //if the new char name is the same as the last item then it is a repeat and does not need read in
                        {
                            clbChar.Items.Add(reader["CHAR_NAME"] as string);
                            tempchar.CharName = reader["CHAR_NAME"] as string;
                            tempchar.CharID = (reader["CHAR_ID"] as int?) ?? 0;

                            if (reader["CLIENT_ID"] != DBNull.Value)
                            //if there is a char that has a ctc connection that is for the present client
                            {
                                if (reader["CLIENT_ID"].ToString() == clientID.ToString())//marked as being incoming
                                {
                                    tempchar.CharClient = clientID;//puts in the client id for the sorting and checking process
                                    tempchar.CharMini = (reader["CTC_ID"] as int?) ?? 0; //arbitrary but it marks it for recycling first 
                                }
                            }
                            charList.Add(tempchar);
                        }

                        

                    }
                    
                    

                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not retrieve characteristics from Database.! \n Error reads: " + ex.Message);
            }

            //goes through the clb and checks the boxes of the charactoristics that are set on the client.
            
            for (int i = 0; i < clbChar.Items.Count; i++)
            {
                foreach (AChar aChar in charList)
                {
                    if (clbChar.Items[i].ToString() == aChar.CharName && aChar.CharClient == clientID && clientID != 0)
                    {
                        clbChar.SetItemChecked(i, true);//this will check the ones that have the relation correct.
                    }
                }
            }

            
        }

        private void SaveChar()
        {


            //this travels through the checked list box and then gets the ids that were saved out of the the clb
            for (int i = 0; i < clbChar.CheckedItems.Count; i++)
            {
                foreach (AChar aChar in charList)
                {
                    if (clbChar.CheckedItems[i].ToString() == aChar.CharName)//these are the ones selected that came in with the inport
                    {
                        aChar.CharAsso = 7;//this is an arbatrary use of the association between services and char, 
                                           //  but it will have nothing in it so it can be used freely for a flagging 
                                           //  of that specific one to be commited into a change to the database.

                    }
                    //else charList.Remove(aChar);//removes from the list due to it not being something that
                }
            }
            
            foreach(AChar aChar in charList)
            {
                if (aChar.CharAsso == 7 && aChar.CharMini != 0 ) //if this is aChar recycled it will flag it a different number
                {
                    aChar.CharAsso = 8;//this is an arbatrary use of the association between services and char, 
                                       //  but it will have nothing in it so it can be used freely for a flagging 
                                       //  of that specific one to be commited into a change to the database.
                    
                }
                else if (aChar.CharMini != 0) //this means that the item is ready to recycle but is not being used again
                {
                    aChar.CharAsso = 9;//tags for deletion of that row in the transition table. 
                }


                //else it stays 7 and the loop continues
            }

            //this section saves the char relations between this client and the id of the char. It updates ones that were used or are now ready to be reused.

            foreach (AChar achar in charList)// loops through and updates the ones set up 
            {
                if (achar.CharAsso == 8) // this is set to be the CTC id for the ones that are being used
                {
                    
                    string SetCharSQL = "UPDATE CTC_TABLE SET CLIENT_ID = @pClientID, " +
                        "CHAR_ID = @pCharID WHERE CTC_ID = " + achar.CharMini + ";";    //charmini is CTCID in a random var to store as a flag
                    //Pulled from App.config
                    connectionString = Properties.Settings.Default.GrenciDBConnectionString;
                    try
                    {
                        connection = new SqlConnection(connectionString);
                        command = new SqlCommand(SetCharSQL, connection);
                        //Open the connection
                        connection.Open();

                        command.Parameters.AddWithValue("@pClientID", clientID);
                        command.Parameters.AddWithValue("@pCharID", achar.CharID);


                        int rowsAffected = command.ExecuteNonQuery();//tells ya if it worked
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show(achar.CharName + " was re-assigned!");
                        }
                        else
                        {
                            MessageBox.Show(achar.CharName + " was not re-assigned!");
                        }
                        connection.Close();
                        

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Could not update the table " + ex.Message);
                    }//end recycle
                }
                else if (achar.CharAsso == 7) // adding to the db
                {

                    string SetCharSQL = "INSERT INTO CTC_TABLE (CLIENT_ID, CHAR_ID)  " +
                        " VALUES (@pClientID, @pCharID ) ;"; 
                    //Pulled from App.config
                    connectionString = Properties.Settings.Default.GrenciDBConnectionString;
                    try
                    {
                        connection = new SqlConnection(connectionString);
                        command = new SqlCommand(SetCharSQL, connection);
                        //Open the connection
                        connection.Open();

                        command.Parameters.AddWithValue("@pClientID", clientID);
                        command.Parameters.AddWithValue("@pCharID", achar.CharID);


                        int rowsAffected = command.ExecuteNonQuery();//tells ya if it worked
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show( achar.CharName + " was assigned!");
                        }
                        else
                        {
                            MessageBox.Show(achar.CharName + " was not assigned!");
                        }
                        connection.Close();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Could not add characteristics to the table " + ex.Message);
                    }//end creation
                }
                else if (achar.CharAsso == 9) //removing the line from the db
                {

                    string SQLDel = "UPDATE CTC_TABLE SET CLIENT_ID = NULL, CHAR_ID = NULL WHERE CTC_ID = " + achar.CharMini + //
                        "; DELETE FROM CTC_TABLE WHERE CTC_ID = " + achar.CharMini + ";";

                    //charmini is CTCID in a random var to store as a flag and if asso is 9 then it is flagged for deletion

                    //Pulled from App.config
                    connectionString = Properties.Settings.Default.GrenciDBConnectionString;
                    try
                    {
                        connection = new SqlConnection(connectionString);
                        command = new SqlCommand(SQLDel, connection);
                        //Open the connection
                        connection.Open();

                        int affectedrows = command.ExecuteNonQuery();//stores the number which should always be one or 0 in the var after deletion

                        connection.Close();
                        if (affectedrows != 0)
                        {
                            MessageBox.Show(affectedrows + " rows were Deleted from the system");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Could not update the table " + ex.Message);
                    }
                    //end deletion
                }
            }
        }

        private void SaveOthers()
        {
            string SetOtherSQL = "INSERT INTO CLIENT_TABLE (FIRST_NAME, LAST_NAME, BIRTHDATE, " +
                "ST_ADDRESS, CITY, STATE_AB, ZIP, COUNTY, SCHOOL, EMAIL, PHONE, " +
                "SS, IS_BUSINESS, NOTES, COMPANY_NAME, CLIENT_ACTIVE, PREFERRED_CON) " +
                "OUTPUT INSERTED.CLIENT_ID " +
                "VALUES (@FIRST_NAME, @LAST_NAME, @BIRTHDATE, @ST_ADDRESS, @CITY, @STATE_AB, @ZIP, " +
                "@COUNTY, @SCHOOL, @EMAIL, @PHONE, @SS, @IS_BUSINESS, @NOTES, @COMPANY_NAME, @CLIENT_ACTIVE, @PREFERRED_CON ); ";

            if (isEdit) SetOtherSQL = " UPDATE CLIENT_TABLE SET FIRST_NAME = @FIRST_NAME, LAST_NAME = @LAST_NAME, BIRTHDATE = @BIRTHDATE, " +
                    "ST_ADDRESS = @ST_ADDRESS, CITY = @CITY, STATE_AB = @STATE_AB, ZIP = @ZIP, " +
                "COUNTY = @COUNTY, SCHOOL = @SCHOOL, EMAIL = @EMAIL, PHONE = @PHONE, PREFERRED_CON = @PREFERRED_CON " +
                        "WHERE CLIENT_ID= " + clientID + " ; ";
            connectionString = Properties.Settings.Default.GrenciDBConnectionString;
            try
            {
                connection = new SqlConnection(connectionString);
                command = new SqlCommand(SetOtherSQL, connection);
                //Open the connection
                connection.Open();

                
                command.Parameters.AddWithValue("@FIRST_NAME", tbxFirst.Text);
                command.Parameters.AddWithValue("@LAST_NAME", tbxLast.Text);
                command.Parameters.AddWithValue("@BIRTHDATE", tbxBirth.Text);
                command.Parameters.AddWithValue("@ST_ADDRESS", tbxAddress.Text);
                command.Parameters.AddWithValue("@CITY", tbxCity.Text);
                command.Parameters.AddWithValue("@STATE_AB", tbxState.Text);
                command.Parameters.AddWithValue("@ZIP", tbxZip.Text);
                command.Parameters.AddWithValue("@COUNTY", tbxCounty.Text);
                command.Parameters.AddWithValue("@SCHOOL", tbxSchool.Text);
                command.Parameters.AddWithValue("@EMAIL", tbxEmail.Text);
                command.Parameters.AddWithValue("@PHONE",tbxCell.Text );
                command.Parameters.AddWithValue("@SS", tbxSSN.Text);
                if(tbxCompany.Text == "") command.Parameters.AddWithValue("@IS_BUSINESS", 0);
                else command.Parameters.AddWithValue("@IS_BUSINESS", 1);
                command.Parameters.AddWithValue("@NOTES", tbxNotes.Text);
                command.Parameters.AddWithValue("@COMPANY_NAME", tbxCompany.Text);
                command.Parameters.AddWithValue("@CLIENT_ACTIVE", 1);
                command.Parameters.AddWithValue("@PREFERRED_CON", 1 );


                if (!isEdit)
                {
                    var lastID = command.ExecuteScalar(); //this gets the data of the client that was just added into the system
                    clientID = Convert.ToInt32(lastID);
                }


                int rowsAffected = command.ExecuteNonQuery();

                connection.Close();

                if (isEdit)
                {
                    if (rowsAffected > 0)//if added it will say it did, if not it said it will not
                    {
                        MessageBox.Show("Client was Updated! \n Close Client View and re-enter to see changes.!!");
                    }
                    else
                    {
                        MessageBox.Show("No Client was Updated!!");
                    }
                }
                else
                {
                    if (rowsAffected > 0)//if added it will say it did, if not it said it will not
                    {
                        MessageBox.Show("New Client added! \nClose Client View and re-enter to see changes.!!");
                    }
                    else
                    {
                        MessageBox.Show("No Client was added!!");
                    }
                }

                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Could not open or insert data! \nError: " + ex.Message);
            }
        }
    

        private void FillClientInfo()
        {
            
            GetChar();
            
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveOthers();
            SaveChar();

            this.Close();
        }
    }
}
