using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace separate_digits
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

        private void separate_Click(object sender, EventArgs e)
        {
            string str_number = number.Text;
            int num;
            bool valid = int.TryParse(str_number, out num);//input validation
            if (valid)
            {
                num = Convert.ToInt32(str_number);
                if (!(num > 9999 && num < 100000))
                    MessageBox.Show("Invalid input. Please enter a 5 digit positive whole number.");
                else
                {
                    int[] digit = new int[5]; //array for digits
                    for (int i = 0; i < 5; i++)
                    {
                        //take the modulo of the number to get the least significant digit 
                        digit[i] = num % 10;
                        // subtract the least sig. Digit from the number to get the remaining 4 digits 
                        num -= digit[i];
                        // divide by 10 to remove the 0 at the end from subtraction 
                        num /= 10;
                    }
                    dig1.Text = Convert.ToString(digit[4]);
                    dig2.Text = Convert.ToString(digit[3]);
                    dig3.Text = Convert.ToString(digit[2]);
                    dig4.Text = Convert.ToString(digit[1]);
                    dig5.Text = Convert.ToString(digit[0]);
                }
            }
                
            else if (!valid)
                MessageBox.Show("Invalid input. Please input a positive whole 5-digit number.");
            
        }
    }
}
