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
    public partial class Thi : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string name;
        string cs;
        string malop;
        string tenlop;
        string mamh;
        string trinhdo;
        float diemcau;
        int socau;
        int time;
        int time1;
        string baithi;
        string ngaythi;
        DateTime starttime = DateTime.Now;
        List<Panel> listPanel = new List<Panel>();
        int index=1;
        int lanthi;

        Timer timer1 = new Timer();
        public Thi(string name, string cs, string malop, string tenlop, string monhoc, string trinhdo, float diemcau, int time, int socau, int lanthi, string ngaythi)
        {
            InitializeComponent();
            this.name = name;
            this.cs = cs;
            this.malop = malop;
            this.tenlop = tenlop;
            this.mamh = monhoc;
            this.trinhdo = trinhdo;
            this.diemcau = diemcau;
            this.time = time;
            this.socau = socau;
            this.lanthi = lanthi;
            this.ngaythi = ngaythi;
            this.starttime.AddMinutes(this.time);

            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void Thi_Load(object sender, EventArgs e)
        {
            labelMamh.Text = this.mamh;
            masv.Text = this.name;

            this.time1 = this.time;

            listPanel.Add(panel1);
            listPanel.Add(panel2);
            listPanel.Add(panel3);
            listPanel.Add(panel4);
            listPanel.Add(panel5);
            listPanel.Add(panel6);
            listPanel.Add(panel7);
            listPanel.Add(panel8);
            listPanel.Add(panel9);
            listPanel.Add(panel10);
            listPanel[index].BringToFront();


            connection = new SqlConnection(serverConnection.connectServer(this.cs));
            connection.Open();
            loadData();
        }
        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select top(" + this.socau + ") noidung, A, B, C, D, dap_an from bode where mamh='" + this.mamh + "'";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataView.DataSource = table;

            
            
            lblques1.Text =  dataView.Rows[0].Cells[0].Value.ToString();
            lblques2.Text =  dataView.Rows[1].Cells[0].Value.ToString();
            lblques3.Text =  dataView.Rows[2].Cells[0].Value.ToString();
            lblques4.Text = dataView.Rows[3].Cells[0].Value.ToString();
            lblques5.Text =  dataView.Rows[4].Cells[0].Value.ToString();
            lblques6.Text =  dataView.Rows[5].Cells[0].Value.ToString();
            lblques7.Text =  dataView.Rows[6].Cells[0].Value.ToString();
            lblques8.Text =  dataView.Rows[7].Cells[0].Value.ToString();
            lblques9.Text =  dataView.Rows[8].Cells[0].Value.ToString();
            lblques10.Text =  dataView.Rows[9].Cells[0].Value.ToString();

            baithi += "Cau 1" + dataView.Rows[0].Cells[0].Value.ToString()
                + "Cau 2" + dataView.Rows[1].Cells[0].Value.ToString()
                + "Cau 3" + dataView.Rows[2].Cells[0].Value.ToString()
                + "Cau 4" + dataView.Rows[3].Cells[0].Value.ToString()
                + "Cau 5" + dataView.Rows[4].Cells[0].Value.ToString()
                + "Cau 6" + dataView.Rows[5].Cells[0].Value.ToString()
                + "Cau 7" + dataView.Rows[6].Cells[0].Value.ToString()
                + "Cau 8" + dataView.Rows[7].Cells[0].Value.ToString()
                + "Cau 9" + dataView.Rows[8].Cells[0].Value.ToString()
                + "Cau 10" + dataView.Rows[9].Cells[0].Value.ToString();

            lblques1A.Text = dataView.Rows[0].Cells[1].Value.ToString();
            lblques1B.Text = dataView.Rows[0].Cells[2].Value.ToString();
            lblques1C.Text = dataView.Rows[0].Cells[3].Value.ToString();
            lblques1D.Text = dataView.Rows[0].Cells[4].Value.ToString();

            lblques2A.Text = dataView.Rows[1].Cells[1].Value.ToString();
            lblques2B.Text = dataView.Rows[1].Cells[2].Value.ToString();
            lblques2C.Text = dataView.Rows[1].Cells[3].Value.ToString();
            lblques2D.Text = dataView.Rows[1].Cells[4].Value.ToString();

            lblques3A.Text = dataView.Rows[2].Cells[1].Value.ToString();
            lblques3B.Text = dataView.Rows[2].Cells[2].Value.ToString();
            lblques3C.Text = dataView.Rows[2].Cells[3].Value.ToString();
            lblques3D.Text = dataView.Rows[2].Cells[4].Value.ToString();


            lblques4A.Text = dataView.Rows[3].Cells[1].Value.ToString();
            lblques4B.Text = dataView.Rows[3].Cells[2].Value.ToString();
            lblques4C.Text = dataView.Rows[3].Cells[3].Value.ToString();
            lblques4D.Text = dataView.Rows[3].Cells[4].Value.ToString();

            lblques5A.Text = dataView.Rows[4].Cells[1].Value.ToString();
            lblques5B.Text = dataView.Rows[4].Cells[2].Value.ToString();
            lblques5C.Text = dataView.Rows[4].Cells[3].Value.ToString();
            lblques5D.Text = dataView.Rows[4].Cells[4].Value.ToString();


            lblques6A.Text = dataView.Rows[5].Cells[1].Value.ToString();
            lblques6B.Text = dataView.Rows[5].Cells[2].Value.ToString();
            lblques6C.Text = dataView.Rows[5].Cells[3].Value.ToString();
            lblques6D.Text = dataView.Rows[5].Cells[4].Value.ToString();

            lblques7A.Text = dataView.Rows[6].Cells[1].Value.ToString();
            lblques7B.Text = dataView.Rows[6].Cells[2].Value.ToString();
            lblques7C.Text = dataView.Rows[6].Cells[3].Value.ToString();
            lblques7D.Text = dataView.Rows[6].Cells[4].Value.ToString();

            lblques8A.Text = dataView.Rows[7].Cells[1].Value.ToString();
            lblques8B.Text = dataView.Rows[7].Cells[2].Value.ToString();
            lblques8C.Text = dataView.Rows[7].Cells[3].Value.ToString();
            lblques8D.Text = dataView.Rows[7].Cells[4].Value.ToString();

            lblques9A.Text = dataView.Rows[8].Cells[1].Value.ToString();
            lblques9B.Text = dataView.Rows[8].Cells[2].Value.ToString();
            lblques9C.Text = dataView.Rows[8].Cells[3].Value.ToString();
            lblques9D.Text = dataView.Rows[8].Cells[4].Value.ToString();

            lblques10A.Text = dataView.Rows[9].Cells[1].Value.ToString();
            lblques10B.Text = dataView.Rows[9].Cells[2].Value.ToString();
            lblques10C.Text = dataView.Rows[9].Cells[3].Value.ToString();
            lblques10D.Text = dataView.Rows[9].Cells[4].Value.ToString();
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan TimeRemaining = this.starttime.AddMinutes(this.time) - DateTime.Now ;
            labelTime.Text = TimeRemaining.Hours + " : " + TimeRemaining.Minutes + " : " + TimeRemaining.Seconds;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                listPanel[--index].BringToFront();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (index < listPanel.Count - 1)
                listPanel[++index].BringToFront();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            for(int i =0; i<this.socau; i++)
            {
                list.Add(dataView.Rows[i].Cells[5].Value.ToString());
            }

            float diem = 0;

            if (list[0] == "A")
            {
                if (ques1A.Checked)
                    diem += this.diemcau;
                baithi += lblques1A.Text;
            }
            else if(list[0] == "B")
            {
                if (ques1B.Checked)
                    diem += this.diemcau;
                baithi += lblques1B.Text;
            }
            else if (list[0] == "C")
            {
                if (ques1C.Checked)
                    diem += this.diemcau;
                baithi += lblques1C.Text;
            }
            else if (list[0] == "D")
            {
                if (ques1D.Checked)
                    diem += this.diemcau;
                baithi += lblques1D.Text;
            }


            if (list[1] == "A")
            {
                if (ques2A.Checked)
                    diem += this.diemcau;
                baithi += lblques2A.Text;
            }
            else if (list[1] == "B")
            {
                if (ques2B.Checked)
                    diem += this.diemcau;
                baithi += lblques2B.Text;
            }
            else if (list[1] == "C")
            {
                if (ques2C.Checked)
                    diem += this.diemcau;

                baithi += lblques2C.Text;
            }
            else if (list[1] == "D")
            {
                if (ques2D.Checked)
                    diem += this.diemcau;
                baithi += lblques2D.Text;
            }


            if (list[2] == "A")
            {
                if (ques3A.Checked)
                    diem += this.diemcau;
                baithi += lblques3A.Text;
            }
            else if (list[2] == "B")
            {
                if (ques3B.Checked)
                    diem += this.diemcau;
                baithi += lblques3B.Text;
            }
            else if (list[2] == "C")
            {
                if (ques3C.Checked)
                    diem += this.diemcau;
                baithi += lblques3C.Text;
            }
            else if (list[2] == "D")
            {
                if (ques3D.Checked)
                    diem += this.diemcau;
                baithi += lblques3D.Text;
            }

            if (list[3] == "A")
            {
                if (ques4A.Checked)
                    diem += this.diemcau;
                baithi += lblques4A.Text;
            }
            else if (list[3] == "B")
            {
                if (ques4B.Checked)
                    diem += this.diemcau;
                baithi += lblques4B.Text;
            }
            else if (list[3] == "C")
            {
                if (ques4C.Checked)
                    diem += this.diemcau;
                baithi += lblques4C.Text;
            }
            else if (list[3] == "D")
            {
                if (ques4D.Checked)
                    diem += this.diemcau;
                baithi += lblques4D.Text;
            }

            if (list[4] == "A")
            {
                if (ques5A.Checked)
                    diem += this.diemcau;
                baithi += lblques5A.Text;
            }
            else if (list[4] == "B")
            {
                if (ques5B.Checked)
                    diem += this.diemcau;
                baithi += lblques5B.Text;
            }
            else if (list[4] == "C")
            {
                if (ques5C.Checked)
                    diem += this.diemcau;
                baithi += lblques5C.Text;
            }
            else if (list[4] == "D")
            {
                if (ques5D.Checked)
                    diem += this.diemcau;
                baithi += lblques5D.Text;
            }

            if (list[5] == "A")
            {
                if (ques6A.Checked)
                    diem += this.diemcau;
                baithi += lblques6A.Text;
            }
            else if (list[5] == "B")
            {
                if (ques6B.Checked)
                    diem += this.diemcau;
                baithi += lblques6B.Text;
            }
            else if (list[5] == "C")
            {
                if (ques6C.Checked)
                    diem += this.diemcau;
                baithi += lblques6C.Text;
            }
            else if (list[5] == "D")
            {
                if (ques6D.Checked)
                    diem += this.diemcau;
                baithi += lblques6D.Text;
            }

            if (list[6] == "A")
            {
                if (ques7A.Checked)
                    diem += this.diemcau;
                baithi += lblques7A.Text;
            }
            else if (list[6] == "B")
            {
                if (ques7B.Checked)
                    diem += this.diemcau;
                baithi += lblques7B.Text;
            }
            else if (list[6] == "C")
            {
                if (ques7C.Checked)
                    diem += this.diemcau;
                baithi += lblques7C.Text;
            }
            else if (list[6] == "D")
            {
                if (ques7D.Checked)
                    diem += this.diemcau;
                baithi += lblques7D.Text;
            }


            if (list[7] == "A")
            {
                if (ques8A.Checked)
                    diem += this.diemcau;
                baithi += lblques8A.Text;
            }
            else if (list[7] == "B")
            {
                if (ques8B.Checked)
                    diem += this.diemcau;
                baithi += lblques8B.Text;
            }
            else if (list[7] == "C")
            {
                if (ques8C.Checked)
                    diem += this.diemcau;
                baithi += lblques8C.Text;
            }
            else if (list[7] == "D")
            {
                if (ques8D.Checked)
                    diem += this.diemcau;
                baithi += lblques8D.Text;
            }


            if (list[8] == "A")
            {
                if (ques9A.Checked)
                    diem += this.diemcau;
                baithi += lblques9A.Text;
            }
            else if (list[8] == "B")
            {
                if (ques9B.Checked)
                    diem += this.diemcau;
                baithi += lblques9B.Text;
            }
            else if (list[8] == "C")
            {
                if (ques9C.Checked)
                    diem += this.diemcau;
                baithi += lblques9C.Text;
            }
            else if (list[8] == "D")
            {
                if (ques9D.Checked)
                    diem += this.diemcau;
                baithi += lblques9D.Text;
            }


            if (list[9] == "A")
            {
                if (ques10A.Checked)
                    diem += this.diemcau;
                baithi += lblques10A.Text;
            }
            else if (list[9] == "B")
            {
                if (ques10B.Checked)
                    diem += this.diemcau;
                baithi += lblques10B.Text;
            }
            else if (list[9] == "C")
            {
                if (ques10C.Checked)
                    diem += this.diemcau;
                baithi += lblques10C.Text;
            }
            else if (list[9] == "D")
            {
                if (ques10D.Checked)
                    diem += this.diemcau;
                baithi += lblques10D.Text;
            }
            command = connection.CreateCommand();
            command.CommandText = "insert into bangdiem (masv,mamh,lan,ngaythi,diem,baithi) values('" + this.name + "','" + this.mamh + "','" + this.lanthi + "','" + this.ngaythi + "'," + diem + ",'" + this.baithi + "')";
            command.ExecuteNonQuery();
            Diem d = new Diem(this.name, this.mamh, this.lanthi, this.ngaythi, diem, this.baithi);
            d.ShowDialog();
            this.Close();
        }
        
        }
    }

