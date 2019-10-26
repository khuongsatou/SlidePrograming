using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuan05_C
{
    class LopHoc
    {
        private List<HocSinh> dsHS = new List<HocSinh>();
        public List<HocSinh> DSHS
        {
            get { return dsHS; }
            set { dsHS = value; }
        }
        public void Them(HocSinh hs)
        {
            dsHS.Add(hs);
        }
    }
}
