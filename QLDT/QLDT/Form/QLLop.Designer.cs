
namespace QLDT
{
    partial class QLLop
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
            this.components = new System.ComponentModel.Container();
            this.btAdd = new System.Windows.Forms.Button();
            this.Option = new System.Windows.Forms.GroupBox();
            this.btReset = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstKhoa = new System.Windows.Forms.ListBox();
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tHITNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tHI_TN = new QLDT.THI_TN();
            this.txtBasis = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.khoaTableAdapter = new QLDT.THI_TNTableAdapters.khoaTableAdapter();
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lopTableAdapter = new QLDT.THI_TNTableAdapters.lopTableAdapter();
            this.tHITNBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lopBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Option.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHITNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHI_TN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHITNBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(54, 33);
            this.btAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(89, 30);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // Option
            // 
            this.Option.Controls.Add(this.btReset);
            this.Option.Controls.Add(this.btDelete);
            this.Option.Controls.Add(this.btEdit);
            this.Option.Controls.Add(this.btAdd);
            this.Option.Location = new System.Drawing.Point(488, 61);
            this.Option.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Option.Name = "Option";
            this.Option.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Option.Size = new System.Drawing.Size(340, 133);
            this.Option.TabIndex = 71;
            this.Option.TabStop = false;
            this.Option.Text = "Option";
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(226, 87);
            this.btReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(89, 30);
            this.btReset.TabIndex = 3;
            this.btReset.Text = "Làm mới";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(226, 33);
            this.btDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(89, 30);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(54, 87);
            this.btEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(89, 30);
            this.btEdit.TabIndex = 1;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(129, 165);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(264, 22);
            this.txtName.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 67;
            this.label3.Text = "Tên lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 66;
            this.label1.Text = "Mã lớp";
            // 
            // dataView
            // 
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataView.Location = new System.Drawing.Point(0, 0);
            this.dataView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataView.Name = "dataView";
            this.dataView.RowHeadersWidth = 51;
            this.dataView.RowTemplate.Height = 24;
            this.dataView.Size = new System.Drawing.Size(870, 390);
            this.dataView.TabIndex = 65;
            this.dataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellContentClick);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(129, 116);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(264, 22);
            this.txtID.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 73;
            this.label2.Text = "Mã khoa";
            // 
            // lstKhoa
            // 
            this.lstKhoa.DataSource = this.lopBindingSource1;
            this.lstKhoa.DisplayMember = "makh";
            this.lstKhoa.FormattingEnabled = true;
            this.lstKhoa.ItemHeight = 16;
            this.lstKhoa.Location = new System.Drawing.Point(129, 58);
            this.lstKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.lstKhoa.Name = "lstKhoa";
            this.lstKhoa.Size = new System.Drawing.Size(264, 36);
            this.lstKhoa.TabIndex = 75;
            this.lstKhoa.ValueMember = "makh";
            this.lstKhoa.SelectedIndexChanged += new System.EventHandler(this.lstKhoa_SelectedIndexChanged);
            // 
            // khoaBindingSource
            // 
            this.khoaBindingSource.DataMember = "khoa";
            this.khoaBindingSource.DataSource = this.tHITNBindingSource;
            // 
            // tHITNBindingSource
            // 
            this.tHITNBindingSource.DataSource = this.tHI_TN;
            this.tHITNBindingSource.Position = 0;
            // 
            // tHI_TN
            // 
            this.tHI_TN.DataSetName = "THI_TN";
            this.tHI_TN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtBasis
            // 
            this.txtBasis.AutoSize = true;
            this.txtBasis.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBasis.Location = new System.Drawing.Point(578, 42);
            this.txtBasis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtBasis.Name = "txtBasis";
            this.txtBasis.Size = new System.Drawing.Size(0, 15);
            this.txtBasis.TabIndex = 77;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(485, 42);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 76;
            this.label7.Text = "Thuộc khoa:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lstKhoa);
            this.splitContainer1.Panel2.Controls.Add(this.Option);
            this.splitContainer1.Panel2.Controls.Add(this.txtBasis);
            this.splitContainer1.Panel2.Controls.Add(this.txtID);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.txtName);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(870, 631);
            this.splitContainer1.SplitterDistance = 390;
            this.splitContainer1.TabIndex = 78;
            // 
            // khoaTableAdapter
            // 
            this.khoaTableAdapter.ClearBeforeFill = true;
            // 
            // lopBindingSource
            // 
            this.lopBindingSource.DataMember = "lop";
            this.lopBindingSource.DataSource = this.tHITNBindingSource;
            // 
            // lopTableAdapter
            // 
            this.lopTableAdapter.ClearBeforeFill = true;
            // 
            // tHITNBindingSource1
            // 
            this.tHITNBindingSource1.DataSource = this.tHI_TN;
            this.tHITNBindingSource1.Position = 0;
            // 
            // lopBindingSource1
            // 
            this.lopBindingSource1.DataMember = "lop";
            this.lopBindingSource1.DataSource = this.tHITNBindingSource1;
            // 
            // QLLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 631);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QLLop";
            this.Text = "QLLop";
            this.Load += new System.EventHandler(this.QLLop_Load);
            this.Option.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHITNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHI_TN)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHITNBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.GroupBox Option;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstKhoa;
        private System.Windows.Forms.Label txtBasis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.BindingSource tHITNBindingSource;
        private THI_TN tHI_TN;
        private System.Windows.Forms.BindingSource khoaBindingSource;
        private THI_TNTableAdapters.khoaTableAdapter khoaTableAdapter;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private THI_TNTableAdapters.lopTableAdapter lopTableAdapter;
        private System.Windows.Forms.BindingSource lopBindingSource1;
        private System.Windows.Forms.BindingSource tHITNBindingSource1;
    }
}