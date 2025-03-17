
namespace hw6_take_home_pay
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.total_sales = new System.Windows.Forms.TextBox();
            this.federal_tax = new System.Windows.Forms.TextBox();
            this.retirement = new System.Windows.Forms.TextBox();
            this.social_security = new System.Windows.Forms.TextBox();
            this.net_pay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee\'s total weekly sales:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Employee commission is 7% of total sales.";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(147, 112);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(199, 58);
            this.Calculate.TabIndex = 4;
            this.Calculate.Text = "Calculate Take-Home Pay";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(197, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Deductions:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(197, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total Net Pay:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Federal Tax (18%):";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Retirement Contribution (15%):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Social Security (9%):";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(200, 24);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(129, 20);
            this.name.TabIndex = 10;
            // 
            // total_sales
            // 
            this.total_sales.Location = new System.Drawing.Point(200, 47);
            this.total_sales.Name = "total_sales";
            this.total_sales.Size = new System.Drawing.Size(129, 20);
            this.total_sales.TabIndex = 11;
            // 
            // federal_tax
            // 
            this.federal_tax.Location = new System.Drawing.Point(200, 223);
            this.federal_tax.Name = "federal_tax";
            this.federal_tax.ReadOnly = true;
            this.federal_tax.Size = new System.Drawing.Size(129, 20);
            this.federal_tax.TabIndex = 12;
            this.federal_tax.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // retirement
            // 
            this.retirement.Location = new System.Drawing.Point(200, 248);
            this.retirement.Name = "retirement";
            this.retirement.ReadOnly = true;
            this.retirement.Size = new System.Drawing.Size(129, 20);
            this.retirement.TabIndex = 13;
            this.retirement.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // social_security
            // 
            this.social_security.Location = new System.Drawing.Point(200, 272);
            this.social_security.Name = "social_security";
            this.social_security.ReadOnly = true;
            this.social_security.Size = new System.Drawing.Size(129, 20);
            this.social_security.TabIndex = 14;
            // 
            // net_pay
            // 
            this.net_pay.Location = new System.Drawing.Point(176, 328);
            this.net_pay.Name = "net_pay";
            this.net_pay.ReadOnly = true;
            this.net_pay.Size = new System.Drawing.Size(129, 20);
            this.net_pay.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 370);
            this.Controls.Add(this.net_pay);
            this.Controls.Add(this.social_security);
            this.Controls.Add(this.retirement);
            this.Controls.Add(this.federal_tax);
            this.Controls.Add(this.total_sales);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox total_sales;
        private System.Windows.Forms.TextBox federal_tax;
        private System.Windows.Forms.TextBox retirement;
        private System.Windows.Forms.TextBox social_security;
        private System.Windows.Forms.TextBox net_pay;
    }
}

