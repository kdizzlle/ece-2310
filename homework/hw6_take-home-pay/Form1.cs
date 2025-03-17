using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw6_take_home_pay
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            string emp_name = name.Text;
            string weekly_sales = total_sales.Text;
            double weekly, total_pay, tax, retire, social;
            //weekly = Convert.ToDouble(weekly_sales);
            bool valid = double.TryParse(weekly_sales, out weekly);
            if (valid)
            {
                if (weekly < 0)//if negative
                {
                    MessageBox.Show("Total weekly sales must be a positive dollar amount.\nPlease re-enter.");
                    total_sales.Clear();
                }
                else
                {
                    total_pay = weekly * 0.07;
                    
                    tax = total_pay * 0.18;
                    federal_tax.Text = tax.ToString();

                    retire = total_pay * 0.15;
                    retirement.Text = retire.ToString();

                    social = total_pay * 0.09;
                    social_security.Text = social.ToString();

                    total_pay = total_pay - tax - retire - social;
                    net_pay.Text = total_pay.ToString();
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
