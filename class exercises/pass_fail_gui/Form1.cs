using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pass_fail_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double score;
            string score_str = scoreTxt.Text;
            txtPass.BackColor = Color.WhiteSmoke;
            txtFail.BackColor = Color.WhiteSmoke;
            //score = Convert.ToDouble(score_str);
            bool valid = double.TryParse(score_str, out score);
            if (valid)
            {
                if (score > 100 || score < 0)
                    MessageBox.Show("Invalid input");
                else
                {
                    if (score > 60 && score >= 0)
                    {
                        txtPass.BackColor = Color.MediumSpringGreen;
                        MessageBox.Show("You passed!");
                        switch (score/10)
                        {
                            case 10:
                                MessageBox.Show("Your grade is A");
                                break;
                            case 9:
                                MessageBox.Show("Your grade is A");
                                break;
                            case 8:
                                MessageBox.Show("Your grade is B");
                                break;
                            case 7:
                                MessageBox.Show("Your grade is C");
                                break;
                            case 6:
                                MessageBox.Show("Your grade is D");
                                break;
                            case 5:
                                MessageBox.Show("Your grade is F");
                                break;
                            case 4:
                                MessageBox.Show("Your grade is F");
                                break;
                            case 3:
                                MessageBox.Show("Your grade is F");
                                break;
                            case 2:
                                MessageBox.Show("Your grade is F");
                                break;
                            case 1:
                                MessageBox.Show("Your grade is F");
                                break;
                            case 0:
                                MessageBox.Show("Your grade is F");
                                break;
                            default:
                                MessageBox.Show("Your grade is A");
                                break;
                        }
                    }

                    else
                    {
                        txtFail.BackColor = Color.Red;
                        MessageBox.Show("You failed.");
                    }
                }
            }
            else if (!valid)
                MessageBox.Show("Invalid input");
        }
    }
}
