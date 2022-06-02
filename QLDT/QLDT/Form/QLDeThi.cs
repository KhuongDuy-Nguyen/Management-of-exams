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
    public partial class QLDeThi : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string cs;
        string name;

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from bode";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataView.DataSource = table;

        }
        public QLDeThi(string basis, string name)
        {
            InitializeComponent();
            this.cs = basis;
            this.name = name;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void QLDeThi_Load(object sender, EventArgs e)
        {
            connection = SqlSingleton.GetInstance(cs).ConnectionInstance();
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
            txtID.ReadOnly = true;
            int i;
            i = dataView.CurrentRow.Index;
            txtID.Text = dataView.Rows[i].Cells[0].Value.ToString();
            txtNumber.Text = dataView.Rows[i].Cells[1].Value.ToString();
            lstLevel.Text = dataView.Rows[i].Cells[2].Value.ToString();
            txtContent.Text = dataView.Rows[i].Cells[3].Value.ToString();
            txtSearchID.Text = dataView.Rows[i].Cells[4].Value.ToString();
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
            btSearch.Enabled = enable;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            string dap_an = "A";
            if (Result_A.Checked)
            {
                dap_an = "A";
            }
            else if (Result_B.Checked)
            {
                dap_an = "B";
            }
            if (Result_C.Checked)
            {
                dap_an = "C";
            }
            if (Result_D.Checked)
            {
                dap_an = "D";
            }
            command.CommandText = "insert into bode (mamh,cauhoi, trinhdo,noidung,A,B,C,D,dap_an,magv) values('" + txtID.Text + "'," + txtNumber.Text + 
                ",'" + lstLevel.SelectedItem.ToString() + "',N'" + txtContent.Text + "',N'" + txtA.Text + "',N'" +txtB.Text + "',N'" + txtC.Text+ "',N'" + txtD.Text + "','" + dap_an + "','" + this.name+"')";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from bode where cauhoi='" + txtNumber.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            string dap_an = "A";
            if (Result_A.Checked)
            {
                dap_an = "A";
            }
            else if (Result_B.Checked)
            {
                dap_an = "B";
            }
            if (Result_C.Checked)
            {
                dap_an = "C";
            }
            if (Result_D.Checked)
            {
                dap_an = "D";
            }
            command = connection.CreateCommand();
            command.CommandText = "update bode set mamh ='"+txtID.Text+"', trinhdo='"+lstLevel.SelectedItem.ToString()+"', noidung=N'"+txtContent.Text+"' ,A=N'"+txtA.Text+ "' ,B=N'" + txtB.Text + "' ,C=N'" + txtC.Text + "' ,D=N'" + txtD.Text + "' ,dap_an='" + dap_an+ "' where cauhoi="+txtNumber.Text;
            command.ExecuteNonQuery();
            loadData();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txtContent.Text = "";
            txtID.Text = "";
            txtNumber.Text = "";
            txtSearchID.Text = "";
            loadData();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from bode where mamh='" + txtSearchID.Text + "'";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataView.DataSource = table;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstLevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}