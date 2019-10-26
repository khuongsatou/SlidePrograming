using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
namespace BAL
{
    public class BAL_SANPHAM
    {
        public DataTable getSanPham()
        {
            DAL_SANPHAM objdal = new DAL_SANPHAM();
            return objdal.Select_SP();
        }

    }
}
