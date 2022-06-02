using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDT.Design_Pattern.Facade.FacadeGv
{
    class InfoGvFacade
    {
        String cs;
        Giaovien gv;

        InfoGvChecker infoChecker;
        public InfoGvFacade(String cs, Giaovien gv)
        {
            this.cs = cs;
            this.gv = gv;

            this.infoChecker = new InfoGvChecker(gv);
        }
        public bool InsertGv()
        {
            if (infoChecker.isValid())
            {
                loadCommandData("insert", gv);
                MessageBox.Show("Thêm thành công giáo viên !!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
        public void DeleteSv()
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa thông tin giáo viên có mã Gv: " + gv.magv, "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                loadCommandData("delete", gv);
                MessageBox.Show("Xóa thông tin giáo viên có mã số Gv:" + gv.magv + " thành công !!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void UpdateSv()
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn Cập nhật thông tin giáo viên có mã Gv: " + gv.magv, "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                loadCommandData("update", gv);
                MessageBox.Show("Cập nhật thông tin giáo viên có mã số Gv:" + gv.magv + " thành công !!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void loadCommandData(String com, Giaovien gv)
        {
            SqlConnection con = SqlSingleton.GetInstance(cs).ConnectionInstance();
            con.Open();
            SqlCommand command = con.CreateCommand();


            CRUD_GV crud = new CRUD_GV(gv.magv, gv.ho, gv.ten, gv.hocvi, gv.makh);

            Command insert = new Create_GV(crud);
            Command delete = new Delete_GV(crud);
            Command update = new Update_GV(crud);
            Command search = new Search_GV(crud);
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
