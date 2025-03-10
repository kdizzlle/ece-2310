using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace warm_up_3_5_25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();
            int N1 = 0, N2 = 0;
            bool valid1 = int.TryParse(rows.Text, out N1);
            bool valid2 = int.TryParse(cols.Text, out N2);
            if (!valid1 || N1 <= 0 || !valid2 || N2 <= 0)//invalid
                MessageBox.Show("One or both inputs are invalid. Please re-enter.");
            else
            {
                int[,] x = new int[N1,N2];
                Random xobj = new Random();
                string rows;
                for(int i=0; i<N1; i++)//row
                {
                    rows = "";
                    for(int j=0; j<N2; j++)//column
                    {
                        x[i,j] = xobj.Next(1, 11);
                        rows += x[i, j].ToString()+" ";
                    }
                    lstOutput.Items.Add(rows);
                }
            }
        }
    }
}
