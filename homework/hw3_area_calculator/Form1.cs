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
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            //circle
            double r, l, w, a;
            if(radius.Visible && !length.Visible && !width.Visible)
            {
                string str_r = radius.Text; //get radius input from user
                bool r_valid = double.TryParse(str_r, out r);
                if (!(r_valid && r >= 0)) //invalid input string / r is 0 or negative
                {
                    MessageBox.Show("Invalid input. Please re-enter.");
                    str_r = radius.Text;
                    r_valid = double.TryParse(str_r, out r);
                }
                else if (r_valid)
                {
                    r = Convert.ToDouble(str_r);
                    a = 3.14 * r * r;
                    a = Math.Round(a, 3);
                    area.Text = a.ToString();
                }
            }
            //rectangle
            else if (!radius.Visible && length.Visible && width.Visible)
            {
                string str_l = length.Text; //get input from user
                string str_w = width.Text;
                bool l_valid = double.TryParse(str_l, out l);
                bool w_valid = double.TryParse(str_w, out w);
                if (!(l_valid && l >= 0)) //invalid input string / 0 or negative
                {
                    MessageBox.Show("Invalid length input. Please re-enter.");
                    str_l = length.Text;
                    l_valid = double.TryParse(str_l, out l);
                }
                if (!(w_valid && w >= 0)) //invalid input string / 0 or negative
                {
                    MessageBox.Show("Invalid width input. Please re-enter.");
                    str_w = length.Text;
                    w_valid = double.TryParse(str_w, out w);
                }
                else if (l_valid && w_valid)
                {
                    l = Convert.ToDouble(str_l);
                    w = Convert.ToDouble(str_w);
                    a = l * w;
                    a = Math.Round(a, 3);
                    area.Text = a.ToString();
                }
            }
            //cylinder
            else if (radius.Visible && length.Visible && !width.Visible)
            {
                string str_l = length.Text; //get input from user
                string str_r = radius.Text;
                bool l_valid = double.TryParse(str_l, out l);
                bool r_valid = double.TryParse(str_r, out r);
                if (!(l_valid && l >= 0)) //invalid input string / 0 or negative
                {
                    MessageBox.Show("Invalid length input. Please re-enter.");
                    str_l = length.Text;
                    l_valid = double.TryParse(str_l, out l);
                }
                if (!(r_valid && r >= 0)) //invalid input string / 0 or negative
                {
                    MessageBox.Show("Invalid radius input. Please re-enter.");
                    str_r = length.Text;
                    r_valid = double.TryParse(str_r, out r);
                }
                else if (l_valid && r_valid)
                {
                    l = Convert.ToDouble(str_l);
                    r = Convert.ToDouble(str_r);
                    a = (2*3.14*l)+(2*3.14*r*r);
                    a = Math.Round(a, 3);
                    area.Text = a.ToString();
                }
            }

        }

        private void rectangle_Click(object sender, EventArgs e)
        {
            //hide radius input box
            radius.Visible = false;
            radius_label.Visible = false;
            //show length input box
            length.Visible = true;
            length_label.Visible = true;
            //show width input box
            width.Visible = true;
            width_label.Visible = true;
            //show calculate button
            calculate.Visible = true;
            //show radius input box
            area.Visible = true;
            area_label.Visible = true;
        }

        private void cylinder_Click(object sender, EventArgs e)
        {
            //show radius input box
            radius.Visible = true;
            radius_label.Visible = true;
            //show length input box
            length.Visible = true;
            length_label.Visible = true;
            //hide width input box
            width.Visible = false;
            width_label.Visible = false;
            //show calculate button
            calculate.Visible = true;
            //show radius input box
            area.Visible = true;
            area_label.Visible = true;
        }
    }
}
