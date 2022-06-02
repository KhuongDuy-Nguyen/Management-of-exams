
namespace QLDT
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btLogout = new System.Windows.Forms.Button();
            this.panelBotton = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBasis = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SubpanelSystem = new System.Windows.Forms.Panel();
            this.btPrint = new System.Windows.Forms.Button();
            this.btTest = new System.Windows.Forms.Button();
            this.btnReady = new System.Windows.Forms.Button();
            this.btHistory = new System.Windows.Forms.Button();
            this.btSystem = new System.Windows.Forms.Button();
            this.SubpanelQL = new System.Windows.Forms.Panel();
            this.btQuestion = new System.Windows.Forms.Button();
            this.btSubject = new System.Windows.Forms.Button();
            this.btClass = new System.Windows.Forms.Button();
            this.btFaculty = new System.Windows.Forms.Button();
            this.SubpanelQLUser = new System.Windows.Forms.Panel();
            this.btnTeacher = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btUser = new System.Windows.Forms.Button();
            this.btManager = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAuth = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelBotton.SuspendLayout();
            this.SubpanelSystem.SuspendLayout();
            this.SubpanelQL.SuspendLayout();
            this.SubpanelQLUser.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btLogout);
            this.panelMenu.Controls.Add(this.panelBotton);
            this.panelMenu.Controls.Add(this.SubpanelSystem);
            this.panelMenu.Controls.Add(this.btSystem);
            this.panelMenu.Controls.Add(this.SubpanelQL);
            this.panelMenu.Controls.Add(this.btManager);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 616);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btLogout
            // 
            this.btLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btLogout.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogout.ForeColor = System.Drawing.Color.Brown;
            this.btLogout.Location = new System.Drawing.Point(0, 510);
            this.btLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(200, 41);
            this.btLogout.TabIndex = 6;
            this.btLogout.Text = "Đăng xuất";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // panelBotton
            // 
            this.panelBotton.Controls.Add(this.label4);
            this.panelBotton.Controls.Add(this.txtBasis);
            this.panelBotton.Controls.Add(this.txtName);
            this.panelBotton.Controls.Add(this.label1);
            this.panelBotton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotton.Location = new System.Drawing.Point(0, 551);
            this.panelBotton.Name = "panelBotton";
            this.panelBotton.Size = new System.Drawing.Size(200, 65);
            this.panelBotton.TabIndex = 5;
            this.panelBotton.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBotton_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hoạt động tại";
            // 
            // txtBasis
            // 
            this.txtBasis.AutoSize = true;
            this.txtBasis.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBasis.Location = new System.Drawing.Point(113, 34);
            this.txtBasis.Name = "txtBasis";
            this.txtBasis.Size = new System.Drawing.Size(36, 16);
            this.txtBasis.TabIndex = 9;
            this.txtBasis.Text = "Basis";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(113, 15);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(40, 16);
            this.txtName.TabIndex = 8;
            this.txtName.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Xin chào";
            // 
            // SubpanelSystem
            // 
            this.SubpanelSystem.Controls.Add(this.btPrint);
            this.SubpanelSystem.Controls.Add(this.btTest);
            this.SubpanelSystem.Controls.Add(this.btnReady);
            this.SubpanelSystem.Controls.Add(this.btHistory);
            this.SubpanelSystem.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubpanelSystem.Location = new System.Drawing.Point(0, 350);
            this.SubpanelSystem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SubpanelSystem.Name = "SubpanelSystem";
            this.SubpanelSystem.Size = new System.Drawing.Size(200, 160);
            this.SubpanelSystem.TabIndex = 4;
            // 
            // btPrint
            // 
            this.btPrint.Dock = System.Windows.Forms.DockStyle.Top;
            this.btPrint.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrint.ForeColor = System.Drawing.Color.Brown;
            this.btPrint.Location = new System.Drawing.Point(0, 123);
            this.btPrint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(200, 41);
            this.btPrint.TabIndex = 12;
            this.btPrint.Text = "In phiếu điểm";
            this.btPrint.UseVisualStyleBackColor = true;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // btTest
            // 
            this.btTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btTest.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTest.ForeColor = System.Drawing.Color.Brown;
            this.btTest.Location = new System.Drawing.Point(0, 82);
            this.btTest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btTest.Name = "btTest";
            this.btTest.Size = new System.Drawing.Size(200, 41);
            this.btTest.TabIndex = 11;
            this.btTest.Text = "Làm bài thi";
            this.btTest.UseVisualStyleBackColor = true;
            this.btTest.Click += new System.EventHandler(this.btTest_Click);
            // 
            // btnReady
            // 
            this.btnReady.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReady.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReady.ForeColor = System.Drawing.Color.Brown;
            this.btnReady.Location = new System.Drawing.Point(0, 41);
            this.btnReady.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(200, 41);
            this.btnReady.TabIndex = 10;
            this.btnReady.Text = "Chuẩn bị thi";
            this.btnReady.UseVisualStyleBackColor = true;
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // btHistory
            // 
            this.btHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btHistory.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHistory.ForeColor = System.Drawing.Color.Brown;
            this.btHistory.Location = new System.Drawing.Point(0, 0);
            this.btHistory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btHistory.Name = "btHistory";
            this.btHistory.Size = new System.Drawing.Size(200, 41);
            this.btHistory.TabIndex = 9;
            this.btHistory.Text = "Lịch sử Thi";
            this.btHistory.UseVisualStyleBackColor = true;
            this.btHistory.Click += new System.EventHandler(this.btHistory_Click);
            // 
            // btSystem
            // 
            this.btSystem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btSystem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btSystem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btSystem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btSystem.FlatAppearance.BorderSize = 0;
            this.btSystem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSystem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSystem.Location = new System.Drawing.Point(0, 305);
            this.btSystem.Margin = new System.Windows.Forms.Padding(0);
            this.btSystem.Name = "btSystem";
            this.btSystem.Size = new System.Drawing.Size(200, 45);
            this.btSystem.TabIndex = 3;
            this.btSystem.Text = "Hệ thống";
            this.btSystem.UseVisualStyleBackColor = false;
            this.btSystem.Click += new System.EventHandler(this.btSystem_Click);
            // 
            // SubpanelQL
            // 
            this.SubpanelQL.Controls.Add(this.btQuestion);
            this.SubpanelQL.Controls.Add(this.btSubject);
            this.SubpanelQL.Controls.Add(this.btClass);
            this.SubpanelQL.Controls.Add(this.btFaculty);
            this.SubpanelQL.Controls.Add(this.SubpanelQLUser);
            this.SubpanelQL.Controls.Add(this.btUser);
            this.SubpanelQL.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubpanelQL.Location = new System.Drawing.Point(0, 45);
            this.SubpanelQL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SubpanelQL.Name = "SubpanelQL";
            this.SubpanelQL.Size = new System.Drawing.Size(200, 260);
            this.SubpanelQL.TabIndex = 2;
            // 
            // btQuestion
            // 
            this.btQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btQuestion.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuestion.ForeColor = System.Drawing.Color.Brown;
            this.btQuestion.Location = new System.Drawing.Point(0, 224);
            this.btQuestion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btQuestion.Name = "btQuestion";
            this.btQuestion.Size = new System.Drawing.Size(200, 41);
            this.btQuestion.TabIndex = 13;
            this.btQuestion.Text = "Quản lý Đề Thi";
            this.btQuestion.UseVisualStyleBackColor = true;
            this.btQuestion.Click += new System.EventHandler(this.btQuestion_Click_1);
            // 
            // btSubject
            // 
            this.btSubject.Dock = System.Windows.Forms.DockStyle.Top;
            this.btSubject.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.btSubject.ForeColor = System.Drawing.Color.Brown;
            this.btSubject.Location = new System.Drawing.Point(0, 183);
            this.btSubject.Name = "btSubject";
            this.btSubject.Size = new System.Drawing.Size(200, 41);
            this.btSubject.TabIndex = 12;
            this.btSubject.Text = "Quản lý Môn Học";
            this.btSubject.UseVisualStyleBackColor = true;
            this.btSubject.Click += new System.EventHandler(this.btSubject_Click);
            // 
            // btClass
            // 
            this.btClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btClass.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.btClass.ForeColor = System.Drawing.Color.Brown;
            this.btClass.Location = new System.Drawing.Point(0, 142);
            this.btClass.Name = "btClass";
            this.btClass.Size = new System.Drawing.Size(200, 41);
            this.btClass.TabIndex = 10;
            this.btClass.Text = "Quản lý Lớp";
            this.btClass.UseVisualStyleBackColor = true;
            this.btClass.Click += new System.EventHandler(this.btClass_Click);
            // 
            // btFaculty
            // 
            this.btFaculty.Dock = System.Windows.Forms.DockStyle.Top;
            this.btFaculty.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.btFaculty.ForeColor = System.Drawing.Color.Brown;
            this.btFaculty.Location = new System.Drawing.Point(0, 101);
            this.btFaculty.Name = "btFaculty";
            this.btFaculty.Size = new System.Drawing.Size(200, 41);
            this.btFaculty.TabIndex = 9;
            this.btFaculty.Text = "Quản lý Khoa";
            this.btFaculty.UseVisualStyleBackColor = true;
            this.btFaculty.Click += new System.EventHandler(this.btFaculty_Click);
            // 
            // SubpanelQLUser
            // 
            this.SubpanelQLUser.Controls.Add(this.btnTeacher);
            this.SubpanelQLUser.Controls.Add(this.btnStudent);
            this.SubpanelQLUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubpanelQLUser.Location = new System.Drawing.Point(0, 41);
            this.SubpanelQLUser.Name = "SubpanelQLUser";
            this.SubpanelQLUser.Size = new System.Drawing.Size(200, 60);
            this.SubpanelQLUser.TabIndex = 3;
            this.SubpanelQLUser.Paint += new System.Windows.Forms.PaintEventHandler(this.SubpanelQLUser_Paint);
            // 
            // btnTeacher
            // 
            this.btnTeacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTeacher.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacher.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnTeacher.Location = new System.Drawing.Point(0, 30);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(200, 30);
            this.btnTeacher.TabIndex = 1;
            this.btnTeacher.Text = "Giảng Viên";
            this.btnTeacher.UseVisualStyleBackColor = true;
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudent.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnStudent.Location = new System.Drawing.Point(0, 0);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(200, 30);
            this.btnStudent.TabIndex = 0;
            this.btnStudent.Text = "Sinh Viên";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btUser
            // 
            this.btUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btUser.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUser.ForeColor = System.Drawing.Color.Brown;
            this.btUser.Location = new System.Drawing.Point(0, 0);
            this.btUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btUser.Name = "btUser";
            this.btUser.Size = new System.Drawing.Size(200, 41);
            this.btUser.TabIndex = 0;
            this.btUser.Text = "Quản lý User";
            this.btUser.UseVisualStyleBackColor = true;
            this.btUser.Click += new System.EventHandler(this.btUser_Click);
            // 
            // btManager
            // 
            this.btManager.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.btManager.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btManager.FlatAppearance.BorderSize = 0;
            this.btManager.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btManager.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btManager.Location = new System.Drawing.Point(0, 0);
            this.btManager.Margin = new System.Windows.Forms.Padding(0);
            this.btManager.Name = "btManager";
            this.btManager.Size = new System.Drawing.Size(200, 45);
            this.btManager.TabIndex = 0;
            this.btManager.Text = "Quản lý";
            this.btManager.UseVisualStyleBackColor = false;
            this.btManager.Click += new System.EventHandler(this.btManager_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtAuth);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(200, 551);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(666, 65);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(287, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "---- Chúc bạn một ngày tốt lành ----";
            // 
            // txtAuth
            // 
            this.txtAuth.AutoSize = true;
            this.txtAuth.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtAuth.ForeColor = System.Drawing.Color.AliceBlue;
            this.txtAuth.Location = new System.Drawing.Point(26, 25);
            this.txtAuth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtAuth.Name = "txtAuth";
            this.txtAuth.Size = new System.Drawing.Size(28, 13);
            this.txtAuth.TabIndex = 0;
            this.txtAuth.Text = "auth";
            this.txtAuth.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(666, 551);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(666, 551);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 616);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelBotton.ResumeLayout(false);
            this.panelBotton.PerformLayout();
            this.SubpanelSystem.ResumeLayout(false);
            this.SubpanelQL.ResumeLayout(false);
            this.SubpanelQLUser.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel SubpanelQL;
        private System.Windows.Forms.Button btUser;
        private System.Windows.Forms.Button btManager;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel SubpanelSystem;
        private System.Windows.Forms.Button btSystem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelBotton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel SubpanelQLUser;
        private System.Windows.Forms.Button btnTeacher;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.Button btTest;
        private System.Windows.Forms.Button btnReady;
        private System.Windows.Forms.Button btHistory;
        private System.Windows.Forms.Button btQuestion;
        private System.Windows.Forms.Button btSubject;
        private System.Windows.Forms.Button btClass;
        private System.Windows.Forms.Button btFaculty;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtBasis;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label txtAuth;
        private System.Windows.Forms.Label label2;
    }
}