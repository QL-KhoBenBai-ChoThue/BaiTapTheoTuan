using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynamic_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public IEnumerable<GroupBox> GroupBoxs { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteFull();
        }
        private void DeleteTexboxGroupBox(Control a)
        {
            if(a is GroupBox)
            {
                foreach (Control item in a.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                    if (item is GroupBox)
                    {
                        DeleteTexboxGroupBox(item);
                    }
                }
            }

        }

        private void DeleteFull()
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is GroupBox)
                {
                    DeleteTexboxGroupBox(item);
                }
               
            }
           
        }

    }
}
