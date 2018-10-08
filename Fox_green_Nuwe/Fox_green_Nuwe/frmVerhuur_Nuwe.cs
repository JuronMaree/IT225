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
    public partial class frmVerhuur_Nuwe : Form
    {
        OleDbConnection myDb;
        public string clientID;

        public frmVerhuur_Nuwe()
        {
            InitializeComponent();
        }
        public frmVerhuur_Nuwe(OleDbConnection myDb1, string iDs)
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


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                myDb.Open();
                myDb.Close();

                MessageBox.Show("DB Opened");
                this.Close();
                frmVerhuur frmBack = new frmVerhuur(myDb, clientID);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

        }
    }
}
