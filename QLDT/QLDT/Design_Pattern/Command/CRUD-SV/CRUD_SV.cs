using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT
{
    public class CRUD_SV
    {
        private String ID;
        private String ho;
        private String ten;
        private String ngaysinh;
        private String diachi;
        private String malop;

        public CRUD_SV(string iD, string ho, string ten, string ngaysinh, string diachi, string malop)
        {
            this.ID = iD;
            this.ho = ho;
            this.ten = ten;
            this.ngaysinh = ngaysinh;
            this.diachi = diachi;
            this.malop = malop;
        }

        public String insertSV() {
            return "insert into sinhvien (masv,ho,ten,ngaysinh,diachi,malop) values('" + ID + "',N'" + ho + "',N'" + ten + "','" + ngaysinh + "',N'" + diachi + "','" + malop + "')";
        }

        public String updateSV() {
            return "update sinhvien set ho = N'" + ho + "',ten= N'" + ten + "',ngaysinh= '" + ngaysinh + "',diachi='" + diachi + "',malop='" + malop + "' where masv ='" + ID + "'";
        }

        public String deleteSV() {
            return "delete from sinhvien where masv = '" + ID + "'";
        }

        public String searchSV() {
            return "select * from sinhvien where masv='" + ID + "'";
        }

    }
}
