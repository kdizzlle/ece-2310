using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W3_practice_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2, sum;
            string str_num1 = txtNUM1.Text;
            string str_num2 = txtNUM2.Text;
            num1 = Convert.ToDouble(str_num1);
            num2 = Convert.ToDouble(str_num2);
            sum = num1 + num2;
            txtRESULT.Text = sum.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNUM2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNUM1_TextChanged(object sender, EventArgs e)
        {

        }

        private void subtract_but_Click(object sender, EventArgs e)
        {
            double num1, num2, result;
            string str_num1 = txtNUM1.Text;
            string str_num2 = txtNUM2.Text;
            num1 = Convert.ToDouble(str_num1);
            num2 = Convert.ToDouble(str_num2);
            result = num1 - num2;
            txtRESULT.Text = result.ToString();
        }

        private void mult_but_Click(object sender, EventArgs e)
        {
            double num1, num2, result;
            string str_num1 = txtNUM1.Text;
            string str_num2 = txtNUM2.Text;
            num1 = Convert.ToDouble(str_num1);
            num2 = Convert.ToDouble(str_num2);
            result = num1 * num2;
            txtRESULT.Text = result.ToString();
        }

        private void divide_but_Click(object sender, EventArgs e)
        {
            double num1, num2, result;
            string str_num1 = txtNUM1.Text;
            string str_num2 = txtNUM2.Text;
            num1 = Convert.ToDouble(str_num1);
            num2 = Convert.ToDouble(str_num2);
            result = num1 / num2;
            txtRESULT.Text = result.ToString();
        }

        private void modulo_but_Click(object sender, EventArgs e)
        {
            double num1, num2, result;
            string str_num1 = txtNUM1.Text;
            string str_num2 = txtNUM2.Text;
            num1 = Convert.ToDouble(str_num1);
            num2 = Convert.ToDouble(str_num2);
            result = num1 % num2;
            txtRESULT.Text = result.ToString();
        }
    }
}
