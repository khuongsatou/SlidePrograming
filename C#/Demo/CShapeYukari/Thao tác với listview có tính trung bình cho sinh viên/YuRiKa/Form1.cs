using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace YuRiKa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        LopHoc lop = new LopHoc();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaHS.Text != "" && txtHoTen.Text != "" && dtpNgaySinh.Text != "" && txtDiaChi.Text != "" && txtDiemToan.Text != "" && txtDiemVan.Text != "") 
            {
                int MaHS = int.Parse(txtMaHS.Text);
                string Hoten = txtHoTen.Text;
                DateTime NgaySinh = dtpNgaySinh.Value;
                string DiaChi = txtDiaChi.Text;
                float DiemToan = float.Parse(txtDiemToan.Text);
                float DiemVan = float.Parse(txtDiemVan.Text);
                HocSinh hs = new HocSinh(MaHS, Hoten, NgaySinh, DiaChi, DiemToan, DiemVan);
                lop.Them(hs);
                HienThiDS(lop.DSHS);
            }
        }

        private void HienThiDS(List<HocSinh> danhsach)
        {
            HocSinh hs = new HocSinh();
            for (int i = 0; i <danhsach.Count; i++)
            {
                hs = danhsach[i];
                ListViewItem lvi = new ListViewItem(hs.MaHS.ToString());
                lvi.SubItems.Add(hs.HoTen);
                lvi.SubItems.Add(hs.NgaySinh.ToString());
                lvi.SubItems.Add(hs.DiaChi);
                lvi.SubItems.Add(hs.DiemToan.ToString());
                lvi.SubItems.Add(hs.DiemVan.ToString());
                lvi.SubItems.Add(hs.TinhDTB().ToString());
                lvi.SubItems.Add(hs.TinhXepLoai().ToString());
                
                lvBangDiem.Items.Add(lvi);
            }
           
        }

      
    }
}
