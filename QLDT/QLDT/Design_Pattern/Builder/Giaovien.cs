using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT
{
    public class Giaovien
    {
        public Giaovien(string magv, string ho, string ten, string hocvi, string makh)
        {
            this.magv = magv;
            this.ho = ho;
            this.ten = ten;
            this.hocvi = hocvi;
            this.makh = makh;
        }

        //Các parameters của Giao vien
        public string magv { get; set; }

        public string ho { get; set; }

        public string ten { get; set; }

        public string hocvi { get; set; }
        public string makh { get; set; }
    }
}
