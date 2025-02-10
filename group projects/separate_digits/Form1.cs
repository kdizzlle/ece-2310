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
            int num = Convert.ToInt16(str_number);
            int[] digit = new int[5]; //array for digits
            for(int i = 0; i < 5; i++)
            {
                //take the modulo of the number to get the least significant digit 
                Digit[i] = number % 10;
                // subtract the least sig. Digit from the number to get the remaining 4 digits 
                Number = number – digit[i];
                // divide by 10 to remove the 0 at the end from subtraction 
                Number = number / 10;
            }

{

                

                // the process repeats, storing each digit in the array until all 5 digits are stored 

            }
        }
    }
}
