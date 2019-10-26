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
namespace XuLiChuoiTT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
           
        //khai báo toàn cục
        //ArrayList arr = new ArrayList();
        string str = null;

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Tắt?","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnNhapLieu_Click(object sender, EventArgs e)
        {
            if (rtbNhapDuLieu.Text != "")
            {
                //arr.Add(rtbNhapDuLieu.Text);
                str = rtbNhapDuLieu.Text;
            }
        }

        private void btnDemSoKTHoa_Click(object sender, EventArgs e)
        {
            int dem = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    dem++;
                }
            }
            rtbXuatDuLieu.Text = dem.ToString();
        }

        private void btnInChuHoa_Click(object sender, EventArgs e)
        {
            string temp="";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    temp +=str[i].ToString();  
                            
                }
            }
            rtbXuatDuLieu.Text = temp.ToString();
        }

        private void btnInMoiTuTren1Dong_Click(object sender, EventArgs e)
        {

            string temp = "";
            string[] tmp = str.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < tmp.Length; i++)
            {
                temp += tmp[i];
                temp += "\n";
            }
            rtbXuatDuLieu.Text =temp;
        }
        
        private void btnChuThuong_Click(object sender, EventArgs e)
        {
            string temp = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z')
                {
                    temp += str[i].ToString();

                }
            }
            rtbXuatDuLieu.Text = temp.ToString();
        }

        private void btnDemSoTu_Click(object sender, EventArgs e)
        {
            int dem = 0;
            string[] tmp = str.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < tmp.Length; i++)
            {
               dem++;
            }
            rtbXuatDuLieu.Text = dem.ToString();
        }

        private void btnDemSoKTThuong_Click(object sender, EventArgs e)
        {
            int dem = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z')
                {
                    dem++;
                }
            }
            rtbXuatDuLieu.Text = dem.ToString();
        }
        /* a b c*/
        private void btnXoaKTTrangDuThua_Click(object sender, EventArgs e)
        {
            string tam = null;
            string[] tmp = str.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < tmp.Length; i++)
            {
                tam += tmp[i];
                tam += " ";
            }
            str = tam.Trim();
            rtbXuatDuLieu.Text = tam.Trim();
        }

        private void btnXoaChuoi_Click(object sender, EventArgs e)
        {
            str = "";
            rtbNhapDuLieu.Text = str;
        }

        private void btnInNguyenAmPhuAm_Click(object sender, EventArgs e)
        {
            string nguyenAm = "";
            string phuAm = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'e' || str[i] == 'u' || str[i] == 'o' || str[i] == 'a' || str[i] == 'i' || str[i] == 'E' || str[i] == 'U' || str[i] == 'O' || str[i] == 'A' || str[i] == 'I')//euoai
                {
                    nguyenAm += str[i];
                }
                else
                {
                    phuAm += str[i];
                }
            }
         
            rtbXuatDuLieu.Text = nguyenAm +"\n"+phuAm;
        }
    }
}
