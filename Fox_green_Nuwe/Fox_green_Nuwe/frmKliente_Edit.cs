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
    public partial class frmKliente_Edit : Form
    {
        OleDbConnection myDb;
        public string clientID;
        public int editID;

        public frmKliente_Edit()
        {
            InitializeComponent();
        }
        public frmKliente_Edit(OleDbConnection myDb1, string iDs, int idi)
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

                string Query = "";

                try
                {
                    

                    OleDbDataAdapter queryAdapter = new OleDbDataAdapter(@"SELECT * FROM Klient WHERE KlientNaam='" + txtName.Text + "'", myDb);

                    Query = "UPDATE Klient SET KlientVan='" + txtSurname.Text + "', KlientTelefoonNommer='"
                        + txtTelefoon.Text + "',KlientNaam='" + txtName.Text + "',KlientKredietwaardig=" + checkBox1.Checked + ", KlientStatus='"
                        + cbStatus.Text + "' WHERE KlientID=" + editID + "";

                    OleDbCommand cmd = new OleDbCommand(Query, myDb);

                    queryAdapter.InsertCommand = cmd;

                    queryAdapter.InsertCommand.ExecuteNonQuery();
                   
                }

                catch
                { MessageBox.Show("Vul alle waardes in."); }

                myDb.Close();

                MessageBox.Show("DB Opened");
                this.Close();
                frmKliente frmBack = new frmKliente(myDb, clientID);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

        }

        private void frmKliente_Edit_Load(object sender, EventArgs e)
        {
            string queryString = "SELECT * FROM Klient WHERE KlientID=" + editID + "";
            try
            {
                
                    myDb.Open();
                    OleDbCommand command = new OleDbCommand(queryString, myDb);
                    
                    OleDbDataReader reader = command.ExecuteReader();
            
                    while (reader.Read())
                    {

                        string klientNaam = reader.GetValue(2).ToString();
                        string agentId = reader.GetValue(1).ToString();
                        string kV = reader.GetValue(3).ToString();
                        string tel = reader.GetValue(4).ToString();
                        Boolean kk = reader.GetBoolean(5);
                        string stat = reader.GetValue(6).ToString();

                        txtName.Text = klientNaam;
                        txtSurname.Text = kV;
                        txtTelefoon.Text = tel;
                        cbStatus.Text = stat;
                        checkBox1.Checked = kk;

                    }
                    reader.Close();


                myDb.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data is nie gekry nie." + ex.ToString());
            }
        }
    }
}
