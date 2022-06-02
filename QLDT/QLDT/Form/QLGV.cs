using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLDT;     //goi file serverConnection

using QLDT.Design_Pattern.Facade.FacadeGv;
namespace QLDT
{
    
    public partial class QLGV : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        
        public QLGV(string basis)
        {
            InitializeComponent();
            txtBasis.Text = basis;
        }
        
        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from giaovien";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataView.DataSource = table;

        }
        
        private void QLGV_Load(object sender, EventArgs e)
        {
            //truyen data basis de ket noi server tuong ung
            connection = SqlSingleton.GetInstance(txtBasis.Text).ConnectionInstance();
            try
            {
                connection.Open();
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra trong kết nối db: " + ex);
            }

        }

        public Giaovien getGv()
        {

            return new QLUserBuilder()
                                   .AddMagv(txtID.Text)
                                   .AddHo(txtHo.Text)
                                   .AddTen(txtTen.Text)
                                   .AddHocvi(txtDegree.Text)
                                   .AddMakh(txtFaculty.Text)
                                   .BuildGiaovien();
        }

        private void dataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataView.CurrentRow.Index;
            txtID.Text = dataView.Rows[i].Cells[0].Value.ToString();
            txtHo.Text = dataView.Rows[i].Cells[1].Value.ToString();
            txtTen.Text = dataView.Rows[i].Cells[2].Value.ToString();
            txtDegree.Text = dataView.Rows[i].Cells[3].Value.ToString();
            txtFaculty.Text = dataView.Rows[i].Cells[4].Value.ToString();
            txtID.Enabled = false;
            btAdd.Enabled = false;
            btEdit.Enabled = true;
            btDelete.Enabled = true;
            SetEditingMode(true);
        }

        private void loadCommandData(String com)
        {
            command = connection.CreateCommand();
            Giaovien gv = new QLUserBuilder()
                                       .AddMagv(txtID.Text)
                                       .AddHo(txtHo.Text)
                                       .AddTen(txtTen.Text)
                                       .AddHocvi(txtDegree.Text)
                                       .AddMakh(txtFaculty.Text)
                                       .BuildGiaovien();

            CRUD_GV crud = new CRUD_GV(gv.magv , gv.ho , gv.ten , gv.hocvi , gv.makh);

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
            loadData();

        }
        

        private void btAdd_Click(object sender, EventArgs e)
        {
            Giaovien gv = getGv();
            InfoGvFacade facadeGv = new InfoGvFacade(txtBasis.Text, gv);
            if (facadeGv.InsertGv())
            {
                clearInfo();
            }


        }

        private void txtDegree_TextChanged(object sender, EventArgs e)
        {

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            Giaovien gv = getGv();
            InfoGvFacade facadeGv = new InfoGvFacade(txtBasis.Text, gv);
            facadeGv.DeleteSv();
            clearInfo();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            Giaovien gv = getGv();
            InfoGvFacade facadeGv = new InfoGvFacade(txtBasis.Text, gv);
            facadeGv.UpdateSv();
            clearInfo();
        }

        public void clearInfo()
        {
            txtID.Text = "";
            txtHo.Text = "";
            txtTen.Text = "";
            txtDegree.Text = "";
            txtFaculty.Text = "";
            txtID.Enabled = true;
            btAdd.Enabled = true;
            btEdit.Enabled = false;
            btDelete.Enabled = false;
            loadData();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            clearInfo();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from giaovien where magv='" + txtSearchID.Text +"'";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataView.DataSource = table;
        }
        private void SetEditingMode(bool enable)
        {
            if (!enable)
            {
                dataView.ClearSelection();
            }
            btAdd.Enabled = !enable;
            btReset.Enabled = true;
            btDelete.Enabled = enable;
            btEdit.Enabled = enable;
        }

        

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
