using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw3_area_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void circle_Click(object sender, EventArgs e)
        {
            //show radius input box
            radius.Visible = true;
            radius_label.Visible = true;
            //hide length input box
            length.Visible = false;
            length_label.Visible = false;
            //hide width input box
            width.Visible = false;
            width_label.Visible = false;
            //show calculate button
            calculate.Visible = true;
            //show radius input box
            area.Visible = true;
            area_label.Visible = true;

            double r, a;
            string str_r = radius.Text; //get radius input from user
            bool valid = double.TryParse(str_r, out r);
            if(valid)
            r = Convert.ToDouble(str_r);
            a = 3.14 * r * r;
            a = Math.Round(a, 3);
            area.Text = a.ToString();
        }
    }
}
