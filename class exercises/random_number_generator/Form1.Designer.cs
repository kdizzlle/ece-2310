
namespace random_number_generator
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
            this.size = new System.Windows.Forms.TextBox();
            this.Generate = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.Average = new System.Windows.Forms.Button();
            this.Maximum = new System.Windows.Forms.Button();
            this.Minimum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "How many random numbers?";
            // 
            // size
            // 
            this.size.Location = new System.Drawing.Point(312, 89);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(100, 20);
            this.size.TabIndex = 1;
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(311, 140);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(101, 40);
            this.Generate.TabIndex = 2;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(286, 214);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(155, 212);
            this.lstOutput.TabIndex = 3;
            // 
            // Average
            // 
            this.Average.Location = new System.Drawing.Point(518, 162);
            this.Average.Name = "Average";
            this.Average.Size = new System.Drawing.Size(101, 40);
            this.Average.TabIndex = 4;
            this.Average.Text = "Average";
            this.Average.UseVisualStyleBackColor = true;
            this.Average.Click += new System.EventHandler(this.Average_Click);
            // 
            // Maximum
            // 
            this.Maximum.Location = new System.Drawing.Point(518, 234);
            this.Maximum.Name = "Maximum";
            this.Maximum.Size = new System.Drawing.Size(101, 40);
            this.Maximum.TabIndex = 5;
            this.Maximum.Text = "Maximum";
            this.Maximum.UseVisualStyleBackColor = true;
            this.Maximum.Click += new System.EventHandler(this.Maximum_Click);
            // 
            // Minimum
            // 
            this.Minimum.Location = new System.Drawing.Point(518, 310);
            this.Minimum.Name = "Minimum";
            this.Minimum.Size = new System.Drawing.Size(101, 40);
            this.Minimum.TabIndex = 6;
            this.Minimum.Text = "Minimum";
            this.Minimum.UseVisualStyleBackColor = true;
            this.Minimum.Click += new System.EventHandler(this.Minimum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Minimum);
            this.Controls.Add(this.Maximum);
            this.Controls.Add(this.Average);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.size);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox size;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button Average;
        private System.Windows.Forms.Button Maximum;
        private System.Windows.Forms.Button Minimum;
    }
}

