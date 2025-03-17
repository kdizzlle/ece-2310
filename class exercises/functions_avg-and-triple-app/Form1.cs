using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace functions_avg_and_triple_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            int[] test = new int[10];
            test = ran(1, 10, 10);
            for (int i = 0; i < 10; i++)
                listBox1.Items.Add(test[i].ToString());
            //MessageBox.Show("The average is: " + Ave(test).ToString());
            listBox1.Items.Add("The average is: " + Ave(test).ToString());
            int Idx = Array.IndexOf(test, 10);
            if(Idx==-1)
            {
                for (int i = 0; i < 10; i++)
                    listBox1.Items.Add("None of the elements is 10.");
            }
            else
                listBox1.Items.Add("10 is the element of " + Idx.ToString());
            //triple everything in box 1 and display them in box 2
            int[] test3 = new int[10];
            test3 = Triple(test);
            for (int i = 0; i < 10; i++)
                listBox2.Items.Add(test3[i].ToString());
        }

        //user-defined functions
        int[] ran(int a, int b, int N)
        {
            Random rj = new Random();
            int[] x = new int[N];
            for (int i = 0; i < N; i++)
                x[i] = rj.Next(a, b + 1);
            return x;
        }
        int[] Triple(int[] x)
        {
            int N = x.Length;
            int[] y = new int[N];
            for (int i = 0; i < N; i++)
                y[i] = 3 * x[i];
            return y;
        }
        int Ave(int[] x)
        {
            int ave = 0;
            for (int i=0; i < x.Length; i++)
                ave += x[i];
            ave /= x.Length;
            return ave;
        }
    }
}
