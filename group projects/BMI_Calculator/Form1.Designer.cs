
namespace BMI_Calculator
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
            this.Standard = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.w_lb_txt = new System.Windows.Forms.TextBox();
            this.h_in_txt = new System.Windows.Forms.TextBox();
            this.h_ft_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BMI_USA = new System.Windows.Forms.Button();
            this.BMI_USA_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BMI_USA_cat_txt = new System.Windows.Forms.TextBox();
            this.BMI_metric_cat_txt = new System.Windows.Forms.TextBox();
            this.BMI_metric_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BMI_metric = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.w_kg_txt = new System.Windows.Forms.TextBox();
            this.h_cm_txt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Standard.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Standard
            // 
            this.Standard.Controls.Add(this.tabPage1);
            this.Standard.Controls.Add(this.tabPage2);
            this.Standard.Location = new System.Drawing.Point(0, 0);
            this.Standard.Name = "Standard";
            this.Standard.SelectedIndex = 0;
            this.Standard.Size = new System.Drawing.Size(403, 407);
            this.Standard.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Honeydew;
            this.tabPage1.Controls.Add(this.BMI_USA_cat_txt);
            this.tabPage1.Controls.Add(this.BMI_USA_txt);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.BMI_USA);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.w_lb_txt);
            this.tabPage1.Controls.Add(this.h_in_txt);
            this.tabPage1.Controls.Add(this.h_ft_txt);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(395, 381);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Standard";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(102, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 39);
            this.label6.TabIndex = 9;
            this.label6.Text = "BMI Calculator";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // w_lb_txt
            // 
            this.w_lb_txt.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.w_lb_txt.Location = new System.Drawing.Point(97, 148);
            this.w_lb_txt.Name = "w_lb_txt";
            this.w_lb_txt.Size = new System.Drawing.Size(64, 27);
            this.w_lb_txt.TabIndex = 8;
            // 
            // h_in_txt
            // 
            this.h_in_txt.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h_in_txt.Location = new System.Drawing.Point(235, 113);
            this.h_in_txt.Name = "h_in_txt";
            this.h_in_txt.Size = new System.Drawing.Size(64, 27);
            this.h_in_txt.TabIndex = 8;
            // 
            // h_ft_txt
            // 
            this.h_ft_txt.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h_ft_txt.Location = new System.Drawing.Point(97, 113);
            this.h_ft_txt.Name = "h_ft_txt";
            this.h_ft_txt.Size = new System.Drawing.Size(64, 27);
            this.h_ft_txt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(167, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "pounds";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(305, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "inches";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(167, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "feet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Weight:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Height:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BMI_metric_cat_txt);
            this.tabPage2.Controls.Add(this.BMI_metric_txt);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.BMI_metric);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.w_kg_txt);
            this.tabPage2.Controls.Add(this.h_cm_txt);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(395, 381);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Metric";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BMI_USA
            // 
            this.BMI_USA.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMI_USA.Location = new System.Drawing.Point(109, 210);
            this.BMI_USA.Name = "BMI_USA";
            this.BMI_USA.Size = new System.Drawing.Size(143, 36);
            this.BMI_USA.TabIndex = 10;
            this.BMI_USA.Text = "Calculate BMI";
            this.BMI_USA.UseVisualStyleBackColor = true;
            this.BMI_USA.Click += new System.EventHandler(this.BMI_USA_Click);
            // 
            // BMI_USA_txt
            // 
            this.BMI_USA_txt.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMI_USA_txt.Location = new System.Drawing.Point(105, 289);
            this.BMI_USA_txt.Name = "BMI_USA_txt";
            this.BMI_USA_txt.ReadOnly = true;
            this.BMI_USA_txt.Size = new System.Drawing.Size(64, 27);
            this.BMI_USA_txt.TabIndex = 12;
            this.BMI_USA_txt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(53, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "BMI:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // BMI_USA_cat_txt
            // 
            this.BMI_USA_cat_txt.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMI_USA_cat_txt.Location = new System.Drawing.Point(190, 289);
            this.BMI_USA_cat_txt.Name = "BMI_USA_cat_txt";
            this.BMI_USA_cat_txt.ReadOnly = true;
            this.BMI_USA_cat_txt.Size = new System.Drawing.Size(119, 27);
            this.BMI_USA_cat_txt.TabIndex = 13;
            // 
            // BMI_metric_cat_txt
            // 
            this.BMI_metric_cat_txt.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMI_metric_cat_txt.Location = new System.Drawing.Point(188, 306);
            this.BMI_metric_cat_txt.Name = "BMI_metric_cat_txt";
            this.BMI_metric_cat_txt.ReadOnly = true;
            this.BMI_metric_cat_txt.Size = new System.Drawing.Size(119, 27);
            this.BMI_metric_cat_txt.TabIndex = 26;
            // 
            // BMI_metric_txt
            // 
            this.BMI_metric_txt.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMI_metric_txt.Location = new System.Drawing.Point(103, 306);
            this.BMI_metric_txt.Name = "BMI_metric_txt";
            this.BMI_metric_txt.ReadOnly = true;
            this.BMI_metric_txt.Size = new System.Drawing.Size(64, 27);
            this.BMI_metric_txt.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(51, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 23);
            this.label8.TabIndex = 24;
            this.label8.Text = "BMI:";
            // 
            // BMI_metric
            // 
            this.BMI_metric.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMI_metric.Location = new System.Drawing.Point(107, 227);
            this.BMI_metric.Name = "BMI_metric";
            this.BMI_metric.Size = new System.Drawing.Size(143, 36);
            this.BMI_metric.TabIndex = 23;
            this.BMI_metric.Text = "Calculate BMI";
            this.BMI_metric.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(100, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 39);
            this.label9.TabIndex = 22;
            this.label9.Text = "BMI Calculator";
            // 
            // w_kg_txt
            // 
            this.w_kg_txt.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.w_kg_txt.Location = new System.Drawing.Point(95, 165);
            this.w_kg_txt.Name = "w_kg_txt";
            this.w_kg_txt.Size = new System.Drawing.Size(64, 27);
            this.w_kg_txt.TabIndex = 20;
            // 
            // h_cm_txt
            // 
            this.h_cm_txt.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h_cm_txt.Location = new System.Drawing.Point(95, 130);
            this.h_cm_txt.Name = "h_cm_txt";
            this.h_cm_txt.Size = new System.Drawing.Size(64, 27);
            this.h_cm_txt.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(165, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 23);
            this.label10.TabIndex = 18;
            this.label10.Text = "kg";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(165, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 23);
            this.label12.TabIndex = 16;
            this.label12.Text = "cm";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(25, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 23);
            this.label13.TabIndex = 15;
            this.label13.Text = "Weight:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(25, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 23);
            this.label14.TabIndex = 14;
            this.label14.Text = "Height:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Standard);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Standard.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Standard;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox w_lb_txt;
        private System.Windows.Forms.TextBox h_in_txt;
        private System.Windows.Forms.TextBox h_ft_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BMI_USA_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BMI_USA;
        private System.Windows.Forms.TextBox BMI_USA_cat_txt;
        private System.Windows.Forms.TextBox BMI_metric_cat_txt;
        private System.Windows.Forms.TextBox BMI_metric_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BMI_metric;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox w_kg_txt;
        private System.Windows.Forms.TextBox h_cm_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

