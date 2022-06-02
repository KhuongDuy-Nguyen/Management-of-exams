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
namespace QLDT
{
    
    public partial class Login : Form
    {
            
        SqlConnection connMain = new SqlConnection(@"Data Source = NATSUI\SERVERMAIN; Initial Catalog = THI_TN; Persist Security Info = True; User ID = sa; Password = 123");

        public Login()
        {
            InitializeComponent();
        }
        
        private string getInfo(string user, string pass, string basis)
        {
            
            string auth = "";
            try
            {
                connMain.Open();
                SqlCommand cmd = new SqlCommand ("select * from account where username = '"+user+"' and pass = '"+pass+ "' and macs = '" + basis + "'", connMain);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if(dt != null)
                {
                    foreach(DataRow dr in dt.Rows)
                    {
                        auth = dr["quyen"].ToString();
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Loi");
            }
            finally
            {
                connMain.Close();
            }
            
            return auth;
            
        }


        public string auth_user = "", basis_user = "";

        private void btLogin_Click(object sender, EventArgs e)
        {
            auth_user = getInfo(txtUser.Text, txtPass.Text, listBasis.Text);
            
            if (auth_user == "")
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ");
            }
            else
            {
                MessageBox.Show("Chào mừng quay trở lại " + txtUser.Text);
                
                basis_user = listBasis.Text;
                Menu mn = new Menu(txtUser.Text, auth_user, basis_user);
                mn.Show();
                this.Hide();
            }
        }


        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBasis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void Login_Load(object sender, EventArgs e)
        {
            listBasis.SelectedIndex = 0;
        }
    }
}
