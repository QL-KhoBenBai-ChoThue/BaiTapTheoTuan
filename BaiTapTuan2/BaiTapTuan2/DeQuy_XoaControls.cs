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
    public partial class frmDeQuy : Form
    {
        public frmDeQuy()
        {
            InitializeComponent();
        }
        private void xoa(Control ctr)
        {
            if (ctr.GetType() == typeof(TextBox))
                ctr.Text = "";
            foreach (Control item in ctr.Controls)
            {                              
                xoa(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                // xoa tat ca textbox
                if (item.GetType() == typeof(TextBox))
                    item.Text = "";               
                xoa(item);              
            }
            
        }
    }
}
