﻿
namespace hw1_grade_calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.homework = new System.Windows.Forms.TextBox();
            this.projects = new System.Windows.Forms.TextBox();
            this.quizzes = new System.Windows.Forms.TextBox();
            this.exams = new System.Windows.Forms.TextBox();
            this.final_exam = new System.Windows.Forms.TextBox();
            this.total_grade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // homework
            // 
            this.homework.Location = new System.Drawing.Point(217, 72);
            this.homework.Name = "homework";
            this.homework.Size = new System.Drawing.Size(64, 20);
            this.homework.TabIndex = 0;
            // 
            // projects
            // 
            this.projects.Location = new System.Drawing.Point(217, 140);
            this.projects.Name = "projects";
            this.projects.Size = new System.Drawing.Size(64, 20);
            this.projects.TabIndex = 1;
            // 
            // quizzes
            // 
            this.quizzes.Location = new System.Drawing.Point(449, 72);
            this.quizzes.Name = "quizzes";
            this.quizzes.Size = new System.Drawing.Size(64, 20);
            this.quizzes.TabIndex = 2;
            // 
            // exams
            // 
            this.exams.Location = new System.Drawing.Point(449, 140);
            this.exams.Name = "exams";
            this.exams.Size = new System.Drawing.Size(64, 20);
            this.exams.TabIndex = 3;
            // 
            // final_exam
            // 
            this.final_exam.Location = new System.Drawing.Point(336, 215);
            this.final_exam.Name = "final_exam";
            this.final_exam.Size = new System.Drawing.Size(64, 20);
            this.final_exam.TabIndex = 4;
            // 
            // total_grade
            // 
            this.total_grade.Location = new System.Drawing.Point(336, 376);
            this.total_grade.Name = "total_grade";
            this.total_grade.Size = new System.Drawing.Size(64, 20);
            this.total_grade.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Homework (10%)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quizzes (20%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Projects (25%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Exams (20%)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Final Exam (25%)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total Grade";
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(242, 283);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(200, 49);
            this.calculate.TabIndex = 12;
            this.calculate.Text = "Calculate Grade";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 446);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.total_grade);
            this.Controls.Add(this.final_exam);
            this.Controls.Add(this.exams);
            this.Controls.Add(this.quizzes);
            this.Controls.Add(this.projects);
            this.Controls.Add(this.homework);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox homework;
        private System.Windows.Forms.TextBox projects;
        private System.Windows.Forms.TextBox quizzes;
        private System.Windows.Forms.TextBox exams;
        private System.Windows.Forms.TextBox final_exam;
        private System.Windows.Forms.TextBox total_grade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button calculate;
    }
}

