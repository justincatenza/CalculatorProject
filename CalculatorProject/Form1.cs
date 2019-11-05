using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorProject
{
    public partial class Form1 : Form
    {
        public double currentAmount { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            currentAmount = Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text);
            textBox3.Text = currentAmount.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            currentAmount = Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text);
            textBox3.Text = currentAmount.ToString();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            currentAmount = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text);
            textBox3.Text = currentAmount.ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            currentAmount = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text);
            textBox3.Text = currentAmount.ToString();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            string toBinary(int n)
            {
                if (n < 2) { return n.ToString(); }
                var divisor = n / 2;
                var remainder = n % 2;

                return toBinary(divisor) + remainder;
            }

            int number1 = Convert.ToInt32(textBox3.Text);

            if (checkBox1.Checked)
            {
                
                textBox3.Text = toBinary(Convert.ToInt32(textBox3.Text));
                textBox2.Text = toBinary(Convert.ToInt32(textBox2.Text));
                textBox1.Text = toBinary(Convert.ToInt32(textBox1.Text));
            }
            else
            {
                textBox3.Text = Convert.ToInt32(textBox3.Text, 2).ToString();
                textBox2.Text = Convert.ToInt32(textBox2.Text, 2).ToString();
                textBox1.Text = Convert.ToInt32(textBox1.Text, 2).ToString();
            }
            
        }



        
    }
}