using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Fox_green_Nuwe
{
    public partial class frmOptions_edit : Form
    {
        public OleDbConnection myDb;
        public string clientID;
        string adress = "";

        public frmOptions_edit()
        {
            InitializeComponent();
        }

        public frmOptions_edit(OleDbConnection myDb1, string iDs)
        {
            InitializeComponent();
            MYDB = myDb1;

            CLIENTID = iDs;

        }

        public OleDbConnection MYDB
        {
            get
            {
                return this.myDb;
            }
            set
            {
                this.myDb = value;
            }
        }

        public string CLIENTID
        {
            get
            {
                return this.clientID;
            }
            set
            {
                this.clientID = value;
            }
        }

        private void frmOptions_edit_Load(object sender, EventArgs e)
        {
            

            string queryString = "SELECT * FROM Agent WHERE AgentID=" + clientID + "";

            try
            {
                
                    OleDbCommand command = new OleDbCommand(queryString, myDb);
                    myDb.Open();
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {

                        string agentN = reader.GetValue(2).ToString();
                        string agentId = reader.GetValue(0).ToString();
                        string agentV = reader.GetValue(3).ToString();
                        string tel = reader.GetValue(7).ToString();
                        string epos = reader.GetValue(4).ToString();
                        Boolean admin = reader.GetBoolean(11);
                        string adress = reader.GetValue(1).ToString();
                        string aantalVh = reader.GetValue(9).ToString();
                        string aantalVk = reader.GetValue(8).ToString();

                        txtName.Text = agentN;
                        txtSurname.Text = agentV;
                        txtTelefoon.Text = tel;
                        txtAdress.Text = adress;
                        txtEpos.Text = epos;


                    }
                    reader.Close();

                    string queryString1 = "SELECT * FROM Adres WHERE AdresID='" + adress + "'";

                    OleDbCommand command1 = new OleDbCommand(queryString1, myDb);

                    OleDbDataReader reader1 = command1.ExecuteReader();

                    while (reader1.Read())
                    {

                        string adressN = reader.GetValue(2).ToString();
                        string adressNr = reader.GetValue(1).ToString();

                        txtAdress.Text = adressNr;
                        txtAdresNaam.Text = adressN;


                    }
                    reader1.Close();
                    myDb.Close();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmOptions_Passchange p1 = new frmOptions_Passchange(myDb, clientID);
            p1.Show();
            //this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                myDb.Open();
               

                OleDbDataAdapter queryAdapter = new OleDbDataAdapter(@"SELECT * FROM Agent WHERE AgentNaam='" + txtName.Text + "'", myDb);

               string Query = "UPDATE Agent SET AgentNaam='" + txtName.Text + "', AgentVan='"
                    + txtSurname.Text + "',AgentEpos='" + txtEpos.Text + "',AgentTelefoon='" + txtTelefoon.Text + "' WHERE AgentNaam='" + txtName.Text + "'";

                OleDbCommand cmd = new OleDbCommand(Query, myDb);

                queryAdapter.InsertCommand = cmd;

                queryAdapter.InsertCommand.ExecuteNonQuery();

                
                OleDbDataAdapter queryAdapter1 = new OleDbDataAdapter(@"SELECT * FROM Adres WHERE AdresID='" + adress + "'", myDb);

                string Query1 = "UPDATE Adres SET StraatNom='" + txtAdress.Text + "', StraatNaam='"
                     + txtAdresNaam.Text +  "' WHERE AdresID='" + adress + "'";

                OleDbCommand cmd1 = new OleDbCommand(Query1, myDb);

                queryAdapter1.InsertCommand = cmd1;

                queryAdapter1.InsertCommand.ExecuteNonQuery();



                myDb.Close();
                MessageBox.Show("DB Opened");
                this.Close();
                frmAdmin frmBack = new frmAdmin(myDb, clientID);

                
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

        }
    }
}
