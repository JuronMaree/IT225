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
  
    public partial class frmVerkope_Edit : Form
    {
        OleDbConnection myDb;
        public string clientID;
        public int editID;

        public frmVerkope_Edit()
        {
            InitializeComponent();
        }
        public frmVerkope_Edit(OleDbConnection myDb1, string iDs, int idi)
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
                myDb.Close();

                MessageBox.Show("DB Opened");
                this.Close();
                frmVerkope frmBack = new frmVerkope(myDb, clientID);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

        }

        private void frmVerkope_Edit_Load(object sender, EventArgs e)
        {
            myDb.Open();

            //Area Combobox
            OleDbCommand cmdArea = new OleDbCommand("SELECT AreaBeskrywing,AreaID FROM Area", myDb);
            OleDbDataReader rdArea;
            rdArea = cmdArea.ExecuteReader();

            DataTable area = new DataTable();
            area.Columns.Add("AreaID", typeof(int));
            area.Columns.Add("AreaBeskrywing", typeof(string));
            area.Load(rdArea);

            cbArea.ValueMember = "AreaID";
            cbArea.DisplayMember = "AreaBEskrywing";
            cbArea.DataSource = area;

            //Agent ComboBox
            OleDbCommand cmdAgent = new OleDbCommand("SELECT AgentNaam,AgentID FROM Agent", myDb);
            OleDbDataReader rdAgent;
            rdAgent = cmdAgent.ExecuteReader();

            DataTable agent = new DataTable();
            agent.Columns.Add("AgentID", typeof(int));
            agent.Columns.Add("AgentNaam", typeof(string));
            agent.Load(rdAgent);

            cbAgent.ValueMember = "AgentID";
            cbAgent.DisplayMember = "AgentNaam";
            cbAgent.DataSource = agent;

            //Klient Combobox
            OleDbCommand cmdKlient = new OleDbCommand("SELECT KlientNaam FROM Klient", myDb);
            OleDbDataReader rdKlient;
            rdKlient = cmdKlient.ExecuteReader();

            DataTable klient = new DataTable();
            klient.Columns.Add("KlientID", typeof(int));
            klient.Columns.Add("KlientNaam", typeof(string));
            klient.Load(rdKlient);

            cbKlient.ValueMember = "KlientID";
            cbKlient.DisplayMember = "KlientNaam";
            cbKlient.DataSource = klient;

            myDb.Close();

            string queryString = "SELECT * FROM Klient WHERE KlientID=" + editID + "";
            try
            {

                myDb.Open();
                OleDbCommand command = new OleDbCommand(queryString, myDb);

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int agent1 = Convert.ToInt32(reader.GetValue(1));
                    int area1 = Convert.ToInt32(reader.GetValue(2));
                    int klient1 = Convert.ToInt32(reader.GetValue(3));
                    int adres = Convert.ToInt32(reader.GetValue(4));
                    int badkamers = Convert.ToInt32(reader.GetValue(5));
                    int slaapkamers = Convert.ToInt32(reader.GetValue(6));
                    int prys = Convert.ToInt32(reader.GetValue(7));
                    int gerages = Convert.ToInt32(reader.GetValue(8));
                    int vloere = Convert.ToInt32(reader.GetValue(9));
                    int oppervlak = Convert.ToInt32(reader.GetValue(10));
                    Boolean swembad = reader.GetBoolean(11);
                    string plan = reader.GetValue(12).ToString();
                    string inlig = reader.GetValue(13).ToString();
                    string type = reader.GetValue(14).ToString();

                    cbArea.SelectedItem = area1;
                    cbAgent.SelectedItem = agent1;
                    cbKlient.SelectedItem = klient1;
                    numStraat.Value = 50;
                    edtStraatNaam.Text = "Flamingo";
                    edtPrys.Text = Convert.ToString(prys);
                    edtPlan.Text = plan;
                    edtOppervlakte.Text = Convert.ToString(oppervlak);
                    numVloere.Value = vloere;
                    numGerages.Value = gerages;
                    AddInligting.Text = inlig;
                    cxbSwembad.Checked = swembad;
                    numBadkamers.Value = badkamers;
                    numSlaapkamers.Value = slaapkamers;

                }
                reader.Close();


                myDb.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data is nie gekry nie." + ex.ToString());
            }
            this.Hide();
            frmVerkope f2 = new frmVerkope();
            f2.Show();
        }
    }
}
