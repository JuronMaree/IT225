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
  
    public partial class frmVerkope_Edit : Form
    {
        OleDbConnection myDb;
        public string clientID;
        public int editID;

        public frmVerkope_Edit()
        {
            InitializeComponent();
        }
        public frmVerkope_Edit(OleDbConnection myDb1, string iDs, int idi)
        {
            InitializeComponent();
            MYDB = myDb1;

            CLIENTID = iDs;
            EDITID = idi;


            //LEES AL DIE DATA IN van die editID af
            // en laai dit in die plekke in
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

        public int EDITID
        {
            get
            {
                return this.editID;
            }
            set
            {
                this.editID = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // update die data


            try
            {
                myDb.Open();
                myDb.Close();

                MessageBox.Show("DB Opened");
                this.Close();
                frmVerkope frmBack = new frmVerkope(myDb, clientID);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

        }

        private void frmVerkope_Edit_Load(object sender, EventArgs e)
        {

        }
    }
}
