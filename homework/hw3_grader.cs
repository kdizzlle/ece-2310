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
                    if (score >= 0)
                    {
                        switch ((score/10)-((score%10)/10))
                        {
                            case 10:
                                {
                                    txtPass.BackColor = Color.MediumSpringGreen;
                                    MessageBox.Show("Your grade is A");                                    
                                }
                                    break;
                            case 9:
                                {
                                    txtPass.BackColor = Color.MediumSpringGreen;
                                    MessageBox.Show("Your grade is A");                                    
                                }
                                    break;
                            case 8:
                                {
                                    txtPass.BackColor = Color.MediumSpringGreen;
                                    MessageBox.Show("Your grade is B");                                    
                                }
                                    break;
                            case 7:
                                {
                                    txtPass.BackColor = Color.MediumSpringGreen;
                                    MessageBox.Show("Your grade is C");
                                }
                                    break;
                            case 6:
                                {
                                    txtFail.BackColor = Color.Red;
                                    MessageBox.Show("Your grade is D");                                    
                                }
                                    break;
                            case 5:
                                {
                                    txtFail.BackColor = Color.Red;
                                    MessageBox.Show("Your grade is F");                                    
                                }
                                    break;
                            case 4:
                                {
                                    txtFail.BackColor = Color.Red;
                                    MessageBox.Show("Your grade is F");
                                }
                                break;
                            case 3:
                                {
                                    txtFail.BackColor = Color.Red;
                                    MessageBox.Show("Your grade is F");
                                }
                                break;
                            case 2:
                                {
                                    txtFail.BackColor = Color.Red;
                                    MessageBox.Show("Your grade is F");
                                }
                                break;
                            case 1:
                                {
                                    txtFail.BackColor = Color.Red;
                                    MessageBox.Show("Your grade is F");
                                }
                                break;
                            case 0:
                                {
                                    txtFail.BackColor = Color.Red;
                                    MessageBox.Show("Your grade is F");
                                }
                                break;
                            default:
                                MessageBox.Show("Your grade is ?");
                                break;
                        }
                    }
                }
            }
            else if (!valid)
                MessageBox.Show("Invalid input");
        }
    }
}
