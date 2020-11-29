/// Grenci CPA 411 Project
/// Authors: Justin Bloss, Will Hoffman, Victor Stahlman, & Cameron Weaver
/// Project goal: make a program for Dr. Anthony Grenci to use at his CPA firm to keep track of billing, and automate the calculation process.
/// Page: This page is for the adding and editing of clients. there are several fields that they tab through and fill up, it works the same for editing as well
/// there also is a list that holds compnents that can be assigned to the client as reminders for the staff doing the work.
/// 
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
    public partial class AddClient : Form
    {


        //sql stuff
        private string connectionString;
        private SqlCommand command;
        private SqlConnection connection;

        private bool isEdit = true;
        private int clientID = 0;

        //these are for the saving and editing of the characteristics tied to the client.
        private List<AChar> charList = new List<AChar>();
        


        //constructors
        public AddClient()//for the add
        {
            InitializeComponent();

            GetChar();
            isEdit = false;

        }

        public AddClient(int pClientID)//for the edit
        {
            
            InitializeComponent();
            clientID = pClientID;
            CreateClientList();
            FillClientInfo();
            
        }


        /// <summary>
        /// creates the information displayed in the form in the Aclient class and read in from the Database
        /// </summary>
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


        /// <summary>
        /// Gets the characteristics for the client. if it is a new client all are unchecked and and for old the same checks are in place
        /// </summary>
        private void GetChar()
        {
            clbChar.Items.Clear();

            string GetCharSQL = "SELECT * FROM CHARACTERISTIC_TABLE;";

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
                {
                    AChar tempchar = new AChar();

                    if (reader["CHAR_NAME"] != DBNull.Value)
                    {

                        
                            clbChar.Items.Add(reader["CHAR_NAME"] as string);

                            tempchar.CharName = reader["CHAR_NAME"] as string;
                            tempchar.CharID = (reader["CHAR_ID"] as int?) ?? 0;


                            charList.Add(tempchar);
                    }

                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not retrieve characteristics from Database.! \n Error reads: " + ex.Message);
            }

            //changes the string to go into the char table and CTC table. this will allow us to read in and check the items in the checked list box
            GetCharSQL = "SELECT CHARACTERISTIC_TABLE.CHAR_NAME, CTC_TABLE.CTC_ID, CTC_TABLE.CLIENT_ID " +
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

                int i = -1; //this is used to keep track of what index in the clb we are working on
                string storedName = "nothing";
                while (reader.Read())// this will read through all the info in the char table and then it will check the box if it is 
                {
                    if (reader["CHAR_NAME"] != DBNull.Value && reader["CHAR_NAME"] as string != storedName)//if not a repeat
                    {
                        i++;
                        storedName = reader["CHAR_NAME"] as string;
                    }
                    foreach (AChar aChar in charList)
                    {
                        if (clbChar.Items[i].ToString() == aChar.CharName)//these are the ones selected that came in with the inport
                        {
                            if (reader["CLIENT_ID"].ToString() == clientID.ToString())//marked as being incoming to save
                            {
                                charList[i].CharClient = clientID;//puts in the client id for the sorting and checking process
                                charList[i].CharMini = (reader["CTC_ID"] as int?) ?? 0; //arbitrary but it marks it for recycling first 

                                clbChar.SetItemChecked(i, true);//this will check the ones that have the relation correct.
                            }

                        }

                    }
                    
                }
                
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not retrieve characteristics from Database.! \n Error reads: " + ex.Message);
            }

        }


        /// <summary>
        /// This saves the characteristics to the client from the updated list. it will also remove the ones that are no longer in use
        /// </summary>
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
            int affectedrows = 0; //this is to keep track of what all was deleted row wise

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
                        
                        //testing stuff
                        //if (rowsAffected > 0)
                        //{
                        //    MessageBox.Show(achar.CharName + " was re-assigned!");
                        //}
                        //else
                        //{
                        //    MessageBox.Show(achar.CharName + " was not re-assigned!");
                        //}
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


                        //if (rowsAffected > 0)
                        //{
                        //    MessageBox.Show( achar.CharName + " was assigned!");
                        //}
                        //else
                        //{
                        //    MessageBox.Show(achar.CharName + " was not assigned!");
                        //}
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

                        affectedrows += command.ExecuteNonQuery() - 1;//stores the number which should always be one or 0 in the var after deletion

                        connection.Close();
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Could not update the table " + ex.Message);
                    }
                    //end deletion
                }
            }
            if (affectedrows != 0)
            {
                MessageBox.Show(affectedrows + " rows were Deleted from the system");
            }
        }

        
        /// <summary>
        /// this saves all the rest of the in formation for the user. 
        /// </summary>
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
                "COUNTY = @COUNTY, SCHOOL = @SCHOOL, EMAIL = @EMAIL, PHONE = @PHONE, SS= @SS, IS_BUSINESS = @IS_BUSINESS, NOTES = @NOTES, COMPANY_NAME = @COMPANY_NAME," +
                "CLIENT_ACTIVE = @CLIENT_ACTIVE, PREFERRED_CON = @PREFERRED_CON " +
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

                int rowsAffected = 0;
                if (!isEdit)
                {
                    var lastID = command.ExecuteScalar(); //this gets the data of the client that was just added into the system
                    clientID = Convert.ToInt32(lastID);
                }
                else rowsAffected = command.ExecuteNonQuery();

                connection.Close();

                SaveChar();
                this.Close();

                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Could not open or insert data! \nPlease retry a new submit with shorter lenghts if needed \nError: " + ex.Message);
            }
        }
    


        //this is a middle function we use from the template we used for most pages that we added all the start up stuff we did
        private void FillClientInfo()
        {
            
            GetChar();
            
        }

        

        //////////////////////////////////////////BUTTONS\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        
        /// <summary>
        /// this askes the user if they want to stay and save what is there or not
        /// </summary>
        
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


        //saves with the save functions and it closes the page
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveOthers();
            

            this.Close();
        }
    }
}
