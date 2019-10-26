using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using BAL;
using BEL;
namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiDSSV(dgvDanhSach);
            HienThiDSLOP(cboLop);
        }
        public void HienThiDSSV(DataGridView dgv)
        {
            BAL_SINHVIEN xulySV=new BAL_SINHVIEN();
            dgv.DataSource=xulySV.getDanhSachSinhVien();    
        }
        public void HienThiDSLOP(ComboBox cbo)
        {
            BAL_LOPHOC xlyLop = new BAL_LOPHOC();
            cbo.DataSource = xlyLop.getDSLOP();
            cbo.DisplayMember = "TenLop";
            cbo.ValueMember = "MaLop";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text != "" && txtHoTen.Text != "")
            {
                string gioitinh = null;
                if (rdNam.Checked == true)
                    gioitinh = "Nam";
                else if (rdNu.Checked == true)
                    gioitinh = "Nữ";

                string malop = null;
                string masv = txtMaSV.Text;
                string hoten = txtHoTen.Text;
                DateTime ngaysinh = DateTime.Parse(dtpNgaySinh.Value.ToString());
                string diachi = txtDiaChi.Text;
                BAL_LOPHOC xulylop = new BAL_LOPHOC();
                DataTable dtLop = new DataTable();
                dtLop = xulylop.LayMaLop(cboLop.Text.Trim());
                malop = dtLop.Rows[0]["MaLop"].ToString();
                SINHVIEN sv = new SINHVIEN(masv, hoten, ngaysinh, gioitinh, diachi, malop.Trim());
                BAL_SINHVIEN xulysinhvien = new BAL_SINHVIEN();
                bool kqthem = xulysinhvien.ThemSV(sv);
                if (kqthem == true)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    dgvDanhSach.DataSource = xulysinhvien.getDanhSachSinhVien();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string masv = dgvDanhSach.CurrentRow.Cells[0].Value.ToString().Trim();
            BAL_SINHVIEN xulysinhvien=new BAL_SINHVIEN();
            DataTable dt = new DataTable();
            dt = xulysinhvien.LaySVTheoMa(masv);
            txtMaSV.Text = dt.Rows[0]["MaSV"].ToString();
            txtHoTen.Text = dt.Rows[0]["HoTen"].ToString();
            string gioitinh = dt.Rows[0]["GioiTinh"].ToString();
            if (gioitinh.Equals("Nam"))
                rdNam.Checked = true;
            else
                rdNu.Checked = true;
            dtpNgaySinh.Value = DateTime.Parse(dt.Rows[0]["NgaySinh"].ToString());
            txtDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();
            cboLop.Text = dt.Rows[0]["TenLop"].ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            BAL_SINHVIEN xulysinhvien = new BAL_SINHVIEN();
            bool kqxoa= xulysinhvien.XoaSVTheoMa(txtMaSV.Text);
            if (kqxoa == true)
            {
                MessageBox.Show("Xoa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                dgvDanhSach.DataSource = xulysinhvien.getDanhSachSinhVien();
            }
            else
            {
                MessageBox.Show("Xoa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            rdNam.Checked = false;
            rdNu.Checked = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text != "" && txtHoTen.Text != "")
            {
                string gioitinh = null;
                if (rdNam.Checked == true)
                    gioitinh = "Nam";
                else if (rdNu.Checked == true)
                    gioitinh = "Nữ";

                string malop = null;
                string masv = txtMaSV.Text;
                string hoten = txtHoTen.Text;
                DateTime ngaysinh = DateTime.Parse(dtpNgaySinh.Value.ToString());
                string diachi = txtDiaChi.Text;
                BAL_LOPHOC xulylop = new BAL_LOPHOC();
                DataTable dtLop = new DataTable();
                dtLop = xulylop.LayMaLop(cboLop.Text.Trim());
                malop = dtLop.Rows[0]["MaLop"].ToString();
                SINHVIEN sv = new SINHVIEN(masv, hoten, ngaysinh, gioitinh, diachi, malop.Trim());
                BAL_SINHVIEN xulysinhvien = new BAL_SINHVIEN();
                bool kqUpdate = xulysinhvien.UpdateSV(sv);
                if (kqUpdate == true)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    dgvDanhSach.DataSource = xulysinhvien.getDanhSachSinhVien();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            
            }

        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

    }
}
