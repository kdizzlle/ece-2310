using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw3_profit_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void profit_Click(object sender, EventArgs e)
        {
            double sale, prof;
            double rat = 0;
            string str_sales = sales.Text;
            bool valid = double.TryParse(str_sales, out sale);
            if(!valid)
            {
                MessageBox.Show("Invalid input. Please re-enter.");
                str_sales = sales.Text;
                valid = double.TryParse(str_sales, out sale);
            }
            else
            {
                money.Text = "$" + str_sales;
                if (sale >= 0 && sale <= 1000)
                    rat = 0.03;
                else if (sale >= 1000.01 && sale <= 5000)
                    rat = 0.035;
                else if (sale >= 5000.01 && sale <= 10000)
                    rat = 0.04;
                else if (sale >= 10000.01)
                    rat = 0.045;
                string str_ratio = (rat * 100).ToString();
                ratio.Text = str_ratio + "%";
                prof = Math.Round((sale * rat),2);
                profits.Text = "$" + prof.ToString();
            }
            
        }
    }
}
