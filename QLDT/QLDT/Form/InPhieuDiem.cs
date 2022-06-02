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
using Microsoft.Reporting.WinForms;

namespace QLDT
{
    public partial class InPhieuDiem : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string cs;
        string name;
        private object dataView;
        string lop;
        string lanthi;
        string monhoc;

        public InPhieuDiem(string basis, string name)
        {
            InitializeComponent();
            this.cs = basis;
            this.name = name;
        }
        
        void loadData()
        {
            if (cblanthi.SelectedIndex == null)
            {
                MessageBox.Show("Vui lòng chọn lần thi");
            }
            else
            {
                this.lop = cbclass.SelectedValue.ToString();
                this.lanthi = cblanthi.SelectedItem.ToString();
                this.monhoc = cbmonhoc.SelectedValue.ToString();
                command = connection.CreateCommand();
                command.CommandText = "select * from bangdiem where masv in (select masv from sinhvien where malop = '" + cbclass.SelectedValue.ToString() + "') and mamh = '" + cbmonhoc.SelectedValue.ToString() + "' and lan = '" + cblanthi.SelectedItem.ToString() + "'";
                //MessageBox.Show(cbclass.SelectedValue);
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                //dataView1.DataSource = table;
            }
            

        }

        private void InPhieuDiem_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(serverConnection.connectServer(cs));
            connection.Open();
            //loadData();


            //Class
            string strCmd = "select malop, tenlop from lop, khoa where khoa.makh = lop.makh and macs ='" + cs + "'";
            SqlCommand cmd = new SqlCommand(strCmd, connection);
            SqlDataAdapter da = new SqlDataAdapter(strCmd, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            connection.Close();
            cbclass.DisplayMember = "tenlop";
            cbclass.ValueMember = "malop";
            cbclass.DataSource = ds.Tables[0];


            connection.Open();
            string strCmd1 = "select mamh, tenmh from monhoc";
            SqlCommand cmd1 = new SqlCommand(strCmd1, connection);
            SqlDataAdapter da1 = new SqlDataAdapter(strCmd1, connection);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            cmd1.ExecuteNonQuery();
            connection.Close();

            cbmonhoc.DisplayMember = "tenmh";
            cbmonhoc.ValueMember = "mamh";
            cbmonhoc.DataSource = ds1.Tables[0];

            cblanthi.SelectedIndex = 0;
            this.reportViewer1.RefreshReport();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void openChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btIn_Click(object sender, EventArgs e)
        {
            PhieuDiem pd = new PhieuDiem(this.cs, this.name, this.lop, this.lanthi, this.monhoc);
            pd.ShowDialog();

            //PhieuDiem form2 = new PhieuDiem(this.cs, this.name);

            ////// #2. Set second form's size
            //form2.Width = this.Width;
            //form2.Height = this.Height;

            ////// #3. Set second form's start position as same as parent form
            //form2.StartPosition = FormStartPosition.Manual;
            //form2.Location = new Point(this.Location.X, this.Location.Y);

            //////// #4. Set parent form's visible to false
            //this.Visible = false;

            //////// #5. Open second dialog
            //form2.ShowDialog();

            ////// #6. Set parent form's visible to true
            //this.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(serverConnection.connectServer(this.cs));
            connection.Open();
            loadData();

            connection = new SqlConnection(serverConnection.connectServer(cs));
            //connection.Open();
            SqlCommand cmd = new SqlCommand("select * from bangdiem where masv in (select masv from sinhvien where malop = '" + cbclass.SelectedValue.ToString() + "') and mamh = '" + cbmonhoc.SelectedValue.ToString() + "' and lan = '" + cblanthi.SelectedItem.ToString() + "'", connection);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da2.Fill(table);

            ReportDataSource rds = new ReportDataSource("DataSet1", table);
            reportViewer1.LocalReport.ReportPath = @"D:\BAIHOC\HKI--HKII--2021\MauThietKe\CK\Source Code\QLDT\QLDT\rptPhieuDiem.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
            connection.Close();
        }

        

    }
}
