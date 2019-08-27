using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapTuan2
{
    public partial class Caro : Form
    {
        public Caro()
        {
            InitializeComponent();
        }

        private void btn_n_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txt_n.Text.ToString());
            for (int i =0; i< n; i++)
                for (int j = 0; j < n; j++)
                {                  
                    CheckBox p = new CheckBox();
                    //p.Location = new System.Drawing.Point(0, 0);
                    p.Top = i * 50;
                    p.Left = j * 50;                   
                    p.Size = new System.Drawing.Size(50, 50);                  
                    p.Appearance = System.Windows.Forms.Appearance.Button;                   
                    panel1.Controls.Add(p);
                }
        }
    }
}
