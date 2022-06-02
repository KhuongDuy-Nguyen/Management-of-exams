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
    public partial class PhieuDiem : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string cs;
        string name;
        string lop;
        string lanthi;
        string monhoc;
        public PhieuDiem(string cs, string name, string lop, string lanthi, string monhoc)
        {
            InitializeComponent();
            this.cs = cs;
            this.name = name;
            this.lop = lop;
            this.lanthi = lanthi;
            this.monhoc = monhoc;
        }

        private void PhieuDiem_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(serverConnection.connectServer(cs));
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from bangdiem where masv in (select masv from sinhvien where malop = '" + this.lop + "') and mamh = '" + this.monhoc + "' and lan = '" + this.lanthi + "'", connection);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da2.Fill(table);

            ReportDataSource rds = new ReportDataSource("DataSet1", table);
            reportViewer1.LocalReport.ReportPath = @"D:\BAIHOC\HKI--HKII--2021\MauThietKe\CK\Source Code\QLDT\QLDT\rptPhieuDiem.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
