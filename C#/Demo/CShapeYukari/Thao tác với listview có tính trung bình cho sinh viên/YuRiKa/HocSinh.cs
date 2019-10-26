using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuRiKa
{
    class HocSinh
    {
        //private int _mahs;
        //private string _hoten;
        //private DateTime _ngaysinh;
        //private string _diachi;
        //private int _diemtoan;
        //private int _diemvan;

        //public int MaHS { get; set; }
        //public string HoTen { get; set; }
        //public DateTime NgaySinh  { get; set; }
        //public string DiaChi { get; set; }
        //public int DiemToan { get; set; }
        //public int DiemVan { get; set; }

        private int _mahs;

        public int MaHS
        {
            get { return _mahs; }
            set { _mahs = value; }
        }

        private string _hoten;

        public string HoTen
        {
            get { return _hoten; }
            set { _hoten = value; }
        }

        private DateTime _ngaysinh;

        public DateTime NgaySinh
        {
            get { return _ngaysinh; }
            set { _ngaysinh = value; }
        }

        private string _diachi;

        public string DiaChi
        {
            get { return _diachi; }
            set { _diachi = value; }
        }
        private float _diemtoan;

        public float DiemToan
        {
            get { return _diemtoan; }
            set { _diemtoan = value; }
        }

        private float _diemvan;

        public float DiemVan
        {
            get { return _diemvan; }
            set { _diemvan = value; }
        }
        
        
        
        public HocSinh()
        {
            this._mahs = 0;
            this._hoten = "";
            this._ngaysinh = System.DateTime.Now;//ngày hiện tại
            this._diemtoan = 0;
            this._diemvan = 0;
        }

        public HocSinh(int MaHS, string HoTen, DateTime NgaySinh, string DiaChi, float DiemToan, float DiemVan)
        {
            this._mahs = MaHS;
            this._hoten = HoTen;
            this._ngaysinh = NgaySinh;
            this._diachi = DiaChi;
            this._diemtoan = DiemToan;
            this._diemvan = DiemVan;
        }


        public double TinhDTB()
        {
            return (double)(_diemtoan+_diemvan)/2;
        }
        public string TinhXepLoai()
        {
            if (TinhDTB()>=5)
            {
                return "Đậu";
            }
            return "Rớt";
        }
        
     }
       
}
