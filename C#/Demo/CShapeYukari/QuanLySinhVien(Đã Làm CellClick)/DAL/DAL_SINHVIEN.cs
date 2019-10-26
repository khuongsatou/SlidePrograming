using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BEL;
namespace DAL
{
    public class DAL_SINHVIEN :General
    {
        public DataTable LoadDSSV()
        {
            if (ConnectionState.Closed == connect.State)
            {
                connect.Open();
            }
            SqlCommand command = new SqlCommand("select MaSV,HoTen,NgaySinh,GioiTinh,DiaChi,TenLop from SINHVIEN,LOPHOC where SINHVIEN.MaLop = LOPHOC.MaLop", connect);
            try
            {
                SqlDataReader rd = command.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch (Exception err)
            {
                return null;
            }
            finally
            {
                connect.Close();
            }
        }
        public bool AddSV(SINHVIEN sv)
        {
            bool kq = false;
            try
            {
                if (ConnectionState.Closed == connect.State)
                {
                    connect.Open();
                }



                SqlCommand cmd = new SqlCommand("INSERT INTO SINHVIEN VALUES('" + sv.masv + "',N'" + sv.hoten + "','" + sv.ngaysinh + "',N'" + sv.gioitinh + "',N'" + sv.diachi + "','" + sv.malop + "')", connect);
                if(cmd.ExecuteNonQuery()>0)
                {
                    kq = true;
                }
            }
            catch(Exception err)
            {
            }
            finally
            {
                connect.Close();
            }
            return kq;
        }
        public DataTable LaySVTheoMa(string MaSV)
        {
            if (ConnectionState.Closed == connect.State)
            {
                connect.Open();
            }
            string sql = "select MaSV,HoTen,NgaySinh,GioiTinh,DiaChi,TenLop from SINHVIEN,LOPHOC where SINHVIEN.MaLop = LOPHOC.MaLop and SINHVIEN.MaSV='" + MaSV + "'";
            SqlCommand command = new SqlCommand(sql, connect); 
            try
            {
                SqlDataReader rd = command.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch (Exception err)
            {
                return null;
            }
            finally
            {
                connect.Close();
            }
        }

        public bool XoaSVTheoMa(string MaSV)
        {
            bool kq = false;
            try
            {
                if (ConnectionState.Closed == connect.State)
                {
                    connect.Open();
                }
                string sql="DELETE FROM SINHVIEN WHERE MaSV='" + MaSV + "'";
                SqlCommand cmd = new SqlCommand(sql, connect);
                if (cmd.ExecuteNonQuery() > 0)
                {                    
                    kq = true;
                }
            }
            catch (Exception err)
            {
            }
            finally
            {
                connect.Close();
            }
            return kq;
        }

        public bool UpdateSV(SINHVIEN sv)
        {
            bool kq = false;
            try
            {
                if (ConnectionState.Closed == connect.State)
                {
                    connect.Open();
                }
                string sql = "update SINHVIEN set HoTen=N'" + sv.hoten + "',NgaySinh='" + sv.ngaysinh + "',GioiTinh=N'" + sv.gioitinh + "',DiaChi=N'" + sv.diachi + "',MaLop='" + sv.malop + "' where MaSV='" + sv.masv + "'";
                SqlCommand cmd = new SqlCommand(sql, connect);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    kq = true;
                }
            }
            catch (Exception err)
            {
            }
            finally
            {
                connect.Close();
            }
            return kq;
        }
    }
}
