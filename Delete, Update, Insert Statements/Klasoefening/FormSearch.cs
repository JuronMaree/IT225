using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klasoefening
{
    public partial class FormSearch : Form
    {
        Form1 frm1;
        public FormSearch(Form1 f1)
        {
            frm1 = f1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm1.title = textBox1.Text;
            frm1.Search();
            this.Close();
        }
    }
}
