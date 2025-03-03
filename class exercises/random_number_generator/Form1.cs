using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random_number_generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            int N = 0;
            bool valid = int.TryParse(size.Text, out N);
            if (!valid)
                MessageBox.Show("Invalid entry. Please re-enter an integer.");
            else if (N <= 0)
                MessageBox.Show("Invalid entry. Please re-enter a positive integer.");
            else //input is valid
            {
                int n = 0;
                Random rn = new Random();
                for(int i=1; i<N; i++)
                {
                    n = rn.Next(0, 21);
                    lstOutput.Items.Add(n.ToString());
                }
            }
        }

        private void Average_Click(object sender, EventArgs e)
        {
            int ave = 0;
            int n = 0;
            int N = int.Parse(size.Text);
            for(int i = 1; i<N; i++)
            {
                n = Convert.ToInt32(lstOutput.Items[i-1]);
                ave += n;
            }
            MessageBox.Show("The average of these random numbers is "+(ave/N).ToString());
        }

        private void Maximum_Click(object sender, EventArgs e)
        {
            int max = 0;
            int n = 0;
            int N = int.Parse(size.Text);
            for (int i = 1; i < N; i++)
            {
                n = Convert.ToInt32(lstOutput.Items[i-1]);
                if (n > max)
                    max = n;
            }
            MessageBox.Show("The maximum of these random numbers is "+max.ToString());
        }

        private void Minimum_Click(object sender, EventArgs e)
        {
            int min = 0;
            int n = 0;
            int N = int.Parse(size.Text);
            min = Convert.ToInt32(lstOutput.Items[0]);
            for (int i = 1; i < N; i++)
            {
                n = Convert.ToInt32(lstOutput.Items[i-1]);
                if (n < min)
                    min = n;
            }
            MessageBox.Show("The minimum of these random numbers is "+min.ToString());
        }
    }
}
