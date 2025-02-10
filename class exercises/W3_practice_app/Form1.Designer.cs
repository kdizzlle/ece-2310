
namespace W3_practice_app
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
            this.txtNUM1 = new System.Windows.Forms.TextBox();
            this.txtNUM2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.add_but = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRESULT = new System.Windows.Forms.TextBox();
            this.subtract_but = new System.Windows.Forms.Button();
            this.mult_but = new System.Windows.Forms.Button();
            this.divide_but = new System.Windows.Forms.Button();
            this.modulo_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNUM1
            // 
            this.txtNUM1.Location = new System.Drawing.Point(265, 131);
            this.txtNUM1.Name = "txtNUM1";
            this.txtNUM1.Size = new System.Drawing.Size(81, 20);
            this.txtNUM1.TabIndex = 0;
            this.txtNUM1.TextChanged += new System.EventHandler(this.txtNUM1_TextChanged);
            // 
            // txtNUM2
            // 
            this.txtNUM2.Location = new System.Drawing.Point(475, 131);
            this.txtNUM2.Name = "txtNUM2";
            this.txtNUM2.Size = new System.Drawing.Size(81, 20);
            this.txtNUM2.TabIndex = 1;
            this.txtNUM2.TextChanged += new System.EventHandler(this.txtNUM2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Calculator";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ether the 2 numbers you would like to operate on:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Number 1:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Number 2:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // add_but
            // 
            this.add_but.BackColor = System.Drawing.Color.Honeydew;
            this.add_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_but.Location = new System.Drawing.Point(67, 183);
            this.add_but.Name = "add_but";
            this.add_but.Size = new System.Drawing.Size(89, 60);
            this.add_but.TabIndex = 8;
            this.add_but.Text = "Add\r\n+";
            this.add_but.UseVisualStyleBackColor = false;
            this.add_but.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "The result is:";
            // 
            // txtRESULT
            // 
            this.txtRESULT.Location = new System.Drawing.Point(372, 286);
            this.txtRESULT.Name = "txtRESULT";
            this.txtRESULT.Size = new System.Drawing.Size(81, 20);
            this.txtRESULT.TabIndex = 10;
            // 
            // subtract_but
            // 
            this.subtract_but.BackColor = System.Drawing.Color.Honeydew;
            this.subtract_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtract_but.Location = new System.Drawing.Point(192, 183);
            this.subtract_but.Name = "subtract_but";
            this.subtract_but.Size = new System.Drawing.Size(104, 60);
            this.subtract_but.TabIndex = 11;
            this.subtract_but.Text = "Subtract\r\n-";
            this.subtract_but.UseVisualStyleBackColor = false;
            this.subtract_but.Click += new System.EventHandler(this.subtract_but_Click);
            // 
            // mult_but
            // 
            this.mult_but.BackColor = System.Drawing.Color.Honeydew;
            this.mult_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mult_but.Location = new System.Drawing.Point(336, 183);
            this.mult_but.Name = "mult_but";
            this.mult_but.Size = new System.Drawing.Size(104, 60);
            this.mult_but.TabIndex = 12;
            this.mult_but.Text = "Multiply\r\nx";
            this.mult_but.UseVisualStyleBackColor = false;
            this.mult_but.Click += new System.EventHandler(this.mult_but_Click);
            // 
            // divide_but
            // 
            this.divide_but.BackColor = System.Drawing.Color.Honeydew;
            this.divide_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide_but.Location = new System.Drawing.Point(489, 183);
            this.divide_but.Name = "divide_but";
            this.divide_but.Size = new System.Drawing.Size(104, 60);
            this.divide_but.TabIndex = 13;
            this.divide_but.Text = "Divide\r\n/";
            this.divide_but.UseVisualStyleBackColor = false;
            this.divide_but.Click += new System.EventHandler(this.divide_but_Click);
            // 
            // modulo_but
            // 
            this.modulo_but.BackColor = System.Drawing.Color.Honeydew;
            this.modulo_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modulo_but.Location = new System.Drawing.Point(638, 183);
            this.modulo_but.Name = "modulo_but";
            this.modulo_but.Size = new System.Drawing.Size(104, 60);
            this.modulo_but.TabIndex = 14;
            this.modulo_but.Text = "Modulo\r\n%";
            this.modulo_but.UseVisualStyleBackColor = false;
            this.modulo_but.Click += new System.EventHandler(this.modulo_but_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(796, 356);
            this.Controls.Add(this.modulo_but);
            this.Controls.Add(this.divide_but);
            this.Controls.Add(this.mult_but);
            this.Controls.Add(this.subtract_but);
            this.Controls.Add(this.txtRESULT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.add_but);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNUM2);
            this.Controls.Add(this.txtNUM1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNUM1;
        private System.Windows.Forms.TextBox txtNUM2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button add_but;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRESULT;
        private System.Windows.Forms.Button subtract_but;
        private System.Windows.Forms.Button mult_but;
        private System.Windows.Forms.Button divide_but;
        private System.Windows.Forms.Button modulo_but;
    }
}

