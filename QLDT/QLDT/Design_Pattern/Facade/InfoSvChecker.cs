using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDT.Design_Pattern.Facade
{
    public class InfoSvChecker
    {
        DateTimePicker datetimepicker = new DateTimePicker();
        Sinhvien sv;
        public InfoSvChecker(Sinhvien sv)
        {
            this.sv = sv;
        }
        public bool isValid()
        {
            DateTime t = new DateTime(2010, 1, 1);

            datetimepicker.Value = DateTime.Parse(sv.ngaysinh);
            if (String.IsNullOrEmpty(sv.ngaysinh))
            {
                MessageBox.Show("Vui lòng chọn ngày sinh cho sinh viên để trống !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(sv.masv))
            {
                MessageBox.Show("ID của sinh viên không được phép để trống !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (checkMaSV(sv.masv).Equals(false))
            {
                MessageBox.Show("ID của sinh viên đã tồn tại trong hệ thống !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (sv.masv.Length > 8)
            {
                MessageBox.Show("ID của sinh viên không được phép quá 8 kí tự !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrEmpty(sv.malop))
            {
                MessageBox.Show("Mã lớp sinh viên không được phép để trống !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (sv.malop.Length > 8)
            {
                MessageBox.Show("Mã lớp sinh viên không được phép quá 8 kí tự !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (checkMalop(sv.malop).Equals(false))
            {
                MessageBox.Show("Mã lớp của sinh viên không tồn tại trong hệ thống !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrEmpty(sv.ho))
            {
                MessageBox.Show("Họ sinh viên không được phép để trống !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (sv.ho.Any(char.IsDigit))
            {
                MessageBox.Show("Họ sinh viên không được phép chứa số kí tự !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrEmpty(sv.ten))
            {
                MessageBox.Show("Tên sinh viên không được phép để trống !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (sv.ten.Any(char.IsDigit))
            {
                MessageBox.Show("Tên sinh viên không được phép chứa số kí tự !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (datetimepicker.Value.CompareTo(t) == 1)
            {
                MessageBox.Show("Bạn vui lòng chọn ngày sinh đúng cho sinh viên <-- 01/01/2010 !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            else if (string.IsNullOrEmpty(sv.diachi))
            {
                MessageBox.Show("Địa chỉ sinh viên không được phép để trống !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public bool checkMalop(string malop)
        {
            SqlConnection con = SqlSingleton.GetInstance("").ConnectionInstance();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from dbo.lop where malop = '" + malop + "'";
            String str = (string)cmd.ExecuteScalar();
            if (String.IsNullOrEmpty(str))
            {
                return false;
            }
            return true;
        }
        public bool checkMaSV(string masv)
        {
            SqlConnection con = SqlSingleton.GetInstance("").ConnectionInstance();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from dbo.sinhvien where masv = '" + masv + "'";
            String str = (string)cmd.ExecuteScalar();
            if (!String.IsNullOrEmpty(str))
            {
                return false;
            }
            return true;
        }
    }
}
