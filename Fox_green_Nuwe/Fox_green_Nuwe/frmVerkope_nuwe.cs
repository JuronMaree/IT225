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
    public partial class frmVerkope_nuwe : Form
    {
        OleDbConnection myDb;
        public string clientID;

        public frmVerkope_nuwe()
        {
            InitializeComponent();
        }

        public frmVerkope_nuwe(OleDbConnection myDb1, string iDs)
        {
            InitializeComponent();
            MYDB = myDb1;

            CLIENTID = iDs;


            myDb.Close();
            MessageBox.Show(clientID);
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

        private void frmVerkope_nuwe_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {


            try
            {
                myDb.Open();
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
