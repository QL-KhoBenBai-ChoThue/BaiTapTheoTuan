namespace BaiTapTuan2
{
    partial class Controls_Container
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
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb1
            // 
            this.grb1.Controls.Add(this.txt4);
            this.grb1.Controls.Add(this.txt3);
            this.grb1.Controls.Add(this.textBox2);
            this.grb1.Controls.Add(this.textBox1);
            this.grb1.Location = new System.Drawing.Point(64, 42);
            this.grb1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grb1.Name = "grb1";
            this.grb1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grb1.Size = new System.Drawing.Size(352, 354);
            this.grb1.TabIndex = 0;
            this.grb1.TabStop = false;
            this.grb1.Text = "grb1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 95);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 30);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "txt1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 145);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 30);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "txt2";
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(111, 198);
            this.txt3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(148, 30);
            this.txt3.TabIndex = 2;
            this.txt3.Text = "txt3";
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(111, 256);
            this.txt4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(148, 30);
            this.txt4.TabIndex = 3;
            this.txt4.Text = "txt4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Process Text Boxes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Controls_Container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 546);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grb1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Controls_Container";
            this.Text = "Form1";
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

