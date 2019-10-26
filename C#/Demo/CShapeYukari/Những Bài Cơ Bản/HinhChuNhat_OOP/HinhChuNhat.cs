using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhChuNhat_OOP
{
    class HinhChuNhat
    {
        private double _chieudai;
        private double _chieurong;

        public double chieudai
        {
            get { return _chieudai; }
            set { _chieudai = value; }
        }
        public double chieurong
        {
            get { return _chieurong; }
            set { _chieurong = value; }
        }

        public HinhChuNhat()
        {
            this._chieudai = 0;
            this._chieurong = 0;
        }

        public HinhChuNhat(double chieudai, double chieurong)
        {
            _chieudai = chieudai;
            _chieurong = chieurong;
        }

        public double TinhChuVi()
        {
            return (_chieudai + _chieurong) * 2;
        }
        public double TinhDienTich()
        {
            return (_chieudai * _chieurong);
        }


        

    }
}
