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
    public partial class frmVerkope : Form
    {
        public OleDbConnection myDb;
        public string clientID;

        public frmVerkope()
        {
            InitializeComponent();
        }

        public frmVerkope(OleDbConnection myDb1, string iDs)
        {
            InitializeComponent();
            MYDB = myDb1;

            CLIENTID = iDs;

            try
            {

                myDb.Open();
                MessageBox.Show("dAtabase Sucessfull ");
                /*  OleDbDataAdapter adapt = new OleDbDataAdapter(@"SELECT * FROM Eiendom", myDb)
                              ; // wys net eiendom naam en detail niks van ID nie WHERE eiendomtipe =tekoop

                  DataSet ds = new DataSet();
                  adapt.Fill(ds, "Eiendom");
                  dataGridView1.DataSource = ds;
                  dataGridView1.DataMember = "Eiendom";
  */
                myDb.Close();
                
            }
            catch (OleDbException)
            {
                MessageBox.Show("Somthing went wrong with the Database plz reset program");
            }
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


        private void verhuringsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu1 = new frmMenu(myDb, clientID);
            frmMenu1.Show();
                this.Close();
        }

        private void frmVerkope_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                frmVerkope_nuwe f1 = new frmVerkope_nuwe( myDb, clientID);
                // Verkope_Form frmVerkope = new Verkope_Form(myDb, clientID);
                f1.Show();
              //  this.Hide();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmVerkope_Edit f3 = new frmVerkope_Edit(myDb, clientID, 3); // DIE 3 MOet die selected een wees wat verander moet word
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
            frmVerkope_Soek f3 = new frmVerkope_Soek();
            f3.Show();
            //this.Hide();
        }
    }
}
