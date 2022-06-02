using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT
{
    public class CRUD_GV
    {
        private String ID;
        private String ho;
        private String ten;
        private String hocvi;
        private String makhoa;

        public CRUD_GV(string iD, string ho, string ten, string hocvi, string makhoa)
        {
            this.ID = iD;
            this.ho = ho;
            this.ten = ten;
            this.hocvi = hocvi;
            this.makhoa = makhoa;
        }

        public String insertGV() {
            return "insert into giaovien (magv,ho,ten,hocvi,makh) values('" + ID + "',N'" + ho + "',N'" + ten + "',N'" + hocvi + "','" + makhoa + "')";
        }

        public String updateGV() {
            return "update giaovien set ho = N'" + ho + "',ten= N'" + ten + "',hocvi= N'" + hocvi + "',makh='" + makhoa + "' where magv ='" + ID + "'";
        }
        
        public String deleteGV() {        
            return "delete from giaovien where magv = '" + ID + "'";
        }

        public String searchGV() {
            return "select * from giaovien where magv='" + ID + "'";
        }

    }
}
