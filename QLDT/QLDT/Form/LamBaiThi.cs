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
    public partial class LamBaiThi : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string name;
        string cs;
        string malop;
        string tenlop;
        string monhoc;
        string mamh;
        string trinhdo;
        int time;
        int socau;
        float diemcau;
        int lanthi;
        public LamBaiThi(string cs, string name)
        {
            InitializeComponent();
            this.name = name;
            this.cs = cs;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LamBaiThi_Load(object sender, EventArgs e)
        {

            connection = SqlSingleton.GetInstance(cs).ConnectionInstance();
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra trong kết nối db: " + ex);
            }

            lblMasv.Text = this.name.ToString();

            string strCmd = "select malop, tenlop from lop where malop in (select malop from sinhvien where masv='"+this.name+"')";
            SqlCommand cmd = new SqlCommand(strCmd, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    this.malop = reader.GetString(0);
                    this.tenlop = reader.GetString(1);

                    lblMalop.Text = this.malop;
                    lblTenlop.Text = this.tenlop;
                }
            }
            connection.Close();

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

            comboTimes.SelectedIndex = 0;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            this.lanthi = int.Parse(comboTimes.SelectedItem.ToString());
            connection.Open();
            string date = dateMatch.Value.ToString("yyyy/MM/dd");
            string strCmd1 = "select mamh, trinhdo, thoigian, socauthi from giaovien_dangky where mamh='" + comboSubject.SelectedValue.ToString() + "' and ngaythi ='" +date+"' and lan="+comboTimes.SelectedItem.ToString();
            SqlCommand cmd1 = new SqlCommand(strCmd1, connection);
            SqlDataReader reader = cmd1.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    this.mamh = reader.GetString(0);
                    this.trinhdo = reader.GetString(1);
                    this.time = reader.GetInt16(2);
                    this.socau = reader.GetInt16(3);

                    this.diemcau = 10 / socau;
                }

                this.mamh = comboSubject.SelectedValue.ToString();
                Thi thi = new Thi(this.name, this.cs, this.malop, this.tenlop, this.mamh, this.trinhdo, this.diemcau, this.time, this.socau, this.lanthi, date);
                thi.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin");
            }

            connection.Close();

            
        }
    }
}
