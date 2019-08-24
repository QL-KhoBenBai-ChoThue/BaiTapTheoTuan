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
    public partial class b4 : Form
    {

        int[] arr;

        public b4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int n = int.Parse(txt_n.Text.ToString()) * 2;
            arr = new int[n];

            Random r = new Random();
            int oo = n / 2;
            int pp = 1;
            for (int i = 0; i < n; i=i+2)
            {
                arr[i] = pp;
                arr[i + 1] = pp;
                pp++;
            }

            for (int i = 0; i < n/2; i++)
            {
                int a = r.Next(n);
                int b = r.Next(n);
                int aa = arr[a];
                arr[a] = arr[b];
                arr[b] = aa;
            }

            int k = n / 6;
            int m = n % 6;
            int o = 0;
            if (m > 0) k = k + 1;

            for (int i = 0; i < k; i++)
            {              
                for (int j = 0; j < 6; j++)
                {
                    o++;
                    CheckBox p;
                    p = new CheckBox();
                    //p.Location = new System.Drawing.Point(0, 0);
                    p.Top = i*90;
                    p.Left = j*90;
                    p.Name =o.ToString();
                    p.Size = new System.Drawing.Size(90, 90);
                    p.Text = "Click me";
                    p.Appearance = System.Windows.Forms.Appearance.Button;
                    p.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    p.Click += p_Click;
                    panel1.Controls.Add(p);

                    if (o == n) break;
                }
            }
        }

        void p_Click(object sender, EventArgs e)
        {
            //int n = int.Parse(this.Name.ToString());
            MessageBox.Show("");
        }

        //private void p_Click(object sender, EventArgs e)
        //{
        //    int n = int.Parse(p.Name.ToString());
        //    p.Text = arr[n].ToString();
        //}

        private void checkBox1_Click(object sender, EventArgs e)
        {
            checkBox1.Text = "222";
        }
    }
}
