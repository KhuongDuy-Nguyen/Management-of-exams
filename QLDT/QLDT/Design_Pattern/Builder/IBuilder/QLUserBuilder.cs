using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT
{
    public class QLUserBuilder : IQLUserBuilder
    {
        public string masv { get; set; }
        public string tenlop { get; set; }

        public string ho { get; set; }

        public string ten { get; set; }

        public string ngaysinh { get; set; }

        public string diachi { get; set; }

        public string malop { get; set; }

        public string magv { get; set; }
        public string hocvi { get; set; }
        public string makh { get; set; }

        public QLUserBuilder AddDiachi(string diachi)
        {
            this.diachi = diachi;
            return this;
        }

        public QLUserBuilder AddHo(string ho)
        {
            this.ho = ho;
            return this;
        }

        public QLUserBuilder AddHocvi(string hocvi)
        {
            this.hocvi = hocvi;
            return this;
        }

        public QLUserBuilder AddMagv(string magv)
        {
            this.magv = magv;
            return this;
        }

        public QLUserBuilder AddMakh(string makh)
        {
            this.makh = makh;
            return this;
        }

        public QLUserBuilder AddMalop(string malop)
        {
            this.malop = malop;
            return this;
        }

        public QLUserBuilder AddMasv(string masv)
        {
            this.masv = masv;
            return this;
        }

        public QLUserBuilder AddNgaysinh(string ngaysinh)
        {
            this.ngaysinh = ngaysinh;
            return this;
        }

        public QLUserBuilder AddTen(string ten)
        {
            this.ten = ten;
            return this;
        }

        public Giaovien BuildGiaovien()
        {
            return new Giaovien(magv, ho, ten, hocvi, makh);
        }

        public Sinhvien BuildSinhvien()
        {
            return new Sinhvien(masv, ho, ten, ngaysinh, diachi, malop);
        }
    }
}
