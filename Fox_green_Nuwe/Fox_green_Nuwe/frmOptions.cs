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
    public partial class frmOptions : Form
    {
        public OleDbConnection myDb;
        public string clientID;

        public frmOptions()
        {
            InitializeComponent();
        }

        public frmOptions(OleDbConnection myDb1, string iDs)
        {
            InitializeComponent();
            MYDB = myDb1;

            CLIENTID = iDs;
            // wys mooi all sy inliging onder mekaar
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

        private void frmOptions_Load(object sender, EventArgs e)
        {

           

            string performance = "";

            string queryString = "SELECT * FROM Agent WHERE AgentID=" + clientID + "";


            using (OleDbConnection connection = new OleDbConnection(Properties.Settings.Default.FoxgreenDatabaseConnectionString))
            {
                OleDbCommand command = new OleDbCommand(queryString, connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    performance += reader.GetValue(2).ToString();
                    performance += reader.GetValue(3).ToString() + "\n";
                    performance += "\nAantal huise verkoop: " + reader.GetValue(8).ToString() + "\n";
                    performance += "Aantal huise verhuur: " + reader.GetValue(9).ToString();


                }
                reader.Close();

                txtPerformance.Text = performance;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmOptions_edit e1 = new frmOptions_edit(myDb, clientID);
            e1.Show();
            // this.Hide();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenu drm =new frmMenu(myDb, clientID);
            drm.Show();
            this.Close();
        }
    }
}
