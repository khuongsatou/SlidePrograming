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
using System.IO;

namespace PMNuoiCShape
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
            try
            {
                string masv = txtMaSV.Text;
                string hoten = txtHoTen.Text;
                string diachi = txtDiaChi.Text;
                string ngaysinh = dtpNgaySinh.Value.ToShortDateString();//lấy ngày
                string lop = cbLop.Items[cbLop.SelectedIndex].ToString();
                dataGridView1.Rows.Add(masv, hoten, diachi, ngaysinh, lop);
            }
            catch (Exception)
            {
                
                throw;
            }
           
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGhiFile_Click(object sender, EventArgs e)
        {
            try
            {
                //string thumucgoc = Directory.GetCurrentDirectory();
                string duongdan = "..//..//dulieu/dulieu.txt";
                string[] cacdong = File.ReadAllLines(duongdan);
                string dong = "";
                for (int i = 0; i < cacdong.Length; i++)
                {
                    dong = cacdong[i];
                    string[] tam = dong.Split("\t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    if (tam.Length>0)
                    {
                        string masv = tam[0];
                        string hoten = tam[1];
                        string diachi = tam[2];
                        string ngaysinh = tam[3];
                        string lop = tam[4];
                        dataGridView1.Rows.Add(masv, hoten, diachi, ngaysinh, lop);
                    }
                }
            }
            catch (Exception err)
            {
                
                throw;
            }
           
            
        }

        private void KhoiTaoLop()
        {
            cbLop.Items.Add("17A");
            cbLop.Items.Add("17B");
            cbLop.Items.Add("17C");
            cbLop.Items.Add("17D");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KhoiTaoLop();
        }

        int i=0;
        private void btnXoa_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(i);
            i++;
            
        }

       
       

        
    }
}
