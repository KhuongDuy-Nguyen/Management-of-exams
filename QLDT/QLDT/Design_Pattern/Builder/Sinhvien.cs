using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT
{
    public class Sinhvien
    {
        public Sinhvien(String masv, string ho, string ten, string ngaysinh, string diachi, string malop)
        {
            this.masv = masv;
            this.ho = ho;
            this.ten = ten;
            this.ngaysinh = ngaysinh;
            this.diachi = diachi;
            this.malop = malop;
        }

        //Các parameters của Sinhvien
        public string masv { get; set; }

        public string ho { get; set; }

        public string ten { get; set; }

        public string ngaysinh { get; set; }

        public string diachi { get; set; }

        public string malop { get; set; }

    }
}
