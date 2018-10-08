using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getValue(out int width,out int length) //Get method 
        {
            width = int.Parse(textBox1.Text);
            length = int.Parse(textBox2.Text);
        }

        private int berekenOmtrek(int wyd, int breed) //bereken omtrek method
        {
            return 2 * wyd + 2 * breed ;
        } 

        private int berekenArea(int wyd, int breed)
        {
            return wyd * breed;
        }

        private void DisplayAnswer(int om, int opp)
        {
            label1.Text = Convert.ToString(om);
            label2.Text = Convert.ToString(opp);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int w, l, om, area;//variables
            getValue(out w, out l); //Call get method
            om = berekenOmtrek(w,l); //bereken omtrek method geroep
            area = berekenArea(w, l);//Bereken area mether geroep
            DisplayAnswer(om, area); 
        }
    }
}
