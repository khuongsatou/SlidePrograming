using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XuLiChuoiTT
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private string _nhap;

        public string Nhap
        {
            get { return _nhap; }
            set { _nhap = value; }
        }
        

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtNhap.Text !="")
            {
                _nhap = txtNhap.Text;
                this.Visible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
