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
    public partial class frmMenu : Form
    {
        bool aDmin1;
        OleDbConnection myDb;
        public string clientID;

        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
        public frmMenu(bool adm, OleDbConnection myDb1, string iDs)
        {
            InitializeComponent();
            MYDB = myDb1;
            admin = adm;
            CLIENTID = iDs;


            if (aDmin1 == true)
            { btnAdmin.Enabled = true; }
            else
            { btnAdmin.Enabled = false; }
            myDb.Close();
            MessageBox.Show(clientID);
        }
        public frmMenu( OleDbConnection myDb1, string iDs)
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
        public bool admin
        {
            get
            {
                return this.aDmin1;
            }
            set
            {
                this.aDmin1 = value;
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
         

        }

        private void btnVerhuurings_Click(object sender, EventArgs e)
        {
          //  Verhuur_Form frmVerhuur = new Verhuur_Form(myDb, clientID);
          //  frmVerhuur.Show();
            this.Close();

        }

        private void btnNuweKliente_Click(object sender, EventArgs e)
        {
       

        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
          
        }

        private void btnAdmin_Click_1(object sender, EventArgs e)
        {
            frmAdmin frmAdmi1n = new frmAdmin(myDb, clientID);
            frmAdmi1n.Show();
            this.Close();
        }

        private void btnVerkope_Click(object sender, EventArgs e)
        {
              frmVerkope frmVerkoop = new frmVerkope(myDb, clientID);
            frmVerkoop.Show();
            this.Close();
        }

        private void btnOptions_Click_1(object sender, EventArgs e)
        {
             frmOptions frmOptions1 = new frmOptions(myDb, clientID);
              frmOptions1.Show();
            this.Close();
        }

        private void btnNuweKliente_Click_1(object sender, EventArgs e)
        {
            frmKliente f1 = new frmKliente(myDb, clientID);
            f1.Show();
            this.Close();
        }
    }
}
