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
    public partial class frmVerhuur : Form
    {
        public OleDbConnection myDb;
        public string clientID;

        public frmVerhuur()
        {
            InitializeComponent();
        }

        public frmVerhuur(OleDbConnection myDb1, string iDs)
        {
            InitializeComponent();
            MYDB = myDb1;

            CLIENTID = iDs;
            try
            {

                myDb.Open();
                myDb.Close();
                MessageBox.Show("dAtabase Sucessfull ");
       
             

            }
            catch (OleDbException)
            {
                MessageBox.Show("Somthing went wrong with the Database plz reset program");
            }
        }

            private void MenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu1 = new frmMenu(myDb, clientID);
            frmMenu1.Show();
            this.Close();
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
            frmVerhuur_Nuwe frmNuwe = new frmVerhuur_Nuwe(myDb, clientID);
            frmNuwe.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //kry die selected row en stuur dit vir die volgende form
            frmVerhuur_Edit f3 = new frmVerhuur_Edit(myDb, clientID, 3); // DIE 3 MOet die selected een wees wat verander moet word
            f3.Show();
            //this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // GEEN FORM SLEGS EEn VERANDERRING AAND DIE EEN WAT SELECTED IS IN DATAGRID VIEW BV :
            // dataGridView1.SelectedRows
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmVerhuur_Soek f3 = new frmVerhuur_Soek();
            f3.Show();
            //this.Hide();
        }
    }
}
