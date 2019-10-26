using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tuan05_C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        LopHoc lop = new LopHoc();
        int vitrihientai = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int mahs = int.Parse(txtMa.Text);
            string tenhs = txtTen.Text;
            DateTime ngsinh = dateTimePicker1.Value;
            string diachi = txtDchi.Text;
            int toan = int.Parse(txtToan.Text);
            int van = int.Parse(txtVan.Text);

            HocSinh hs = new HocSinh(mahs, tenhs, diachi, ngsinh, toan, van);
            lop.Them(hs);
            HienthiDS(lop.DSHS);

        }
        private void HienthiDS(List<HocSinh> danhsach)
        {
            listView1.Items.Clear();
            HocSinh hs = new HocSinh();
            for(int i=0; i<danhsach.Count;i++)
            {
                hs = danhsach[i];
                ListViewItem lvi = new ListViewItem(hs.ma.ToString());
                lvi.SubItems.Add(hs.name.ToString());
                lvi.SubItems.Add(hs.dchi.ToString());
                lvi.SubItems.Add(hs.ngaysinh.ToString());
                lvi.SubItems.Add(hs.diemToan.ToString());
                lvi.SubItems.Add(hs.diemVan.ToString());
                lvi.SubItems.Add(hs.diemTB().ToString());
                lvi.SubItems.Add(hs.xepLoai().ToString());
                listView1.Items.Add(lvi);

            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            listView1.Items.RemoveAt(vitrihientai);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (int vitri in listView1.SelectedIndices)
            { 
                vitrihientai = vitri;
            }
            hienthithongtin(vitrihientai);
        }
        private void hienthithongtin(int vitri)
        {
            HocSinh hs = new HocSinh();
            hs = lop.DSHS[vitri];
            txtMa.Text = hs.ma.ToString();
            txtTen.Text = hs.name.ToString();
            txtDchi.Text = hs.dchi.ToString();
            dateTimePicker1.Value = hs.ngaysinh;
            txtToan.Text = hs.diemToan.ToString();
            txtVan.Text = hs.diemVan.ToString();
        }
    }
}
