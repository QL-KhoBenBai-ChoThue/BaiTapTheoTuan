﻿namespace BaiTapTuan2
{
    partial class b4
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
            this.txt_n = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txt_n
            // 
            this.txt_n.Location = new System.Drawing.Point(22, 25);
            this.txt_n.Name = "txt_n";
            this.txt_n.Size = new System.Drawing.Size(100, 22);
            this.txt_n.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(54, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 600);
            this.panel1.TabIndex = 2;
            // 
            // b4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 772);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_n);
            this.Name = "b4";
            this.Text = "b4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_n;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}