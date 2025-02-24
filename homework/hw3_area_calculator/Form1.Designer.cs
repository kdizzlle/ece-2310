
namespace hw3_area_calculator
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
            this.circle = new System.Windows.Forms.Button();
            this.rectangle = new System.Windows.Forms.Button();
            this.cylinder = new System.Windows.Forms.Button();
            this.radius = new System.Windows.Forms.TextBox();
            this.radius_label = new System.Windows.Forms.Label();
            this.length_label = new System.Windows.Forms.Label();
            this.length = new System.Windows.Forms.TextBox();
            this.width_label = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.area_label = new System.Windows.Forms.Label();
            this.area = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Area Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Which area would you like to calculate?";
            // 
            // circle
            // 
            this.circle.Location = new System.Drawing.Point(104, 167);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(132, 53);
            this.circle.TabIndex = 2;
            this.circle.Text = "Circle";
            this.circle.UseVisualStyleBackColor = true;
            this.circle.Click += new System.EventHandler(this.circle_Click);
            // 
            // rectangle
            // 
            this.rectangle.Location = new System.Drawing.Point(289, 167);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(132, 53);
            this.rectangle.TabIndex = 3;
            this.rectangle.Text = "Rectangle";
            this.rectangle.UseVisualStyleBackColor = true;
            this.rectangle.Click += new System.EventHandler(this.rectangle_Click);
            // 
            // cylinder
            // 
            this.cylinder.Location = new System.Drawing.Point(474, 167);
            this.cylinder.Name = "cylinder";
            this.cylinder.Size = new System.Drawing.Size(132, 53);
            this.cylinder.TabIndex = 4;
            this.cylinder.Text = "Cylinder";
            this.cylinder.UseVisualStyleBackColor = true;
            this.cylinder.Click += new System.EventHandler(this.cylinder_Click);
            // 
            // radius
            // 
            this.radius.Location = new System.Drawing.Point(321, 255);
            this.radius.Name = "radius";
            this.radius.Size = new System.Drawing.Size(100, 20);
            this.radius.TabIndex = 5;
            this.radius.Visible = false;
            // 
            // radius_label
            // 
            this.radius_label.AutoSize = true;
            this.radius_label.Location = new System.Drawing.Point(280, 258);
            this.radius_label.Name = "radius_label";
            this.radius_label.Size = new System.Drawing.Size(35, 13);
            this.radius_label.TabIndex = 6;
            this.radius_label.Text = "radius";
            this.radius_label.Visible = false;
            // 
            // length_label
            // 
            this.length_label.AutoSize = true;
            this.length_label.Location = new System.Drawing.Point(280, 284);
            this.length_label.Name = "length_label";
            this.length_label.Size = new System.Drawing.Size(36, 13);
            this.length_label.TabIndex = 8;
            this.length_label.Text = "length";
            this.length_label.Visible = false;
            this.length_label.Click += new System.EventHandler(this.label3_Click);
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(321, 281);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(100, 20);
            this.length.TabIndex = 7;
            this.length.Visible = false;
            this.length.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // width_label
            // 
            this.width_label.AutoSize = true;
            this.width_label.Location = new System.Drawing.Point(280, 310);
            this.width_label.Name = "width_label";
            this.width_label.Size = new System.Drawing.Size(32, 13);
            this.width_label.TabIndex = 10;
            this.width_label.Text = "width";
            this.width_label.Visible = false;
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(321, 307);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(100, 20);
            this.width.TabIndex = 9;
            this.width.Visible = false;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(289, 347);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(132, 53);
            this.calculate.TabIndex = 11;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Visible = false;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // area_label
            // 
            this.area_label.AutoSize = true;
            this.area_label.Location = new System.Drawing.Point(280, 428);
            this.area_label.Name = "area_label";
            this.area_label.Size = new System.Drawing.Size(37, 13);
            this.area_label.TabIndex = 13;
            this.area_label.Text = "area =";
            this.area_label.Visible = false;
            // 
            // area
            // 
            this.area.Location = new System.Drawing.Point(321, 425);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(100, 20);
            this.area.TabIndex = 12;
            this.area.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.area_label);
            this.Controls.Add(this.area);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.width_label);
            this.Controls.Add(this.width);
            this.Controls.Add(this.length_label);
            this.Controls.Add(this.length);
            this.Controls.Add(this.radius_label);
            this.Controls.Add(this.radius);
            this.Controls.Add(this.cylinder);
            this.Controls.Add(this.rectangle);
            this.Controls.Add(this.circle);
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
        private System.Windows.Forms.Button circle;
        private System.Windows.Forms.Button rectangle;
        private System.Windows.Forms.Button cylinder;
        private System.Windows.Forms.TextBox radius;
        private System.Windows.Forms.Label radius_label;
        private System.Windows.Forms.Label length_label;
        private System.Windows.Forms.TextBox length;
        private System.Windows.Forms.Label width_label;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label area_label;
        private System.Windows.Forms.TextBox area;
    }
}

