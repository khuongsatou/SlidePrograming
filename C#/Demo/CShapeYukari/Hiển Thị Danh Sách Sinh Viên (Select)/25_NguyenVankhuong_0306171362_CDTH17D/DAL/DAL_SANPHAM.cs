using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DAL_SANPHAM:GENNERAL
    {
        public DataTable Select_SP()
        {
            try
            {
                getConnect();
                string sql = "select SanPham.MaSanPham,SanPham.TenSanPham,NhaSanXuat.TenNhaSanXuat,SanPham.ThongSoKyThuat,SanPham.GiaBan,SanPham.BaoHanh from NhaSanXuat,SanPham where NhaSanXuat.MaNhaSanXuat=SanPham.MaNhaSanXuat";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
                throw;
            }

        }
    }
}
