using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Fox_green_Nuwe
{
    public partial class FrmAdmin_NUwe : Form
    {
        public OleDbConnection myDb;
        public string clientID;


        public FrmAdmin_NUwe()
        {
            InitializeComponent();
        }

        public FrmAdmin_NUwe(OleDbConnection myDb1, string iDs)
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

        private void btnSubmit_Click(object sender, EventArgs e)
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
