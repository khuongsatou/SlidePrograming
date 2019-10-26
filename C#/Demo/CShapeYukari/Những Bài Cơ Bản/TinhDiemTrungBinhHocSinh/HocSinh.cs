using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhDiemTrungBinhHocSinh
{
    class HocSinh
    {
        private string _ten;
        private double _toan;
        private double _van;
        private string _loai;

        public string Ten{
            get { return _ten; }
            set { _ten = value; }
        }

        public double DiemToan
        {
            get { return _toan; }
            set { _toan = value; }
        }
        public double DiemVan
        {
            get { return _van; }
            set { _van = value; }
        }
        public string Loai
        {
            get { return _loai; }
            set { _loai = value; }
        }
        public HocSinh()
        {
            this._ten = "";
            this._toan = 0;
            this._van = 0;
            this._loai = "";


        }

        public HocSinh(string ten, double toan, double van)
        {
            this._ten = ten;
            this._toan = toan;
            this._van = van;
            
        }

        public double TinhDiemTrungBinh()
        {
            return (_toan + _van) / 2;
        }

        


    }
}
