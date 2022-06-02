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
namespace QLDT
{
    public partial class LichSuThi : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loadData(string auth, string name)
        {
            command = connection.CreateCommand();
            if (auth == "5")
            {
                command.CommandText = "select * from bangdiem where masv = '" + name + "'";
                Option.Visible = false;
            }
            else
            {
                command.CommandText = "select * from bangdiem";
            }
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataView.DataSource = table;

        }
        public LichSuThi(string auth, string name)
        {
            InitializeComponent();
            txtAuth.Text = auth;
            txtName.Text = name;
        }

        private void dataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LichSuThi_Load(object sender, EventArgs e)
        {
            //truyen data basis de ket noi server tuong ung
            connection = SqlSingleton.GetInstance("main").ConnectionInstance();
            try
            {
                connection.Open();
                loadData(txtAuth.Text, txtName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra trong kết nối db: " + ex);
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from bangdiem where masv ='" + txtSearchID_Student.Text + "'";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataView.DataSource = table;
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txtSearchID_Student.Text = "";
            loadData(txtAuth.Text,txtName.Text);
        }
    }
}
