using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuan05_C
{
    class HocSinh
    {
        private int _ma;
        private string _name;
        private DateTime _ngaysinh;
        private string _dchi;
        private int _diemToan;
        private int _diemVan;
        private int _diemTB;
        private string _xepLoai;

        public int ma
        {
            get{return _ma;}
            set {_ma = value;}
        }
        public string name
        {
            get{return _name;}
            set{_name = value;}
        }
        public DateTime ngaysinh
        {
            get{return _ngaysinh;}
            set{_ngaysinh = value;}
        }
         public string dchi
         {
            get{return _dchi;}
            set{_dchi = value;}
        }
        public int diemToan
        {
            get{return _diemToan;}
            set{_diemToan = value;}
        }
        public int diemVan
        {
            get{return _diemVan;}
            set{_diemVan = value;}
        }
        public HocSinh()
        {
            _ma = 0;
            _name = "";
            _ngaysinh = DateTime.Now;
            _dchi = "";
            _diemToan = 0;
            _diemVan = 0;
        }
        public HocSinh(int mahs,string ten, string diachi, DateTime ngsinh, int toan, int van)
        {
            _ma = mahs;
            _name = ten;
            _dchi = diachi;
            _ngaysinh = ngsinh;
            _diemToan = toan;
            _diemVan = van;
        }
        public int diemTB()
        {
            return (_diemToan + _diemVan) / 2;
        }
        public string xepLoai()
        {
            string kq = "";
            if (diemTB() < 3.5)
                kq = "Yếu";
            else if (diemTB() < 5.0)
                kq = "Trung Bình";
            else if (diemTB() < 8)
                kq = "Khá";
            else kq = "Giỏi";
            return kq;
        }
    }

}
