using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class SINHVIEN
    {
        string _masv;
        string _hoten;
        DateTime _ngaysinh;
        string _gioitinh;
        string _diachi;
        string _malop;
        public SINHVIEN()
        {
            _masv = "";
            _hoten = "";
            _ngaysinh = DateTime.Parse("1/1/2019");
            _diachi = "";
            _malop = "";
        }
        public SINHVIEN(string ma, string hoten, DateTime ngaysinh, string gioitinh, string diachi, string malop)
        {
            this._masv = ma;
            this._hoten = hoten;
            this._gioitinh = gioitinh;
            this._ngaysinh = ngaysinh;
            this._diachi = diachi;
            this._malop = malop;
        }
        public string masv
        {
            get { return _masv; }
            set { _masv = value; }
        }
        public string hoten
        {
            get { return _hoten; }
            set { _hoten = value; }
        }
        public string gioitinh
        {
            get { return _gioitinh; }
            set { _gioitinh = value; }
        }
        public DateTime ngaysinh
        {
            get { return _ngaysinh; }
            set { _ngaysinh = value; }
        }
        public string diachi
        {
            get { return _diachi; }
            set { _diachi = value; }
        }
        public string malop
        {
            get { return _malop; }
            set { _malop = value; }
        }
    }
}
