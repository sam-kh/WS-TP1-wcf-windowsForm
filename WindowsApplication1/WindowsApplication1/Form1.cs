using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        ServiceReferenceCalcul.ServiceClient cal = new ServiceReferenceCalcul.ServiceClient();
        public Form1()
        {
            InitializeComponent();
        }
        //addition
        private void button1_Click(object sender, EventArgs e)
        {
           textBox3.Text = Convert.ToString(cal.WebAdd(int.Parse(textBox1.Text),int.Parse(textBox2.Text)));
        }
        //soustraction
        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(cal.WebSoustraction(int.Parse(textBox1.Text), int.Parse(textBox2.Text)));
        }
        //Multiplication
        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(cal.WebMultiply(int.Parse(textBox1.Text), int.Parse(textBox2.Text)));
        }
        //division
        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(cal.WebDivision(int.Parse(textBox1.Text), int.Parse(textBox2.Text)));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
