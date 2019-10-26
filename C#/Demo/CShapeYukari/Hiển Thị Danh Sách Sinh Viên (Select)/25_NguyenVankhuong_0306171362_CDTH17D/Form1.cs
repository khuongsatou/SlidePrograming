using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25_NguyenVankhuong_0306171362_CDTH17D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTatCaSP_Click(object sender, EventArgs e)
        {
            //From2 frm2 = new From2();
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }

        private void btnSanPhamGiaBan_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
        }
    }
}
