using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhDiemTrungBinhHocSinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

   

        private void btnTinhTrungBinh_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTen.Text != "" && txtToan.Text != "" && txtVan.Text !="")
                {
                    string Ten = txtTen.Text;
                    double Toan = double.Parse(txtToan.Text);
                    double Van = double.Parse(txtVan.Text);
                    HocSinh hs = new HocSinh(Ten, Toan, Van);
                    
                    double ketqua =  hs.TinhDiemTrungBinh();
                    if (ketqua >= 5.0)
                    {
                        txtLoai.Text = "Đậu";
                    }
                    else
                    {
                        txtLoai.Text = "Rớt";
                    }
                    txtTB.Text = ketqua.ToString();

                }
                else
                {
                    MessageBox.Show("Vui Lòng Nhập thông tin", "Bảng Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTen.Focus();
                }
            }
            catch (Exception err)
            {
                    
            } 
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Muốn Thoát Không?", "Thống Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result ==DialogResult.Yes )
            {
                this.Close();
            }
        }

        private void txtLoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtToan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false))
            {
                e.Handled = true;
            }
        }

        private void txtVan_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtVan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false))
            {
                e.Handled = true;
            }
        }
    }
}
