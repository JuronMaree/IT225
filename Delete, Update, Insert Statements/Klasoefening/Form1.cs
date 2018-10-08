using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace Klasoefening
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        private string conn = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source= ";
        private string DBFile;
        public OleDbConnection myDB;
        public int InsNr, DelNr;
        public string title, genre;

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DBFile = openFileDialog1.FileName;
            }
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myDB = new OleDbConnection(conn + DBFile);
            myDB.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM DVD", myDB);
            DataSet ds = new DataSet();

            adapter.Fill(ds, "List");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "List";
            myDB.Close();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteForm frmDelete = new DeleteForm(this);
            frmDelete.Show();
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertForm frmInsert = new InsertForm(this);
            frmInsert.Show();
        }

        private void countToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable myTable = new DataTable();
            int recordcount;
            OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM DVD" , myDB);
            recordcount = adapter.Fill(myTable);
            MessageBox.Show(Convert.ToString(recordcount) + " records");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Delete()
        {
            myDB.Open();
            OleDbDataAdapter adapt = new OleDbDataAdapter(@"SELECT * From DVD",myDB);
            OleDbCommand del = new OleDbCommand(@"Delete from DVD WHERE DVDnr = " + DelNr + "", myDB);

            adapt.DeleteCommand = del;
            adapt.DeleteCommand.ExecuteNonQuery();

            DataSet ds = new DataSet();
            adapt.Fill(ds, "List");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "List";
            myDB.Close();
        }

        public void Insert()
        {

            myDB.Open();
            OleDbDataAdapter adapt = new OleDbDataAdapter(@"SELECT * From DVD", myDB);
            OleDbCommand insert = new OleDbCommand(@"Insert into DVD(DVDnr , Title, Genre) Values ( "+ InsNr + " , " + title + " , " + genre + "')");

            adapt.InsertCommand = insert;
            adapt.InsertCommand.ExecuteNonQuery();

            DataSet ds = new DataSet();
            adapt.Fill(ds, "List");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "List";
            myDB.Close();
        }

        public void Search()
        {
            myDB.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM DVD WHERE Titel = '" + title + "'", myDB);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "DVD");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Student ";
            myDB.Close();

        }
    }
}
