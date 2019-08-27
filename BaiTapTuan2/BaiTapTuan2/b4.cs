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

            for (int i = 0; i < n/2; i++)
            {
                arr[i] = i;
                arr[n/2+i] = i;

                //0=0,1=1,2=2
                //3=0,4=1,5=2
            }
                 
            //random
            hoanViMang(arr, n);

            int k = n / 6;
            int m = n % 6;
            int name = 0;

            if (m > 0) k = k + 1;
            for (int i = 0; i < k; i++)                         
                for (int j = 0; j < 6; j++)
                {                                     
                    CheckBox p = new CheckBox();
                    //p.Location = new System.Drawing.Point(0, 0);
                    p.Top = i*90;
                    p.Left = j*90;
                    p.Name =name.ToString();
                    p.Size = new System.Drawing.Size(90, 90);
                    
                    p.Text = arr[name].ToString();

                    p.Appearance = System.Windows.Forms.Appearance.Button;
                    p.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;                 
                    panel1.Controls.Add(p);

                    name++; 
                    if (name == n) break;
                }          
        }

        //random
        void hoanViMang(int[] a, int n)
        {
            Random r = new Random();
            int index, temp;
            for(int i = 0; i < n-1; i++)
            {
                index = i + 1 + r.Next(n-1-i);
                //0+1+r(9)
                //2+r(8)
                //3+r(7)
                temp = a[i];
                a[i] = a[index];
                a[index] = temp;
            }
        }
    }
}
