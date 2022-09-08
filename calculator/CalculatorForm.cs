using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }
        
      
        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + "1";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = textBox1.Text + "+";
        }



        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "-";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void buttonDIV_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "/";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void buttonMUL_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "*";
        }
        private void buttonequl_Click(object sender, EventArgs e)
        {
            string[] values = textBox1.Text.Split('+');

            if (values.Length > 1)
            {
                textBox1.Text = (Convert.ToInt16(values[0]) + Convert.ToInt16(values[1])).ToString();
            }
            else if (textBox1.Text.Split('-').Length > 1)
            {
                textBox1.Text = (Convert.ToInt16(values[0]) - Convert.ToInt16(values[1])).ToString();

            }
            else if (textBox1.Text.Split('*').Length > 1)
            {
                textBox1.Text = (Convert.ToInt16(values[0]) * Convert.ToInt16(values[1])).ToString();

            }




        }
    }
}


