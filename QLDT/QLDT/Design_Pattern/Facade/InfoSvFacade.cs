using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDT.Design_Pattern.Facade
{
    public class InfoSvFacade
    {
        private string cs;
        private Sinhvien sv;

        InfoSvChecker infoCheck;

        public InfoSvFacade(string cs, Sinhvien sv)
        {
            this.cs = cs;
            this.sv = sv;
            this.infoCheck = new InfoSvChecker(sv);
        }

        public bool InsertSv()
        {
            if (infoCheck.isValid())
            {
                loadCommandData("insert", sv);
                MessageBox.Show("Thêm thành công sinh viên !!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
        public bool UpdateSv()
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn cập nhật thông tin sinh viên có mã SV: " + sv.masv, "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                loadCommandData("update", sv);
                MessageBox.Show("Update thông tin sinh viên thành công !!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
        public void DeleteSV()
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa thông tin sinh viên có mã SV: " + sv.masv, "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                loadCommandData("delete", sv);
                MessageBox.Show("Xóa thông tin sinh viên có mã số SV:" + sv.masv + " thành công !!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void loadCommandData(string com, Sinhvien sv)
        {
            SqlConnection con = SqlSingleton.GetInstance(cs).ConnectionInstance();
            con.Open();
            SqlCommand command = con.CreateCommand();

            CRUD_SV crud = new CRUD_SV(sv.masv, sv.ho, sv.ten, sv.ngaysinh, sv.diachi, sv.malop);
            Command insert = new Create_SV(crud);
            Command delete = new Delete_SV(crud);
            Command update = new Update_SV(crud);
            Command search = new Search_SV(crud);

            Command_SV cmd = new Command_SV(insert, update, delete, search);

            if (com == "insert")
                command.CommandText = cmd.insert();
            else if (com == "delete")
                command.CommandText = cmd.delete();
            else if (com == "update")
                command.CommandText = cmd.update();
            else if (com == "search")
                command.CommandText = cmd.search();

            command.ExecuteNonQuery();

        }
    }
}
