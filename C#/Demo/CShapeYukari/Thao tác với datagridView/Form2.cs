using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AccessDB
{
    public partial class Form2 : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader dr;
        public Form2()
        {
            InitializeComponent();
        }

      
        private void Form2_Load(object sender, EventArgs e)
        {
            //kết nối
            con.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=SINHVIEN.mdb";
            cmd.Connection = con;
            string sql = "SELECT * FROM SinhVien";
            ThuThiTruyVan(sql);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void ThuThiTruyVan(string sql)
        {
            string mssv = "";
            string hoten = "";
            string diachi = "";
            string tenlop = "";
            try
            {
                //mở lỗ
                con.Open();
                cmd.CommandText = sql;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        mssv = dr[0].ToString();
                        hoten = dr[1].ToString();
                        diachi = dr[2].ToString();
                        tenlop = dr[3].ToString();
                        dgvDanhSachSV.Rows.Add(mssv, hoten, diachi, tenlop);
                    }
                }
                dr.Close();
                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "ERROR"); 
               
            }
        }

       
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.N = comboBox1.Text;
            frm3.ShowDialog();

        }


    }
}
