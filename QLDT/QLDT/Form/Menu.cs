using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDT
{
    public partial class Menu : Form
    {

        public Menu(string name, string auth, string basis)
        {
            InitializeComponent();
            txtName.Text = name;
            txtAuth.Text = auth;
            if (auth == "4")
            {
                btFaculty.Visible = false;
                btClass.Visible = false;
                btUser.Visible = false;
                btClass.Visible = false;
                btTest.Visible = false;

            }
            else if (auth == "5")
            {
                btManager.Visible = false;
                btPrint.Visible = false;
                btnReady.Visible = false;
            }
            else
            {
                btTest.Visible = false;
            }
            
            txtName.Text = name;
            txtBasis.Text = basis;

        }


        private void customizeDesing()
        {
            SubpanelQLUser.Visible = false;
            SubpanelSystem.Visible = false;

        }

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(childForm);
            panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void hideSubMenu()
        {
            if (SubpanelQL.Visible == true)
            {
                SubpanelQL.Visible = false;
            }
            if (SubpanelSystem.Visible == true)
            {
                SubpanelSystem.Visible = false;
            }
            if (SubpanelQLUser.Visible == false)
            {
                SubpanelQLUser.Visible = false;
            }
            
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        

        MenuAbstractFactory QuanLy = IMenuFactory.GetFactory(Factory_Type.QUANLY);
        MenuAbstractFactory HeThong = IMenuFactory.GetFactory(Factory_Type.HETHONG);

        #region Quan Ly 

        private void btManager_Click(object sender, EventArgs e)
        {
            showSubMenu(SubpanelQL);
            SubpanelQLUser.Visible = false;

        }

        private void btUser_Click(object sender, EventArgs e)
        {
            showSubMenu(SubpanelQLUser);
            
        }
        
        private void btnStudent_Click(object sender, EventArgs e)
        {
            openChildForm(QuanLy.LoadSystem(Menu_Type.QLSV, txtAuth.Text , txtName.Text, txtBasis.Text).Run());
        }
        
        private void btnTeacher_Click(object sender, EventArgs e)
        {
            openChildForm(QuanLy.LoadSystem(Menu_Type.QLGV, txtAuth.Text, txtName.Text, txtBasis.Text).Run());
        }

        private void btFaculty_Click(object sender, EventArgs e)
        {
            openChildForm(QuanLy.LoadSystem(Menu_Type.QLKHOA, txtAuth.Text, txtName.Text, txtBasis.Text).Run());

        }

        private void btClass_Click(object sender, EventArgs e)
        {
            openChildForm(QuanLy.LoadSystem(Menu_Type.QLLOP, txtAuth.Text, txtName.Text, txtBasis.Text).Run());
        }

        private void btSubject_Click(object sender, EventArgs e)
        {
            openChildForm(QuanLy.LoadSystem(Menu_Type.QLMH, txtAuth.Text, txtName.Text, txtBasis.Text).Run());
        }

        private void btQuestion_Click_1(object sender, EventArgs e)
        {
            openChildForm(QuanLy.LoadSystem(Menu_Type.QLDT, txtAuth.Text, txtName.Text, txtBasis.Text).Run());
        }

        #endregion

        #region System
        private void btSystem_Click(object sender, EventArgs e)
        {
            showSubMenu(SubpanelSystem);
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            
            openChildForm(HeThong.LoadSystem(Menu_Type.CHUANBITHI, txtAuth.Text, txtName.Text, txtBasis.Text).Run());
        }
        
        private void btHistory_Click(object sender, EventArgs e)
        {
            openChildForm(HeThong.LoadSystem(Menu_Type.LICHSUTHI, txtAuth.Text, txtName.Text, txtBasis.Text).Run());
        }
        
        private void btTest_Click(object sender, EventArgs e)
        {
            openChildForm(HeThong.LoadSystem(Menu_Type.LAMBAITHI, txtAuth.Text, txtName.Text, txtBasis.Text).Run());
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            openChildForm(HeThong.LoadSystem(Menu_Type.INPHIEUDIEM, txtAuth.Text, txtName.Text, txtBasis.Text).Run());
        }


        #endregion

        private void btLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login lg = new Login();
                lg.Show();
                this.Hide();
            }
        }

        #region Phan khong su dung
        private void Menu_Load(object sender, EventArgs e)
        {
            hideSubMenu();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SubpanelQLUser_Paint(object sender, PaintEventArgs e)
        {
            
        }

        

        private void panelBotton_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion
    }
}
