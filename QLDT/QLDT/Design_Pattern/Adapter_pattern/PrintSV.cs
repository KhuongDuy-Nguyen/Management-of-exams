using Microsoft.Reporting.WinForms;
using QLDT.Adapter_pattern;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDT.Design_Pattern.Adapter_pattern
{
    public partial class PrintSV : Form
    {
        String cs;
        Sinhvien sv;
        public PrintSV(String cs, Sinhvien sv)
        {
            InitializeComponent();
            this.cs = cs;
            this.sv = sv;

        }

        private void PrintSV_Load(object sender, EventArgs e)
        {

            String path = Path.GetDirectoryName(Application.ExecutablePath).ToString().Replace(@"bin\Debug", string.Empty) + @"Design_Pattern\Adapter_pattern\InfoSv.rdlc";

            //Khởi tạo Adaptee xử lý dữ liệu Sinh viên
            AdapteeSv adaptee = new AdapteeSv(sv);

            //Khởi tạo adapter để đổ dữ liệu vào interface In Thông Tin
            Adapter adapter = new Adapter(adaptee);

            //Khởi DataSet_Sv lấy dữ liệu DataSet từ adapter 
            DataSet_SV dataSetSV = adapter.ReadDataSV(cs, sv);

            //Đổ dữ liệu vào report 
            ReportDataSource rds = new ReportDataSource("DataSet1", dataSetSV.Tables[0]);
            ReportDataSource rds1 = new ReportDataSource("DataSet2", dataSetSV.Tables[1]);

            reportViewer1.LocalReport.ReportPath = path;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.DataSources.Add(rds1);
            reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
