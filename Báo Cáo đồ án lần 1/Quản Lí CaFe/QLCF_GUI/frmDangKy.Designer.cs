namespace QLCF_GUI
{
    partial class frmDangKy
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
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.notice = new System.Windows.Forms.Label();
            this.rdoQuanLy = new System.Windows.Forms.RadioButton();
            this.rdoNhanVien = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_Ten = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(16, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Họ và tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(16, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(16, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật khẩu";
            // 
            // txt_user
            // 
            this.txt_user.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.Location = new System.Drawing.Point(195, 142);
            this.txt_user.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(423, 30);
            this.txt_user.TabIndex = 6;
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(195, 204);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(423, 30);
            this.txt_pass.TabIndex = 7;
            // 
            // notice
            // 
            this.notice.AutoSize = true;
            this.notice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notice.Location = new System.Drawing.Point(240, 391);
            this.notice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.notice.Name = "notice";
            this.notice.Size = new System.Drawing.Size(0, 36);
            this.notice.TabIndex = 9;
            // 
            // rdoQuanLy
            // 
            this.rdoQuanLy.AutoSize = true;
            this.rdoQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoQuanLy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdoQuanLy.Location = new System.Drawing.Point(247, 267);
            this.rdoQuanLy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoQuanLy.Name = "rdoQuanLy";
            this.rdoQuanLy.Size = new System.Drawing.Size(111, 35);
            this.rdoQuanLy.TabIndex = 10;
            this.rdoQuanLy.Text = "Admin";
            this.rdoQuanLy.UseVisualStyleBackColor = true;
            // 
            // rdoNhanVien
            // 
            this.rdoNhanVien.AutoSize = true;
            this.rdoNhanVien.Checked = true;
            this.rdoNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNhanVien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdoNhanVien.Location = new System.Drawing.Point(408, 266);
            this.rdoNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoNhanVien.Name = "rdoNhanVien";
            this.rdoNhanVien.Size = new System.Drawing.Size(157, 35);
            this.rdoNhanVien.TabIndex = 11;
            this.rdoNhanVien.TabStop = true;
            this.rdoNhanVien.Text = "Nhân viên";
            this.rdoNhanVien.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(16, 266);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 37);
            this.label5.TabIndex = 12;
            this.label5.Text = "Chức vụ";
            // 
            // btnDK
            // 
            this.btnDK.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDK.Location = new System.Drawing.Point(195, 335);
            this.btnDK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDK.Name = "btnDK";
            this.btnDK.Size = new System.Drawing.Size(424, 66);
            this.btnDK.TabIndex = 13;
            this.btnDK.Text = "ĐĂNG KÝ";
            this.btnDK.UseVisualStyleBackColor = true;
            this.btnDK.Click += new System.EventHandler(this.btnDK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(211, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(367, 49);
            this.label4.TabIndex = 14;
            this.label4.Text = "ĐĂNG KÝ TÀI KHOẢN";
            // 
            // cbo_Ten
            // 
            this.cbo_Ten.FormattingEnabled = true;
            this.cbo_Ten.Location = new System.Drawing.Point(195, 87);
            this.cbo_Ten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbo_Ten.Name = "cbo_Ten";
            this.cbo_Ten.Size = new System.Drawing.Size(423, 24);
            this.cbo_Ten.TabIndex = 15;
            // 
            // frmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(649, 431);
            this.Controls.Add(this.cbo_Ten);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rdoNhanVien);
            this.Controls.Add(this.rdoQuanLy);
            this.Controls.Add(this.notice);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng kí tài khoản";
            this.Load += new System.EventHandler(this.frmDangKy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label notice;
        private System.Windows.Forms.RadioButton rdoQuanLy;
        private System.Windows.Forms.RadioButton rdoNhanVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_Ten;
    }
}