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
    public partial class frmAdmin : Form
    {
        public OleDbConnection myDb;
        public string clientID;

        public frmAdmin()
        {
            InitializeComponent();
        }
        public frmAdmin(OleDbConnection myDb1, string iDs)
        {
            InitializeComponent();
            MYDB = myDb1;

            CLIENTID = iDs;
            myDb.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM Agent", myDb);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "List");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "List";
            myDb.Close();
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

        private void verkopeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmMenu main1 = new frmMenu(true, myDb, clientID);
            main1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdmin_NUwe frmNuwe = new FrmAdmin_NUwe(myDb, clientID);
            frmNuwe.Show();
            ////this.Hide();
            
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
          //  dataGridView1.SelectedRows 
        }
    }
}
