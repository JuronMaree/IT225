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
    public partial class frmVerhuur_Edit : Form
    {
        OleDbConnection myDb;
        public string clientID;
        public int editID;

        public frmVerhuur_Edit()
        {
            InitializeComponent();
        }
        public frmVerhuur_Edit(OleDbConnection myDb1, string iDs, int idi)
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

        private void frmVerhuur_Edit_Load(object sender, EventArgs e)
        {

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
                frmVerhuur frmBack = new frmVerhuur(myDb, clientID);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

        }
    }
}
