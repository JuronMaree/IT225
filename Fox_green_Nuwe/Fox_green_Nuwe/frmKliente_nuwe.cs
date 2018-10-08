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
    public partial class frmKliente_nuwe : Form
    {

        public OleDbConnection myDb;
        public string clientID;

        public frmKliente_nuwe()
        {
            InitializeComponent();
        }
        public frmKliente_nuwe(OleDbConnection myDb1, string iDs)
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

                
                OleDbCommand command = new OleDbCommand();
                command.Connection = myDb;
                command.CommandText = "INSERT INTO Klient(AgenteID,KlientNaam,KlientVan,KlientTelefoonNommer,KlientKredietwaardig,KlientStatus) values(" + clientID + ",'" + txtName.Text + "'," +
                 "'" + txtSurname.Text + "','" + txtTelefoon.Text + "'," + checkBox1.Checked + ",'" + Convert.ToString(cbStatus.Text) + "');";

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data saved");
                     myDb.Close();
                    //MessageBox.Show("DB Opened");
                    this.Close();
                    frmAdmin frmBack = new frmAdmin(myDb, clientID);

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Nie alle waardes is in gevul nie.");
                }

               

               
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}
