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
    public partial class frmKliente_soek : Form
    {
        public OleDbConnection myDb;
        public string clientID;

        public frmKliente_soek()
        {
            InitializeComponent();
        }
        public frmKliente_soek(OleDbConnection myDb1, string iDs)
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

            if(txtName.Text!=null)
            {
                try
                {
                    myDb.Open();

                    dataGridView1.Show();


                    OleDbDataAdapter queryAdapter = new OleDbDataAdapter(@"SELECT * FROM Klient WHERE KlientNaam='" + txtName.Text + "'", myDb);

                    DataSet ds = new DataSet();

                    queryAdapter.Fill(ds, "mylist");

                    dataGridView1.DataSource = ds;

                    dataGridView1.DataMember = "mylist";



                    myDb.Close();

                    MessageBox.Show("DB Opened");

                    frmKliente frmBack = new frmKliente(myDb, clientID);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }

            if (txtSurname.Text != null)
            {
                try
                {
                    myDb.Open();

                    dataGridView1.Show();


                    OleDbDataAdapter queryAdapter = new OleDbDataAdapter(@"SELECT * FROM Klient WHERE KlientVan='"
                        + txtSurname.Text + "'", myDb);

                    DataSet ds = new DataSet();

                    queryAdapter.Fill(ds, "mylist");

                    dataGridView1.DataSource = ds;

                    dataGridView1.DataMember = "mylist";



                    myDb.Close();

                    MessageBox.Show("DB Opened");

                    frmKliente frmBack = new frmKliente(myDb, clientID);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }

            if (txtTelefoon.Text != null)
            {
                try
                {
                    myDb.Open();

                    dataGridView1.Show();


                    OleDbDataAdapter queryAdapter = new OleDbDataAdapter(@"SELECT * FROM Klient WHERE KlientTelefoon='" + txtTelefoon.Text + "'", myDb);

                    DataSet ds = new DataSet();

                    queryAdapter.Fill(ds, "mylist");

                    dataGridView1.DataSource = ds;

                    dataGridView1.DataMember = "mylist";



                    myDb.Close();

                    MessageBox.Show("DB Opened");

                    frmKliente frmBack = new frmKliente(myDb, clientID);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }

            if (cbStatus.Text != null)
            {
                try
                {
                    myDb.Open();

                    dataGridView1.Show();


                    OleDbDataAdapter queryAdapter = new OleDbDataAdapter(@"SELECT * FROM Klient WHERE KlientStatus='" + cbStatus.Text + "'", myDb);

                    DataSet ds = new DataSet();

                    queryAdapter.Fill(ds, "mylist");

                    dataGridView1.DataSource = ds;

                    dataGridView1.DataMember = "mylist";



                    myDb.Close();

                    MessageBox.Show("DB Opened");

                    frmKliente frmBack = new frmKliente(myDb, clientID);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }

            if (checkBox1.Checked == true)
            {
                try
                {
                    myDb.Open();

                    dataGridView1.Show();


                    OleDbDataAdapter queryAdapter = new OleDbDataAdapter(@"SELECT * FROM Klient WHERE KlientKredietwaardig=" + checkBox1.Checked + "'", myDb);

                    DataSet ds = new DataSet();

                    queryAdapter.Fill(ds, "mylist");

                    dataGridView1.DataSource = ds;

                    dataGridView1.DataMember = "mylist";



                    myDb.Close();

                    MessageBox.Show("DB Opened");

                    frmKliente frmBack = new frmKliente(myDb, clientID);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }


        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
