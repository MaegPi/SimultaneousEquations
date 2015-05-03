using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace quadratic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            double x1 = Double.Parse(textBox1.Text);
            double y1 = Double.Parse(textBox2.Text);
            double val1 = Double.Parse(textBox5.Text);
            double x2 = Double.Parse(textBox4.Text);
            double y2 = Double.Parse(textBox3.Text);
            double val2 = Double.Parse(textBox6.Text);
            double y0 = y1/y2;
            double val0 = val1 - (y0 * val2);
            double x0 = x1 - (y0 * x2);
            double x = val0 / x0;
            double y = (val1 - (x * x1))/y1;
            String answer = "x is " + x.ToString() + " and y is " + y.ToString();

            label9.Text =  answer;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
