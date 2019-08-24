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
    public partial class Controls_Container : Form
    {
        public Controls_Container()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control item in grb1.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                    item.Text = "";
            }
        }
    }
}
