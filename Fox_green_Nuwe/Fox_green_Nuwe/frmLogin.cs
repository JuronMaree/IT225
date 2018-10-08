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
    public partial class frmLogin : Form
    {
        public OleDbConnection myDB;
        string db;
        public string username;
        public bool aDMIN;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                myDB = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
                Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "FoxgreenDatabase.accdb");
                myDB.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    db = openFileDialog1.FileName;
                }
                myDB = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + db);
                myDB.Open();
            //    myDB.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*Menu_Form frmmenu = new Menu_Form();
            frmmenu.Show();
            this.Hide();*/
            MessageBox.Show("aweawe");
            if (edtUsername.Text == "" || edtPassword.Text == "")
            {
                MessageBox.Show("Invalid Credentials, Please Re-Enter");
                edtPassword.Text = "";
            }

            OleDbCommand cmd = new OleDbCommand("select * from Agent where AgentUsername='" + edtUsername.Text + "' and AgentWagwoord='" + edtPassword.Text + "' and AgentAdmin=true", myDB);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {


                username = edtUsername.Text;
                //check admin
                // OleDbCommand cmd1 = new OleDbCommand("select * from Login where Username='" + txtUsername.Text + "' and Password='" + txtPassword.Text + "' and Admin=true'", myDB);
                // OleDbDataReader dr1 = cmd.ExecuteReader();
                //  if (dr1.Read() == true)
                //   {               
                string iD = dr["AgentID"].ToString();
                MessageBox.Show("Login Successful Admin");
                aDMIN = true;
                frmMenu main1 = new frmMenu(aDMIN, myDB, iD);
                main1.Show();
                this.Hide();


                myDB.Close();
            }
            else
            {
                dr.Close();
                OleDbCommand cmd1 = new OleDbCommand("select * from Agent where AgentUsername='" + edtUsername.Text + "' and Password='" + edtPassword.Text + "' and AgentAdmin=false", myDB);
                OleDbDataReader dr1 = cmd1.ExecuteReader();
                if (dr1.Read() == true)
                {
                    MessageBox.Show("Login Successful ");
                    aDMIN = false;
                    string iD = dr1["ID"].ToString();
                    frmMenu main1 = new frmMenu(aDMIN, myDB, iD);
                    main1.Show();
                    this.Hide();
                    myDB.Close();
                }

                else
                {
                    MessageBox.Show("Invalid Credentials, Please Re-Enter");
                    edtPassword.Text = "";
                }
            }
        }
    }
}
