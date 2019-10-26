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

namespace _25_NguyenVankhuong_0306171362_CDTH17D
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnXemDanhSach_Click(object sender, EventArgs e)
        {
            BAL_SANPHAM bal_sp = new BAL_SANPHAM();
            dgvDanhSachSP.DataSource = bal_sp.getSanPham();
        }

      
    }
}
