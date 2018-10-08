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
    public partial class frmVerkope_nuwe : Form
    {
        OleDbConnection myDb;
        public string clientID;

        public frmVerkope_nuwe()
        {
            InitializeComponent();
        }

        public frmVerkope_nuwe(OleDbConnection myDb1, string iDs)
        {
            InitializeComponent();
            MYDB = myDb1;

            CLIENTID = iDs;


            myDb.Close();
            MessageBox.Show(clientID);
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

        private void frmVerkope_nuwe_Load(object sender, EventArgs e)
        {
            myDb.Open();

            //Area Combobox
            OleDbCommand cmdArea = new OleDbCommand("SELECT AreaBeskrywing,AreaID FROM Area", myDb);
            OleDbDataReader rdArea;
            rdArea = cmdArea.ExecuteReader();

            DataTable area = new DataTable();
            area.Columns.Add("AreaID", typeof(int));
            area.Columns.Add("AreaBeskrywing",typeof(string));
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

            cbKleint.ValueMember = "KlientID";
            cbKleint.DisplayMember = "KlientNaam";
            cbKleint.DataSource = klient;

            myDb.Close();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddToDatabase(cbArea.SelectedIndex, cbAgent.SelectedIndex, cbKleint.SelectedIndex, Convert.ToInt32(numStraat.Value), Convert.ToInt32(numStraat.Value), Convert.ToInt32(numStraat.Value)
                , Convert.ToInt32(numStraat.Value), Convert.ToInt32(numStraat.Value), edtStraatNaam.Text, edtPlan.Text, cbType.SelectedValue.ToString(), edtAddInligting.Text, cxbSwembad.Checked);
        }

        private void AddToDatabase(int area, int agent,int klient,int straatnr,int garage,int badkamers,int vloere,int slaapkamers, string straatnaam,string plan,string type,string addinligting, Boolean swembad)
        {
         /*   try
            {
                myDb.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = myDb;
                command.CommandText = "INSERT INTO Eiendom(AreaId,AgentID,KlientID,AdresId,EiendomAantalBadkamers,EiendomAantalSlaapkamers" +
                    ",EiendomPrys,EiendomSwembad,EiendomGarages,EiendomAantalVloere,EiendomOppervlakte,EiendomTipePlan,EiendomAdisioneleInligting,Verhuur/Verkoop) " +
                    "VALUES (@AreaID,@AgentID,@KlientID)";

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
            }*/
        }
    }
}
