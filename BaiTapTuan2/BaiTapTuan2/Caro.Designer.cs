namespace BaiTapTuan2
{
    partial class Caro
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
            this.btn_n = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txt_n
            // 
            this.txt_n.Location = new System.Drawing.Point(23, 27);
            this.txt_n.Name = "txt_n";
            this.txt_n.Size = new System.Drawing.Size(100, 22);
            this.txt_n.TabIndex = 0;
            // 
            // btn_n
            // 
            this.btn_n.Location = new System.Drawing.Point(148, 25);
            this.btn_n.Name = "btn_n";
            this.btn_n.Size = new System.Drawing.Size(75, 23);
            this.btn_n.TabIndex = 1;
            this.btn_n.Text = "button1";
            this.btn_n.UseVisualStyleBackColor = true;
            this.btn_n.Click += new System.EventHandler(this.btn_n_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(23, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 489);
            this.panel1.TabIndex = 2;
            // 
            // Caro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 620);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_n);
            this.Controls.Add(this.txt_n);
            this.Name = "Caro";
            this.Text = "Caro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_n;
        private System.Windows.Forms.Button btn_n;
        private System.Windows.Forms.Panel panel1;
    }
}