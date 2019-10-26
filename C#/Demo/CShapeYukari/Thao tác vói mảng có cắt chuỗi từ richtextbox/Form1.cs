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

namespace ChuongTrinhMangArr
{
    public partial class Form1 : Form
    {
        int[] mang;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ngon Thì OK", "Thằng LOL", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
                
        }

        private int TinhTong(int[] a)
        {
            int tong = 0;
            for (int i = 0; i < a.Length; i++)
            {
                tong += a[i];
            }
            return tong;
        }

        private void btnTongChan_Click(object sender, EventArgs e)
        {
           
            
        }

        private void btnMangMoi_Click(object sender, EventArgs e)
        {
            string[] tam = rtbMangGoc.Text.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            if(tam.Length > 0)
            {
                mang = new int[tam.Length];
                for (int i = 0; i < mang.Length; i++)
                {
                    mang[i] = int.Parse(tam[i]);
                }
            }
        }

        private void btnTongMang_Click(object sender, EventArgs e)
        {
            int tong = TinhTong(mang);
            rtbKetqua.Text = tong.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbMangGoc.Clear();
        }
    }
}
