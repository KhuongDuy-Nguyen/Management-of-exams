
namespace QLDT
{
    partial class LichSuThi
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
            this.dataView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Option = new System.Windows.Forms.GroupBox();
            this.btReset = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearchID_Student = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.txtAuth = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.panel1.SuspendLayout();
            this.Option.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataView
            // 
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataView.Location = new System.Drawing.Point(0, 0);
            this.dataView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataView.Name = "dataView";
            this.dataView.RowHeadersWidth = 51;
            this.dataView.RowTemplate.Height = 24;
            this.dataView.Size = new System.Drawing.Size(867, 624);
            this.dataView.TabIndex = 41;
            this.dataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtAuth);
            this.panel1.Controls.Add(this.Option);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 420);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 194);
            this.panel1.TabIndex = 42;
            // 
            // Option
            // 
            this.Option.Controls.Add(this.btReset);
            this.Option.Controls.Add(this.label6);
            this.Option.Controls.Add(this.txtSearchID_Student);
            this.Option.Controls.Add(this.btSearch);
            this.Option.Location = new System.Drawing.Point(93, 33);
            this.Option.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Option.Name = "Option";
            this.Option.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Option.Size = new System.Drawing.Size(715, 81);
            this.Option.TabIndex = 50;
            this.Option.TabStop = false;
            this.Option.Text = "Option";
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(585, 32);
            this.btReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(100, 28);
            this.btReset.TabIndex = 7;
            this.btReset.Text = "Làm mới";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mã sinh viên";
            // 
            // txtSearchID_Student
            // 
            this.txtSearchID_Student.Location = new System.Drawing.Point(163, 34);
            this.txtSearchID_Student.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchID_Student.Name = "txtSearchID_Student";
            this.txtSearchID_Student.Size = new System.Drawing.Size(289, 22);
            this.txtSearchID_Student.TabIndex = 5;
            this.txtSearchID_Student.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(481, 31);
            this.btSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(72, 31);
            this.btSearch.TabIndex = 4;
            this.btSearch.Text = "Tìm";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // txtAuth
            // 
            this.txtAuth.AutoSize = true;
            this.txtAuth.Location = new System.Drawing.Point(12, 16);
            this.txtAuth.Name = "txtAuth";
            this.txtAuth.Size = new System.Drawing.Size(46, 17);
            this.txtAuth.TabIndex = 51;
            this.txtAuth.Text = "label1";
            this.txtAuth.Visible = false;
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(13, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(46, 17);
            this.txtName.TabIndex = 52;
            this.txtName.Text = "label1";
            this.txtName.Visible = false;
            // 
            // LichSuThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 614);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(885, 661);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(885, 661);
            this.Name = "LichSuThi";
            this.Text = "LST";
            this.Load += new System.EventHandler(this.LichSuThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Option.ResumeLayout(false);
            this.Option.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox Option;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearchID_Student;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Label txtAuth;
        private System.Windows.Forms.Label txtName;
    }
}