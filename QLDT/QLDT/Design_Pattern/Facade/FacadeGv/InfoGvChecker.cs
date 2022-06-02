using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDT.Design_Pattern.Facade.FacadeGv
{
    public class InfoGvChecker
    {
        Giaovien gv;

        public InfoGvChecker(Giaovien gv)
        {
            this.gv = gv;
        }
        public bool isValid()
        {
            if (String.IsNullOrEmpty(gv.magv))
            {
                MessageBox.Show("Mã giáo viên không được phép để trống !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (gv.magv.Length > 8)
            {
                MessageBox.Show("Mã giáo viên không được phép chứa quá 8 kí tự !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (checkMaGv(gv.magv).Equals(false))
            {
                MessageBox.Show("Mã giáo viên đã tồn tại trong hệ thống !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (String.IsNullOrEmpty(gv.ho))
            {
                MessageBox.Show("Họ giáo viên không phép để trống !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (String.IsNullOrEmpty(gv.ten))
            {
                MessageBox.Show("Tên giáo viên không được phép để trống  !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (gv.ten.Length > 10)
            {
                MessageBox.Show("Tên giáo viên không phép chứa quá 10 kí tự !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (String.IsNullOrEmpty(gv.hocvi))
            {
                MessageBox.Show("Vui lòng nhập học vị cho giáo viên !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (String.IsNullOrEmpty(gv.makh))
            {
                MessageBox.Show("Vui lòng nhập mã khoa cho giáo viên !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (checkMakhoa(gv.makh).Equals(false))
            {
                MessageBox.Show("Mã khoa của giáo viên không tồn tại trong hệ thống !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        public bool checkMakhoa(String makh)
        {

            SqlConnection con = SqlSingleton.GetInstance("").ConnectionInstance();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from dbo.khoa where makh = '" + makh + "'";
            String str = (string)cmd.ExecuteScalar();
            if (String.IsNullOrEmpty(str))
            {
                return false;
            }
            return true;
        }
        public bool checkMaGv(String magv)
        {
            SqlConnection con = SqlSingleton.GetInstance("").ConnectionInstance();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from dbo.giaovien where magv = '" + magv + "'";
            String str = (string)cmd.ExecuteScalar();
            if (!String.IsNullOrEmpty(str))
            {
                return false;
            }
            return true;
        }
    }
}
