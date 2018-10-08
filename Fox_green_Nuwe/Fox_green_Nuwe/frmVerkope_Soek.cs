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
    public partial class frmVerkope_Soek : Form
    {
      
        OleDbConnection myDb;
        public string clientID;

        public frmVerkope_Soek()
        {
            InitializeComponent();
        }

        public frmVerkope_Soek(OleDbConnection myDb1, string iDs)
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
                myDb.Close();

                MessageBox.Show("DB Opened");
                this.Close();
                frmVerkope frmBack = new frmVerkope(myDb, clientID);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            //  frmVerkope_Soek2 search = new frmVerkope_Soek2(this);
            //  search.Show();
            // hy moet alles wat in die search paramater is in die datgrid view wys (kontak my voor jy die doen ) 
        }

        private void frmVerkope_Soek_Load(object sender, EventArgs e)
        {

        }
    }
}
