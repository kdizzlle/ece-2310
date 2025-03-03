using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw4_factorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Factorial_Click(object sender, EventArgs e)
        {
            string str_n = input.Text;
            int n = Convert.ToInt32(str_n);
            bool valid = int.TryParse(str_n, out n);
            int fact = 0;
            if (!valid)
                MessageBox.Show("Invalid input. Try again.");
            else
            {
                for (int i=0;i<n;i++)
                {
                    if (i > 1)
                    {
                        for(int j=n;j>0;j--)
                        {

                        }
                    }
                    else
                        fact = 1;
                }
            }
        }
    }
}
