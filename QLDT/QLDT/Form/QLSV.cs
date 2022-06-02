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
using QLDT;
using QLDT.Design_Pattern.Adapter_pattern;
using QLDT.Design_Pattern.Facade;

namespace QLDT
{
    public partial class QLSV : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public QLSV(string basis)
        {
            InitializeComponent();
            txtBasis.Text = basis;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from sinhvien";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataView.DataSource = table;
        }

        private void QLSV_Load(object sender, EventArgs e)
        {
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

        private void loadCommandData(String com) {

            string date = txtDate.Value.ToString("yyyy/MM/dd hh:mm:ss");
            command = connection.CreateCommand();            
            
            Sinhvien sv = new QLUserBuilder()
                                    .AddHo(txtHo.Text)
                                    .AddTen(txtTen.Text)
                                    .AddNgaysinh(date)
                                    .AddMasv(txtID.Text)
                                    .AddMalop(txtClass.Text)
                                    .AddDiachi(txtAddress.Text)
                                    .BuildSinhvien();

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
            loadData();

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Sinhvien sv = getSv();
            InfoSvFacade facade = new InfoSvFacade(txtBasis.Text, sv);
            if (facade.InsertSv())
            {
                ClearInfo();
            }

        }

        public Sinhvien getSv()
        {
            string date = txtDate.Value.ToString("yyyy/MM/dd hh:mm:ss");
            return new QLUserBuilder()
                                 .AddHo(txtHo.Text)
                                 .AddTen(txtTen.Text)
                                 .AddNgaysinh(date)
                                 .AddMasv(txtID.Text)
                                 .AddMalop(txtClass.Text)
                                 .AddDiachi(txtAddress.Text)
                                 .BuildSinhvien();
        }
        public void ClearInfo()
        {
            txtID.Text = "";
            txtHo.Text = "";
            txtTen.Text = "";
            txtDate.Text = "";
            txtAddress.Text = "";
            txtClass.Text = "";
            txtID.Enabled = true;
            btAdd.Enabled = true;
            btEdit.Enabled = false;
            btDelete.Enabled = false;
           
            loadData();
        }


        private void dataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Enabled = false;

            btAdd.Enabled = false;
            btEdit.Enabled = true;
            btDelete.Enabled = true;
            int i;
            i = dataView.CurrentRow.Index;
            txtID.Text = dataView.Rows[i].Cells[0].Value.ToString();
            txtHo.Text = dataView.Rows[i].Cells[1].Value.ToString();
            txtTen.Text = dataView.Rows[i].Cells[2].Value.ToString();
            txtDate.Text = dataView.Rows[i].Cells[3].Value.ToString();
            txtAddress.Text = dataView.Rows[i].Cells[4].Value.ToString();
            txtClass.Text = dataView.Rows[i].Cells[5].Value.ToString();
            SetEditingMode(true);

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

        private void btDelete_Click(object sender, EventArgs e)
        {
            Sinhvien sv = getSv();
            InfoSvFacade facade = new InfoSvFacade(txtBasis.Text, sv);
            facade.DeleteSV();
            ClearInfo();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            //Update Sinhvien
            Sinhvien sv = getSv();
            InfoSvFacade facade = new InfoSvFacade(txtBasis.Text, sv);
            if (facade.UpdateSv())
            {
                ClearInfo();
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            ClearInfo();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            
                command = connection.CreateCommand();
                command.CommandText = "select * from sinhvien where masv='" + txtSearchID.Text + "'";
                command.ExecuteNonQuery();
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dataView.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtID.Text) && !String.IsNullOrEmpty(txtHo.Text))
            {
                //Khởi tạo giá trị cho lớp Sinh viên
                Sinhvien sv = new Sinhvien(txtID.Text, txtHo.Text, txtTen.Text, txtDate.Text, txtAddress.Text, txtClass.Text);


                //Truyền dữ liệu cần in trên form thông tin Sinh viên (PrintSv)
                PrintSV frmPrintSv = new PrintSV(txtBasis.Text, sv);

                frmPrintSv.Show();

            }
            else
            {
                MessageBox.Show("VUI LÒNG CHỌN THÔNG TIN SINH VIÊN ĐỂ IN", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void txtDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
