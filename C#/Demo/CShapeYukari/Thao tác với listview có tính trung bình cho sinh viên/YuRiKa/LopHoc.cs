using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace YuRiKa
{
    class LopHoc
    {
        private List<HocSinh> dshs = new List<HocSinh>();

        //public List<HocSinh> DSHS{ get; set; }

        public List<HocSinh> DSHS
        {
            get { return dshs; }
            set { dshs = value; }
        }
        

        public void Them(HocSinh hs)
        {
            dshs.Add(hs);
        }
        
    }
}
