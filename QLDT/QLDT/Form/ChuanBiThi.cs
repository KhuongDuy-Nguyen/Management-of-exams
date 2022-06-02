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
    public partial class ChuanBiThi : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string cs;
        string name;
        public ChuanBiThi(string basis, string name)
        {
            InitializeComponent();
            this.cs = basis;
            this.name = name;
        }
        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from giaovien_dangky";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataView.DataSource = table;

        }

        private void ChuanBiThi_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(serverConnection.connectServer(cs));
            connection.Open();
            loadData();

            //Class
            string strCmd = "select malop, tenlop from lop, khoa where khoa.makh = lop.makh and macs ='"+cs+"'";
            SqlCommand cmd = new SqlCommand(strCmd, connection);
            SqlDataAdapter da = new SqlDataAdapter(strCmd, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            connection.Close();
            comboClass.DisplayMember = "tenlop";
            comboClass.ValueMember = "malop";
            comboClass.DataSource = ds.Tables[0];

            //Mon hoc

            connection.Open();
            string strCmd1 = "select mamh, tenmh from monhoc";
            SqlCommand cmd1 = new SqlCommand(strCmd1, connection);
            SqlDataAdapter da1 = new SqlDataAdapter(strCmd1, connection);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            cmd1.ExecuteNonQuery();
            connection.Close();

            comboSubject.DisplayMember = "tenmh";
            comboSubject.ValueMember = "mamh";
            comboSubject.DataSource = ds1.Tables[0];

            comboLevel.SelectedIndex = 0;
            comboTimes.SelectedIndex = 0;

        
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            

            if (txtNumber.Text == "" | txtTime.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                if (int.Parse(txtNumber.Text) < 10 | int.Parse(txtNumber.Text) > 100)
                {
                    MessageBox.Show("Vui lòng nhập số câu thì từ 10 đến 100");
                }else if (int.Parse(txtTime.Text) < 15 | int.Parse(txtTime.Text) > 60)
                {
                    MessageBox.Show("Vui lòng nhập thời gian thi từ 15 đến 60");
                }
                else if (dateMatch.Value < System.DateTime.Now)
                {
                    MessageBox.Show("Vui lòng nhập chính xác ngày thi");
                }
                else if (comboLevel.SelectedIndex == null)
                {
                    MessageBox.Show("Vui lòng chọn trình độ");
                }
                else if (comboTimes.SelectedIndex == null)
                {
                    MessageBox.Show("Vui lòng chọn lần thi");
                }
                else
                {
                    try {
                        connection.Open();
                        string date = dateMatch.Value.ToString("yyyy/MM/dd");
                        command = connection.CreateCommand();
                        command.CommandText = "insert into giaovien_dangky (magv,malop,mamh,trinhdo,ngaythi,lan,socauthi,thoigian) values('" + name + "','" + comboClass.SelectedValue.ToString() + "','" + comboSubject.SelectedValue.ToString() + "','" + comboLevel.SelectedItem.ToString() + "','" + date + "'," + comboTimes.SelectedItem.ToString() + "," + txtNumber.Text + "," + txtTime.Text + ")";
                        command.ExecuteNonQuery();
                        loadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            
            
            
        }

        private void giangvien_TextChanged(object sender, EventArgs e)
        {

        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "";
            txtTime.Text = "";
        }
    }
}
