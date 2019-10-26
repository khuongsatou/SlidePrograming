using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DAL_LOPHOC : General
    {
        public DataTable LoadLop()
        {
            if (ConnectionState.Closed == connect.State)
            {
                connect.Open();
            }
            SqlCommand command = new SqlCommand("select MaLop,TenLop from LOPHOC", connect);
            try
            {
                SqlDataReader rd = command.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch (Exception err)
            {
                throw;
            }
            finally
            {
                connect.Close();
            }
        }
        public DataTable LayMaLop(string tenLop)
        {
            if (ConnectionState.Closed == connect.State)
            {
                connect.Open();
            }
            SqlCommand command = new SqlCommand("select MaLop from LOPHOC where TenLop='"+tenLop+"'", connect);
            try
            {
                SqlDataReader rd = command.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch (Exception err)
            {
                throw;
            }
            finally
            {
                connect.Close();
            }
        }
    }
}
