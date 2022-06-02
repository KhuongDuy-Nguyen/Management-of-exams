
namespace QLDT
{
    partial class QLDeThi
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
            this.Option = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearchID = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.Result_A = new System.Windows.Forms.RadioButton();
            this.Result_C = new System.Windows.Forms.RadioButton();
            this.Result_D = new System.Windows.Forms.RadioButton();
            this.Result_B = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstLevel = new System.Windows.Forms.ComboBox();
            this.Option.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Option
            // 
            this.Option.Controls.Add(this.label6);
            this.Option.Controls.Add(this.txtSearchID);
            this.Option.Controls.Add(this.btSearch);
            this.Option.Controls.Add(this.btReset);
            this.Option.Controls.Add(this.btDelete);
            this.Option.Controls.Add(this.btEdit);
            this.Option.Controls.Add(this.btAdd);
            this.Option.Location = new System.Drawing.Point(494, 63);
            this.Option.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Option.Name = "Option";
            this.Option.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Option.Size = new System.Drawing.Size(343, 181);
            this.Option.TabIndex = 34;
            this.Option.TabStop = false;
            this.Option.Text = "Option";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mã môn học";
            // 
            // txtSearchID
            // 
            this.txtSearchID.Location = new System.Drawing.Point(104, 21);
            this.txtSearchID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(143, 22);
            this.txtSearchID.TabIndex = 5;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(253, 17);
            this.btSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(72, 31);
            this.btSearch.TabIndex = 4;
            this.btSearch.Text = "Tìm";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(211, 132);
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
            this.btDelete.Location = new System.Drawing.Point(211, 78);
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
            this.btEdit.Location = new System.Drawing.Point(39, 132);
            this.btEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(89, 30);
            this.btEdit.TabIndex = 1;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(39, 78);
            this.btAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(89, 30);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Trình độ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Câu hỏi";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nội dung";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã môn học";
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
            this.dataView.Size = new System.Drawing.Size(870, 346);
            this.dataView.TabIndex = 25;
            this.dataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellContentClick);
            // 
            // Result_A
            // 
            this.Result_A.AutoSize = true;
            this.Result_A.Location = new System.Drawing.Point(66, 175);
            this.Result_A.Margin = new System.Windows.Forms.Padding(4);
            this.Result_A.Name = "Result_A";
            this.Result_A.Size = new System.Drawing.Size(38, 21);
            this.Result_A.TabIndex = 35;
            this.Result_A.TabStop = true;
            this.Result_A.Text = "A";
            this.Result_A.UseVisualStyleBackColor = true;
            // 
            // Result_C
            // 
            this.Result_C.AutoSize = true;
            this.Result_C.Location = new System.Drawing.Point(65, 222);
            this.Result_C.Margin = new System.Windows.Forms.Padding(4);
            this.Result_C.Name = "Result_C";
            this.Result_C.Size = new System.Drawing.Size(38, 21);
            this.Result_C.TabIndex = 36;
            this.Result_C.TabStop = true;
            this.Result_C.Text = "C";
            this.Result_C.UseVisualStyleBackColor = true;
            this.Result_C.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Result_D
            // 
            this.Result_D.AutoSize = true;
            this.Result_D.Location = new System.Drawing.Point(254, 221);
            this.Result_D.Margin = new System.Windows.Forms.Padding(4);
            this.Result_D.Name = "Result_D";
            this.Result_D.Size = new System.Drawing.Size(39, 21);
            this.Result_D.TabIndex = 37;
            this.Result_D.TabStop = true;
            this.Result_D.Text = "D";
            this.Result_D.UseVisualStyleBackColor = true;
            // 
            // Result_B
            // 
            this.Result_B.AutoSize = true;
            this.Result_B.Location = new System.Drawing.Point(254, 175);
            this.Result_B.Margin = new System.Windows.Forms.Padding(4);
            this.Result_B.Name = "Result_B";
            this.Result_B.Size = new System.Drawing.Size(38, 21);
            this.Result_B.TabIndex = 38;
            this.Result_B.TabStop = true;
            this.Result_B.Text = "B";
            this.Result_B.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Đáp án";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(110, 63);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(94, 22);
            this.txtID.TabIndex = 41;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(272, 60);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(94, 22);
            this.txtNumber.TabIndex = 42;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(108, 122);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(258, 22);
            this.txtContent.TabIndex = 43;
            this.txtContent.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(111, 175);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(124, 22);
            this.txtA.TabIndex = 44;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(299, 175);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(124, 22);
            this.txtB.TabIndex = 45;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(110, 222);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(124, 22);
            this.txtC.TabIndex = 46;
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(299, 221);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(124, 22);
            this.txtD.TabIndex = 47;
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
            this.splitContainer1.Panel2.Controls.Add(this.lstLevel);
            this.splitContainer1.Panel2.Controls.Add(this.txtID);
            this.splitContainer1.Panel2.Controls.Add(this.txtD);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.txtC);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.txtB);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.txtA);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.txtContent);
            this.splitContainer1.Panel2.Controls.Add(this.Option);
            this.splitContainer1.Panel2.Controls.Add(this.txtNumber);
            this.splitContainer1.Panel2.Controls.Add(this.Result_A);
            this.splitContainer1.Panel2.Controls.Add(this.Result_C);
            this.splitContainer1.Panel2.Controls.Add(this.Result_D);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.Result_B);
            this.splitContainer1.Size = new System.Drawing.Size(870, 631);
            this.splitContainer1.SplitterDistance = 346;
            this.splitContainer1.TabIndex = 48;
            // 
            // lstLevel
            // 
            this.lstLevel.FormattingEnabled = true;
            this.lstLevel.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.lstLevel.Location = new System.Drawing.Point(108, 91);
            this.lstLevel.Name = "lstLevel";
            this.lstLevel.Size = new System.Drawing.Size(258, 24);
            this.lstLevel.TabIndex = 48;
            this.lstLevel.SelectedIndexChanged += new System.EventHandler(this.lstLevel_SelectedIndexChanged);
            // 
            // QLDeThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 631);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QLDeThi";
            this.Text = "QLDeThi";
            this.Load += new System.EventHandler(this.QLDeThi_Load);
            this.Option.ResumeLayout(false);
            this.Option.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Option;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearchID;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.RadioButton Result_A;
        private System.Windows.Forms.RadioButton Result_C;
        private System.Windows.Forms.RadioButton Result_D;
        private System.Windows.Forms.RadioButton Result_B;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox lstLevel;
    }
}