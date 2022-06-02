
namespace QLDT
{
    partial class DiemThi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.NumberRight = new System.Windows.Forms.Label();
            this.NumberFail = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHÚC MỪNG BẠN ĐÃ HOÀN THÀNH BÀI THI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Điểm :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số câu đúng : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số câu sai : ";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.Score.Location = new System.Drawing.Point(167, 78);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(54, 21);
            this.Score.TabIndex = 4;
            this.Score.Text = "Score";
            // 
            // NumberRight
            // 
            this.NumberRight.AutoSize = true;
            this.NumberRight.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.NumberRight.Location = new System.Drawing.Point(167, 133);
            this.NumberRight.Name = "NumberRight";
            this.NumberRight.Size = new System.Drawing.Size(110, 21);
            this.NumberRight.TabIndex = 5;
            this.NumberRight.Text = "NumberRight";
            // 
            // NumberFail
            // 
            this.NumberFail.AutoSize = true;
            this.NumberFail.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.NumberFail.Location = new System.Drawing.Point(167, 187);
            this.NumberFail.Name = "NumberFail";
            this.NumberFail.Size = new System.Drawing.Size(97, 21);
            this.NumberFail.TabIndex = 6;
            this.NumberFail.Text = "NumberFail";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(322, 112);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 65);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // DiemThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 247);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.NumberFail);
            this.Controls.Add(this.NumberRight);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DiemThi";
            this.Text = "DiemThi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label NumberRight;
        private System.Windows.Forms.Label NumberFail;
        private System.Windows.Forms.Button btnExit;
    }
}