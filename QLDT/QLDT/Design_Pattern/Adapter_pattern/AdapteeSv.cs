using QLDT.Design_Pattern.Adapter_pattern;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDT.Adapter_pattern
{
    public class AdapteeSv
    {

        Sinhvien sv;
        public AdapteeSv(Sinhvien sv)
        {

            this.sv = sv;
        }
        public DataSet_SV ConvertToDataSetSinhvien(String cs, Sinhvien sv)
        {
            SqlConnection connection = new SqlConnection(serverConnection.connectServer(cs));

            String path = Path.GetDirectoryName(Application.ExecutablePath).ToString().Replace(@"bin\Debug", string.Empty) + @"Adapter pattern\ReportSinhvien.rdlc";

            SqlDataAdapter lop = new SqlDataAdapter("Select * from dbo.lop where malop = '" + sv.malop + "'", connection);

            DataTable dt = new DataTable("DataTable_SV");
            dt.Columns.Add("masv", typeof(string));
            dt.Columns.Add("ho", typeof(string));
            dt.Columns.Add("ten", typeof(string));
            dt.Columns.Add("ngaysinh", typeof(string));
            dt.Columns.Add("diachi", typeof(string));
            dt.Columns.Add("malop", typeof(string));
            dt.Columns.Add("rowguid", typeof(string));

            dt.Rows.Add(sv.masv, sv.ho, sv.ten, sv.ngaysinh, sv.diachi, sv.malop, "");


            DataSet_SV dataset_SV = new DataSet_SV();
            dataset_SV.Tables.Clear();
            dataset_SV.Tables.Add(dt);
            //adapter.Fill(sv, "DataTable_SV");
            lop.Fill(dataset_SV, "DataTable_Lop");
            return dataset_SV;

        }
    }
}
