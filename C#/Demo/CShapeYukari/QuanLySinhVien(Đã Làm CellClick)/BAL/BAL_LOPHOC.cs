using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using BEL;
namespace BAL
{
    public class BAL_LOPHOC
    {
        public DataTable getDSLOP()
        {
            try
            {
                DAL_LOPHOC objdal = new DAL_LOPHOC();
                return objdal.LoadLop();
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable LayMaLop(string tenLop)
        {
            try
            {
                DAL_LOPHOC objdal = new DAL_LOPHOC();
                return objdal.LayMaLop(tenLop);
            }
            catch (Exception err)
            {
                return null ;
            }
        }
    }
}
