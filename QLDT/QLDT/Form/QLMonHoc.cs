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
namespace QLDT
{
    public partial class QLMonHoc : Form
    {
        public QLMonHoc(string id)
        {
            InitializeComponent();
            txtBasis.Text = id;
        }

        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        private void lstCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void QLMonHoc_Load(object sender, EventArgs e)
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
        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from monhoc";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataView.DataSource = table;

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" & txtName.Text != "" & txtBasis.Text != "")
            {
                command = connection.CreateCommand();
                command.CommandText = "insert into monhoc (mamh,tenmh) values('" + txtID.Text + "',N'" + txtName.Text  + "')";
                command.ExecuteNonQuery();
                loadData();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }


        }

        private void txtDegree_TextChanged(object sender, EventArgs e)
        {

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from monhoc where mamh = '" + txtID.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update monhoc set mamh = '" + txtID.Text + "',tenmh= N'" + txtName.Text + "' where mamh ='" + txtID.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            loadData();
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

        private void dataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataView.CurrentRow.Index;
            txtID.Text = dataView.Rows[i].Cells[0].Value.ToString();
            txtName.Text = dataView.Rows[i].Cells[1].Value.ToString();
        }
    }
}
