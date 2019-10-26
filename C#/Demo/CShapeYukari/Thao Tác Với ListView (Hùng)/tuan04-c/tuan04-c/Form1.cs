using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace tuan04_c
{
    public partial class Form1 : Form
    {
        int[] arr= new int[10];
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbGoc.Clear();
            rtbKQ.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Are u sure!!", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == exit)
                this.Close();
        }
        const int soN = 10;
        private string Mang()
        {
                Random r = new Random();
                string kq = null;
                for(int i=0;i<soN;i++)
                {
                    int gtri = r.Next(1,50);
                    arr[i] = gtri;
                    kq = kq + " " + gtri;
                }
                return kq;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            rtbGoc.Text=Mang();
        }
        private int tinhTong(int[] a)
        {
            int tong = 0;
            for(int i=0;i<a.Length;i++)
            {
                tong += a[i];
            }
            return tong;
        }
        private void btnSum_Click(object sender, EventArgs e)
        {
            int tong = tinhTong(arr);
            rtbKQ.Text = tong.ToString();
        }

        private int tongChan(int[] b)
        {
            int tong = 0;
            for (int i = 0; i < b.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    tong += b[i];
                }
            }
            return tong;
        }
        private void btnSumChan_Click(object sender, EventArgs e)
        {
            rtbKQ.Clear();
            rtbKQ.Text = tongChan(arr).ToString();

        }

        private int demChan(int[] b)
        {
            int count = 0;
            for (int i = 0; i < b.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
        private void btnCountChan_Click(object sender, EventArgs e)
        {
            rtbKQ.Clear();
            rtbKQ.Text = demChan(arr).ToString();
        }
       
        private void btnMax_Click(object sender, EventArgs e)
        {
            rtbKQ.Clear();
            Array.Sort(arr);
            rtbKQ.Text = arr[arr.Length-1].ToString();

        }
    }
}
