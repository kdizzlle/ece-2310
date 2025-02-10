using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Week3_WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double F, C;
            //read input from textbox txtF
            string str_F = txtF.Text;
            //convert string to double
            F = Convert.ToDouble(str_F);
            //calculate C
            C = Math.Round((F - 32) * 5 / 9, 0);
            //output to textbox txtC
            txtC.Text = C.ToString();
        }
    }
}
