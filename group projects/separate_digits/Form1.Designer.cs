
namespace separate_digits
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
            this.number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dig1 = new System.Windows.Forms.TextBox();
            this.dig4 = new System.Windows.Forms.TextBox();
            this.dig5 = new System.Windows.Forms.TextBox();
            this.dig3 = new System.Windows.Forms.TextBox();
            this.dig2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.separate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(263, 72);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(100, 20);
            this.number.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter a 5 digit number:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dig1
            // 
            this.dig1.Location = new System.Drawing.Point(215, 215);
            this.dig1.Name = "dig1";
            this.dig1.Size = new System.Drawing.Size(48, 20);
            this.dig1.TabIndex = 2;
            // 
            // dig4
            // 
            this.dig4.Location = new System.Drawing.Point(376, 215);
            this.dig4.Name = "dig4";
            this.dig4.Size = new System.Drawing.Size(48, 20);
            this.dig4.TabIndex = 3;
            // 
            // dig5
            // 
            this.dig5.Location = new System.Drawing.Point(430, 215);
            this.dig5.Name = "dig5";
            this.dig5.Size = new System.Drawing.Size(48, 20);
            this.dig5.TabIndex = 4;
            // 
            // dig3
            // 
            this.dig3.Location = new System.Drawing.Point(323, 215);
            this.dig3.Name = "dig3";
            this.dig3.Size = new System.Drawing.Size(48, 20);
            this.dig3.TabIndex = 5;
            // 
            // dig2
            // 
            this.dig2.Location = new System.Drawing.Point(269, 215);
            this.dig2.Name = "dig2";
            this.dig2.Size = new System.Drawing.Size(48, 20);
            this.dig2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "The digits are:";
            // 
            // separate
            // 
            this.separate.Location = new System.Drawing.Point(225, 133);
            this.separate.Name = "separate";
            this.separate.Size = new System.Drawing.Size(240, 44);
            this.separate.TabIndex = 8;
            this.separate.Text = "Separate the digits";
            this.separate.UseVisualStyleBackColor = true;
            this.separate.Click += new System.EventHandler(this.separate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 315);
            this.Controls.Add(this.separate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dig2);
            this.Controls.Add(this.dig3);
            this.Controls.Add(this.dig5);
            this.Controls.Add(this.dig4);
            this.Controls.Add(this.dig1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.number);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dig1;
        private System.Windows.Forms.TextBox dig4;
        private System.Windows.Forms.TextBox dig5;
        private System.Windows.Forms.TextBox dig3;
        private System.Windows.Forms.TextBox dig2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button separate;
    }
}

