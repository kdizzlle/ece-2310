using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw1_grade_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            double hw, quiz, proj, exam, final, grade;
            string str_hw = homework.Text;
            string str_quiz = quizzes.Text;
            string str_proj = projects.Text;
            string str_exam = exams.Text;
            string str_final = final_exam.Text;
            hw = Convert.ToDouble(str_hw);
            quiz = Convert.ToDouble(str_quiz);
            proj = Convert.ToDouble(str_proj);
            exam = Convert.ToDouble(str_exam);
            final = Convert.ToDouble(str_final);

            grade = (hw * .1) + (quiz * .2) + (proj * .25) + (exam * .2) + (final * .25);
            total_grade.Text = grade.ToString();
        }
    }
}
