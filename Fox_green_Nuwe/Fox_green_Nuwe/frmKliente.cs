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
    public partial class frmKliente : Form
    {
        public OleDbConnection myDb;
        public string clientID;
        

        

        public frmKliente()
        {
            InitializeComponent();
        }

        public frmKliente(OleDbConnection myDb1, string iDs)
        {
            InitializeComponent();
            MYDB = myDb1;

            CLIENTID = iDs;

            try
            {
                myDb.Open();

                OleDbDataAdapter queryAdapter = new OleDbDataAdapter(@"SELECT * FROM Klient", myDb);

                DataSet ds = new DataSet();

                queryAdapter.Fill(ds, "myList");

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "myList";

                myDb.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
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

        private void verkopeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerkope frmVerkope1 = new frmVerkope(myDb, clientID);
            frmVerkope1.Show();
            this.Close();
        }

        private void verhuringsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmVerhuur frm1 = new frmVerhuur(myDb, clientID);
         //  frm1.Show();
            this.Close();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOptions frmOptions1 = new frmOptions(myDb, clientID);
            frmOptions1.Show();
            this.Close();
        }

        private void frmKliente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKliente_nuwe kn = new frmKliente_nuwe(myDb, clientID);
            kn.Show();
            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cID = "";
           


            try
            {
                
                DataGridViewRow selectedRow = dataGridView1.Rows[0];
                cID = selectedRow.Cells[1].Value.ToString();
                //frmKliente_Edit f31 = new frmKliente_Edit(myDb, clientID, Convert.ToInt32(cID));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            frmKliente_Edit f3 = new frmKliente_Edit(myDb,clientID,Convert.ToInt32(cID)); // DIE 3 MOet die selected een wees wat verander moet word
            f3.Show();
            //this.Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
            myDb.Open();

            OleDbDataAdapter queryAdapter = new OleDbDataAdapter(@"SELECT * FROM Klient", myDb);

            DataSet ds = new DataSet();

            queryAdapter.Fill(ds, "myList");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "myList";

            myDb.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmKliente_soek frmsoek = new frmKliente_soek(myDb, clientID);
            frmsoek.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string cID = "";
            int index = e.RowIndex;

            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            cID = selectedRow.Cells[0].Value.ToString();
              
            frmKliente_Edit f3 = new frmKliente_Edit(myDb, clientID, Convert.ToInt32(cID)); // DIE 3 MOet die selected een wees wat verander moet word
            f3.Show();


        }
    }
}
