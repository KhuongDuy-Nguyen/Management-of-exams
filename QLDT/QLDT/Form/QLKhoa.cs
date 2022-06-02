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
using QLDT.Design_Pattern.Bridge;
namespace QLDT
{
    public partial class QLKhoa : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from khoa";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataView.DataSource = table;

        }
        public QLKhoa(string id)
        {
            InitializeComponent();
            txtBasis.Text = id;
        }

        private void QLKhoa_Load(object sender, EventArgs e)
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
        
        private void dataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataView.CurrentRow.Index;
            txtID.Text = dataView.Rows[i].Cells[0].Value.ToString();
            txtName.Text = dataView.Rows[i].Cells[1].Value.ToString();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" & txtID.Text != "" & txtName.Text != "")
            {
                String value = txtID.Text + "',N'" + txtName.Text + "','" + txtBasis.Text;
                String column = "makh,tenkh,macs";
                HeThong bridgeQLKhoa = new BridgeQLKhoa(new Create("khoa", column, value));    
                
                command = connection.CreateCommand();
                command.CommandText = bridgeQLKhoa.insert();
                command.ExecuteNonQuery();
                loadData();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }


        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            String value =  "makh = '" + txtID.Text + "'";
            HeThong bridgeQLKhoa = new BridgeQLKhoa(new Delete("khoa", value));


            command = connection.CreateCommand();
            command.CommandText = bridgeQLKhoa.delete();
            command.ExecuteNonQuery();
            loadData();


        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            String value = "tenkh= N'" + txtName.Text + "',macs= '" + txtBasis.Text + "' where makh = '" + txtID.Text + "'";
            HeThong bridgeQLKhoa = new BridgeQLKhoa(new Update("khoa", value));

            command = connection.CreateCommand();
            command.CommandText = bridgeQLKhoa.update();
            command.ExecuteNonQuery();
            loadData();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            loadData();
        }

    }
}
