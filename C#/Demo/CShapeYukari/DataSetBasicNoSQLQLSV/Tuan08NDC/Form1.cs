using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace Tuan08NDC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void btn_them_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=F73-24;Initial Catalog=QLSV;Integrated Security=True");
            conn.Open();

            SqlCommand truyvan = new SqlCommand("THEMSINHVIEN, conn");
            truyvan.CommandType = CommandType.StoredProcedure;
            truyvan.Parameters.AddWithValue("@masv", txt_masv.Text);
            truyvan.Parameters.AddWithValue("@hoten", txt_hoten.Text);
            truyvan.Parameters.AddWithValue("@ngsinh", dtp_ngaysinh.Value);
            truyvan.Parameters.AddWithValue("@phai", rd_nam.Checked ? 1 : 0);
            truyvan.Parameters.AddWithValue("@diemtb", txt_diemtb.Text);

            int SoDong = truyvan.ExecuteNonQuery();
            if(SoDong > 0)
            {
                MessageBox.Show(" Bạn đã thêm thành công ", " Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(" Bạn đã thêm thất bại ", " Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        //public List<SinhVien> LayDS()
        //{
        //    SqlConnection ketnoi = new SqlConnection("Data Source=F73-24;Initial Catalog=QLSV;Integrated Security=True");
        //    ketnoi.Open();

        //    string TruyVan = "SELECT * FROM SINHVIEN";
        //    SqlCommand command = new SqlCommand(TruyVan, ketnoi);

        //    SqlDataReader dr = command.ExecuteReader();

        //    //List<SinhVien> DANHSACHSINHVIEN = new List<SinhVien>();
        //    while (dr.Read())
        //    {
        //        SinhVien sv = new SinhVien();
        //        if (!dr.IsDBNull(0))
        //            sv.MSSV = dr.GetString(0);
        //        if (!dr.IsDBNull(1))
        //            sv.HOTEN = dr.GetString(1);
        //        if (!dr.IsDBNull(2))
        //            sv.NGSINH = dr.GetDateTime(2);
        //        if (!dr.IsDBNull(3))
        //            sv.PHAI = dr.GetBoolean(3);
        //        if (!dr.IsDBNull(4))
        //            sv.DIEMTB = dr.GetDouble(4);

        //        DANHSACHSINHVIEN.Add(sv);
        //    }
        //    dr.Close();
        //    ketnoi.Close();

        //    return DANHSACHSINHVIEN;
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            //this.sINHVIENTableAdapter.Fill(this.qLSVDataSet.SINHVIEN);
            //dgv_danhsachsv.DataSource = LayDS();
        }


    }
}
