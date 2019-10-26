using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class LOPHOC
    {
        string _malop;
        string _tenlop;
         public LOPHOC()
        {
            _malop = "";
            _tenlop = "";
        }
        public LOPHOC(string malop, string tenlop)
        {
            this._malop = malop;
            this._tenlop = tenlop;
        }
        public string malop
        {
            get { return _malop; }
            set { _malop = value; }
        }
        public string tenlop
        {
            get { return _tenlop; }
            set { _tenlop = value; }
        }
    }
}
