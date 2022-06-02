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
    public partial class Diem : Form
    {
        string masv;
        string mamh;
        int lan;
        float diem;
        string baithi;
        string ngaythi;
        public Diem(string masv, string mamh, int lan, string ngaythi, float diem, string baithi)
        {
            InitializeComponent();
            this.masv = masv;
            this.mamh = mamh;
            this.lan = lan;
            this.diem = diem;
            this.baithi = baithi;
            this.ngaythi = ngaythi;
        }

        private void Diem_Load(object sender, EventArgs e)
        {
            lblDiem.Text = this.diem.ToString();
        }
    }
}
