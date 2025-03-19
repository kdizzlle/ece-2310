using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        //user-defined functions
        bool inputValid(string value, int upper, int lower)
        {
            int val;
            //check if string input is integer
            bool valid = int.TryParse(value, out val);
            //check if integer is within range
            if (val > upper || val < lower || valid == false)
            {
                MessageBox.Show("Invalid input.\nMust an integer between " + lower + " and " + upper + ".\nTry again.");
                return false;
            }
            else if(valid==true)
                return true;
        }
        private void BMI_USA_Click(object sender, EventArgs e)
        {

        }
    }
}
