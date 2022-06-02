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
using QLDT.Design_Pattern.Bridge;
namespace QLDT
{
    public partial class QLLop : Form
    {
        public QLLop(string id)
        {
            InitializeComponent();
            txtBasis.Text = id;

        }
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from lop ";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataView.DataSource = table;

        }

        private void QLLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tHI_TN.lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter.Fill(this.tHI_TN.lop);
            // TODO: This line of code loads data into the 'tHI_TN.khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter.Fill(this.tHI_TN.khoa);
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

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (lstKhoa.Text != "" & txtID.Text != "" & txtName.Text != "")
            {
                String value = txtID.Text + "',N'" + txtName.Text + "','" + lstKhoa.Text;
                String column = "malop,tenlop,makh";
                HeThong bridgeQLLop = new BridgeQLLop(new Create("lop", column, value));

                Console.WriteLine(bridgeQLLop.insert());

                try {
                    command = connection.CreateCommand();
                    command.CommandText = bridgeQLLop.insert();
                    command.ExecuteNonQuery();
                    loadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra trong kết nối db: " + ex);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }


        }


        private void btDelete_Click(object sender, EventArgs e)
        {

            String value = "malop = '" + txtID.Text + "'";
            HeThong bridgeQLLop = new BridgeQLLop(new Delete("lop", value));

            Console.WriteLine(bridgeQLLop.delete());
            
            command = connection.CreateCommand();
            command.CommandText = bridgeQLLop.delete();
            command.ExecuteNonQuery();
            loadData();

        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            String value = "tenlop= N'" + txtName.Text + "',makh= '" + txtBasis.Text + "' where malop= '" + txtID.Text + "'";
            HeThong bridgeQLLop = new BridgeQLLop(new Update("lop", value));

            Console.WriteLine(bridgeQLLop.update());
            
            command = connection.CreateCommand();
            command.CommandText = bridgeQLLop.update();
            command.ExecuteNonQuery();
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

        private void btReset_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtBasis.Text = "";
            
            command = connection.CreateCommand();
            command.CommandText = "select * from lop";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataView.DataSource = table;
            SetEditingMode(false);
        }

        private void dataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataView.CurrentRow.Index;
            txtID.Text = dataView.Rows[i].Cells[0].Value.ToString();
            txtName.Text = dataView.Rows[i].Cells[1].Value.ToString();
            txtBasis.Text = dataView.Rows[i].Cells[2].Value.ToString();
            lstKhoa.SelectedValue = dataView.Rows[i].Cells[2].Value.ToString();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lstKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btAdd_Click_1(object sender, EventArgs e)
        {

        }
    }
}
