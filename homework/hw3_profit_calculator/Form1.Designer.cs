
namespace hw3_profit_calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.profit = new System.Windows.Forms.Button();
            this.money = new System.Windows.Forms.TextBox();
            this.profits = new System.Windows.Forms.TextBox();
            this.ratio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sales = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 96);
            this.label1.TabIndex = 0;
            this.label1.Text = "$0 - $1000: 3%\r\n$1000.01_$5000: 3.5%\r\n$5000.01_$10000: 4%\r\nover $10000: 4.5%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please enter the total sales for the organization then select \"Profit.\"";
            // 
            // profit
            // 
            this.profit.Location = new System.Drawing.Point(164, 204);
            this.profit.Name = "profit";
            this.profit.Size = new System.Drawing.Size(75, 23);
            this.profit.TabIndex = 2;
            this.profit.Text = "Profit";
            this.profit.UseVisualStyleBackColor = true;
            this.profit.Click += new System.EventHandler(this.profit_Click);
            // 
            // money
            // 
            this.money.Location = new System.Drawing.Point(82, 243);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(100, 20);
            this.money.TabIndex = 3;
            // 
            // profits
            // 
            this.profits.Location = new System.Drawing.Point(82, 295);
            this.profits.Name = "profits";
            this.profits.Size = new System.Drawing.Size(100, 20);
            this.profits.TabIndex = 4;
            // 
            // ratio
            // 
            this.ratio.Location = new System.Drawing.Point(82, 269);
            this.ratio.Name = "ratio";
            this.ratio.Size = new System.Drawing.Size(100, 20);
            this.ratio.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sales";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Profit Ratio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Profit";
            // 
            // sales
            // 
            this.sales.Location = new System.Drawing.Point(154, 178);
            this.sales.Name = "sales";
            this.sales.Size = new System.Drawing.Size(100, 20);
            this.sales.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 347);
            this.Controls.Add(this.sales);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ratio);
            this.Controls.Add(this.profits);
            this.Controls.Add(this.money);
            this.Controls.Add(this.profit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button profit;
        private System.Windows.Forms.TextBox money;
        private System.Windows.Forms.TextBox profits;
        private System.Windows.Forms.TextBox ratio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sales;
    }
}

