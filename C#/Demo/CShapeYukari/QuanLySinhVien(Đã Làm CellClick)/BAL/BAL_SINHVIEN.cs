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
    public class BAL_SINHVIEN
    {
        public DataTable getDanhSachSinhVien()
        {
            try
            {
                DAL_SINHVIEN objdal = new DAL_SINHVIEN();
                return objdal.LoadDSSV();
            }
            catch (Exception err)
            {
                return null;
            }
        }
        public bool ThemSV(SINHVIEN sv)
        {
            try
            {
                DAL_SINHVIEN objdal = new DAL_SINHVIEN();
                return objdal.AddSV(sv);
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public DataTable LaySVTheoMa(string MaSV)
        {
            try
            {
                DAL_SINHVIEN objdal = new DAL_SINHVIEN();
                return objdal.LaySVTheoMa(MaSV);
            }
            catch (Exception err)
            {
                return null;
            }
        }

        public bool XoaSVTheoMa(string MaSV)
        {
            try
            {
                DAL_SINHVIEN objdal = new DAL_SINHVIEN();
                return objdal.XoaSVTheoMa(MaSV);
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public bool UpdateSV(SINHVIEN sv)
        {
            try
            {
                DAL_SINHVIEN objdal = new DAL_SINHVIEN();
                return objdal.UpdateSV(sv);
            }
            catch (Exception err)
            {
                throw;
            }
        }

    }
}
