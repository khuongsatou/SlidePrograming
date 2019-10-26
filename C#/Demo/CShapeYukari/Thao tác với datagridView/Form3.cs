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
    public partial class Form3 : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader dr;

        private string _n;

        public string N
        {
            get { return _n; }
            set { _n = value; }
        }
        
        public Form3()
        {
            InitializeComponent();
        }

        private void XemDanhSachLop_Click(object sender, EventArgs e)
        {
            //kết nối

            string sql = "SELECT lop.malop,hoten,diachi,tenlop FROM lop,sinhvien where  lop.malop=sinhvien.malop and lop.MaLop ='" + _n.ToString() + "'";
            ThuThiTruyVan(sql);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=SINHVIEN.mdb";
            cmd.Connection = con;
        }

        private void ThuThiTruyVan(string sql)
        {
            string malop = "";
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
                        malop = dr[0].ToString();
                        hoten = dr[1].ToString();
                        diachi = dr[2].ToString();
                        tenlop = dr[3].ToString();
                        
                        dgvDanhSachLop.Rows.Add(malop,hoten,diachi, tenlop);
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

       
    }
}
