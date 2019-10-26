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
namespace Tuan07BaiTap01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arr;
        private void btnCapNhat_Click(object sender, EventArgs e)
        {

            int soLuong = int.Parse(txtSoLuong.Text);
            arr=new int[soLuong];
            for(int i=1;i<soLuong+1;i++)
            {
                arr[i-1] = i;
            }
            XuatDanhSach(arr);
        }
        private void XuatDanhSach(int[]arr)
        {
            lstDanhSach.Items.Clear();
            for (int i = 0; i < arr.Length; i++) 
            {
                lstDanhSach.Items.Add(arr[i]);
            }
        }
        private int TongMang(int[] arr)
        {
            int kq = 0;
            for(int i=0;i<arr.Length;i++)
            {
                kq += arr[i];
            } 
            return kq;
        }
        private void MangTang2(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] + 2;    
            }
        }
        private void MangBinhPhuong(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i]*arr[i];
            }
        }
        private void btnTongDS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tổng là:" + TongMang(arr).ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoaDC_Click(object sender, EventArgs e)
        {
            int soLuong = int.Parse(txtSoLuong.Text);
            int[] arrtam = new int [soLuong-2];
            for (int i = 0; i < arrtam.Length; i++)
            {
                    arrtam[i] = arr[i + 1];
            }
            arr = new int[soLuong - 2];
            for (int i = 0; i < arr.Length; i++)
            {
              
                    arr[i] = arrtam[i];
            }
            XuatDanhSach(arr);
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            MangTang2(arr);
            XuatDanhSach(arr);
        }

        private void btnBinhPhuong_Click(object sender, EventArgs e)
        {
            MangBinhPhuong(arr);
            XuatDanhSach(arr);
        }

        private void btnXoaChon_Click(object sender, EventArgs e)
        {
            int[] arrTam= new int [arr.Length-lstDanhSach.SelectedItems.Count];
            for (int i = lstDanhSach.SelectedItems.Count - 1; i >= 0; i--)
            {
                lstDanhSach.Items.Remove(lstDanhSach.SelectedItems[i]);
            }
            for (int i =0; i <arrTam.Length; i++)
            {
                arrTam[i] = int.Parse(lstDanhSach.Items[i].ToString());
            }
            arr= new int[arrTam.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arrTam[i];
            }

            XuatDanhSach(arr);
        }
   
        private void btnChonChan_Click(object sender, EventArgs e)
        {
            lstDanhSach.ClearSelected();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    lstDanhSach.SelectedItem = arr[i];
                }
            }
        }

        private void btnChonLe_Click(object sender, EventArgs e)
        {
            lstDanhSach.ClearSelected();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    lstDanhSach.SelectedItem = arr[i];
                }
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn muốn thoát chứ !","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
                this.Close();
        }

        private void btnBoChon_Click(object sender, EventArgs e)
        {
            lstDanhSach.ClearSelected();
        }
    }
}
