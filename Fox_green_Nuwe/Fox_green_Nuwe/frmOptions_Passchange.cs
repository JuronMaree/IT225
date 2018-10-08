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
    public partial class frmOptions_Passchange : Form
    {
        public OleDbConnection myDb;
        public string clientID;

        public frmOptions_Passchange()
        {
            InitializeComponent();
        }

        public frmOptions_Passchange(OleDbConnection myDb1, string iDs)
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


 
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                myDb.Open();

                
                string wW = "";

                string queryString = "SELECT * FROM Agent WHERE AgentID=" + clientID + "";

                
                    try
                    {
                        OleDbCommand command = new OleDbCommand(queryString, myDb);
                       
                        OleDbDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            wW = reader.GetValue(5).ToString();
                        }
                        reader.Close();
                        
                    }
                    catch { MessageBox.Show("Data nie gevind nie."); }
                

                if (wW != txtOud.Text)
                {
                    MessageBox.Show("Wagwoord is nie reg nie.");
                    txtOud.Clear();
                }
                else if (txtNuwe.Text != txtHerhaal.Text)
                {
                    MessageBox.Show("Nuwe wagwoord is nie dieselfde nie.");
                }
                else if (txtNuwe.Text == txtHerhaal.Text)
                {
                    try
                    {



                        OleDbDataAdapter queryAdapter = new OleDbDataAdapter(@"SELECT * FROM Agent WHERE AgentID=" + clientID + "", myDb);
                        string Query = @"UPDATE Agent SET AgentWagwoord= '" + txtNuwe.Text + "'";
                        OleDbCommand cmd = new OleDbCommand(Query, myDb);

                        queryAdapter.InsertCommand = cmd;

                        queryAdapter.InsertCommand.ExecuteNonQuery();

                       

                        MessageBox.Show("Wagwoord is verander.");


                    }
                    catch { MessageBox.Show("Fout met die database."); }

                    myDb.Close();

                    MessageBox.Show("DB Opened");
                    this.Close();
                    frmAdmin frmBack = new frmAdmin(myDb, clientID);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}
