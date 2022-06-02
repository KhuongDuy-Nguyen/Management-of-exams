
namespace QLDT
{
    partial class InPhieuDiem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Option = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cblanthi = new System.Windows.Forms.ComboBox();
            this.cbmonhoc = new System.Windows.Forms.ComboBox();
            this.cbclass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.btIn = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.Option.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Option);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 201);
            this.panel1.TabIndex = 77;
            // 
            // Option
            // 
            this.Option.Controls.Add(this.label2);
            this.Option.Controls.Add(this.cblanthi);
            this.Option.Controls.Add(this.cbmonhoc);
            this.Option.Controls.Add(this.cbclass);
            this.Option.Controls.Add(this.label1);
            this.Option.Controls.Add(this.label6);
            this.Option.Controls.Add(this.btSearch);
            this.Option.Controls.Add(this.btIn);
            this.Option.Location = new System.Drawing.Point(121, 11);
            this.Option.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Option.Name = "Option";
            this.Option.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Option.Size = new System.Drawing.Size(620, 188);
            this.Option.TabIndex = 85;
            this.Option.TabStop = false;
            this.Option.Text = "Option";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Lần thi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cblanthi
            // 
            this.cblanthi.FormattingEnabled = true;
            this.cblanthi.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cblanthi.Location = new System.Drawing.Point(102, 126);
            this.cblanthi.Name = "cblanthi";
            this.cblanthi.Size = new System.Drawing.Size(75, 24);
            this.cblanthi.TabIndex = 10;
            // 
            // cbmonhoc
            // 
            this.cbmonhoc.FormattingEnabled = true;
            this.cbmonhoc.Location = new System.Drawing.Point(102, 87);
            this.cbmonhoc.Name = "cbmonhoc";
            this.cbmonhoc.Size = new System.Drawing.Size(401, 24);
            this.cbmonhoc.TabIndex = 9;
            // 
            // cbclass
            // 
            this.cbclass.FormattingEnabled = true;
            this.cbclass.Location = new System.Drawing.Point(102, 44);
            this.cbclass.Name = "cbclass";
            this.cbclass.Size = new System.Drawing.Size(401, 24);
            this.cbclass.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên môn học";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tên lớp";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(529, 65);
            this.btSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(72, 31);
            this.btSearch.TabIndex = 4;
            this.btSearch.Text = "Tìm";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btIn
            // 
            this.btIn.Location = new System.Drawing.Point(242, 154);
            this.btIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(89, 30);
            this.btIn.TabIndex = 3;
            this.btIn.Text = "In";
            this.btIn.UseVisualStyleBackColor = true;
            this.btIn.Click += new System.EventHandler(this.btIn_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 201);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(867, 419);
            this.reportViewer1.TabIndex = 80;
            // 
            // dataView1
            // 
            this.dataView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView1.Location = new System.Drawing.Point(3, 624);
            this.dataView1.Name = "dataView1";
            this.dataView1.RowHeadersWidth = 51;
            this.dataView1.RowTemplate.Height = 24;
            this.dataView1.Size = new System.Drawing.Size(863, 202);
            this.dataView1.TabIndex = 81;
            // 
            // InPhieuDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 620);
            this.Controls.Add(this.dataView1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(885, 667);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(885, 667);
            this.Name = "InPhieuDiem";
            this.Text = "InPhieuDiem";
            this.Load += new System.EventHandler(this.InPhieuDiem_Load);
            this.panel1.ResumeLayout(false);
            this.Option.ResumeLayout(false);
            this.Option.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox Option;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cblanthi;
        private System.Windows.Forms.ComboBox cbmonhoc;
        private System.Windows.Forms.ComboBox cbclass;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DataGridView dataView1;
    }
}