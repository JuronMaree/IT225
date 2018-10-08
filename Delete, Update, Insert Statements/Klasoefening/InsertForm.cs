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
    public partial class InsertForm : Form
    {
        Form1 frm1;
        public InsertForm(Form1 f1)
        {
            InitializeComponent();
            frm1 = f1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "")
            {
                frm1.InsNr = Convert.ToInt16(textBox1.Text);
                frm1.title = textBox2.Text;
                frm1.genre = textBox3.Text;
                frm1.Insert();
                this.Close();
            }
        }
    }
}
