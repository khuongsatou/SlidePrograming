using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCoBan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int SoThuNhat= 0;
        float SoThuHai = 0;
        float KetQua   = 0;
        DialogResult ThongBao;
        private void button1_Click(object sender, EventArgs e)
        {
            SoThuNhat = int.Parse(txtSoThuNhat.Text);
            SoThuHai = int.Parse(txtSoThuHai.Text);
            KetQua = SoThuNhat + SoThuHai;
            txtKetQua.Text = KetQua.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result =  MessageBox.Show("Bạn có Muốn Thoát","Thoát" ,MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            SoThuNhat = int.Parse(txtSoThuNhat.Text);
            SoThuHai = int.Parse(txtSoThuHai.Text);
            KetQua = SoThuNhat - SoThuHai;
            txtKetQua.Text = KetQua.ToString();
        }

        private void btnTich_Click(object sender, EventArgs e)
        {
            SoThuNhat = int.Parse(txtSoThuNhat.Text);
            SoThuHai = int.Parse(txtSoThuHai.Text);
            KetQua = SoThuNhat * SoThuHai;
            txtKetQua.Text = KetQua.ToString();
        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            SoThuNhat = int.Parse(txtSoThuNhat.Text);
            SoThuHai = float.Parse(txtSoThuHai.Text);
            if (SoThuHai != 0)
            {
                KetQua =(float) SoThuNhat / SoThuHai;
                txtKetQua.Text = KetQua.ToString();
            }
            else {
                MessageBox.Show("Số Thứ 2 Không Được '"+SoThuHai+"' ");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private float Tong(int a, float b)
        {
            return a + b;
        }

        private float Tru(int a, float b)
        {
            return a - b;
        }

        private float Nhan(int a, float b)
        {
            return a * b;
        }
        private float Chia(int a, float b)
        {
            if (b != 0)
            {
                return a / b;
            }
            return 0;
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            

            if (txtSoThuNhat.Text == "" || txtSoThuHai.Text == "")
            {
                MessageBox.Show("nhap day du 2 so thang cho!!!");
            }
            else
            {
                SoThuNhat = int.Parse(txtSoThuNhat.Text);
                SoThuHai = float.Parse(txtSoThuHai.Text);
                if (radCong.Checked)
                {
                    lblKetQua.Text = "Tổng";
                    txtKetQua.Text = Tong(SoThuNhat, SoThuHai).ToString();
                }
                else if (radTru.Checked)
                {
                    lblKetQua.Text = "Trừ";
                    txtKetQua.Text = Tru(SoThuNhat, SoThuHai).ToString();
                }
                else if (radNhan.Checked)
                {
                    lblKetQua.Text = "Nhân";
                    txtKetQua.Text = Nhan(SoThuNhat, SoThuHai).ToString();
                }
                else
                {
                    KetQua = Chia(SoThuNhat, SoThuHai);
                    if (KetQua != 0)
                    {
                        lblKetQua.Text = "Chia";
                        txtKetQua.Text = Chia(SoThuNhat, SoThuHai).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Số thứ 2  Phải Khác  0   ");
                    }


                }

            }
        }
    }
}
