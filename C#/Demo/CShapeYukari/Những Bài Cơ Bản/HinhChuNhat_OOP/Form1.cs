using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HinhChuNhat_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChuVi_Click(object sender, EventArgs e)
        {
            if(txtA.Text=="" || txtB.Text == ""){
                MessageBox.Show("Vui Lòng Nhập");
            }
            else
            {
                double chieudai =double.Parse(txtA.Text);
                double chieurong = double.Parse(txtB.Text);
                HinhChuNhat hcn = new HinhChuNhat(chieudai, chieurong);
                txtKetQua.Text = hcn.TinhChuVi().ToString();
               
            }
        }

        private void btnDienTich_Click(object sender, EventArgs e)
        {
            if (txtA.Text == "" || txtB.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập");
            }
            else
            {
                double chieudai = double.Parse(txtA.Text);
                double chieurong = double.Parse(txtB.Text);
                HinhChuNhat hcn = new HinhChuNhat(chieudai, chieurong);
                txtKetQua.Text = hcn.TinhDienTich().ToString();
             
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có Muốn Thoát", "Có", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
