namespace QLCF_GUI
{
    partial class frmThongKe
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
            this.dgVThongKe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.dTNgayKT = new System.Windows.Forms.DateTimePicker();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cboNgayThangNam = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnThongkeDoanhSoNhanVien = new System.Windows.Forms.Button();
            this.btnBackUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgVThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVThongKe
            // 
            this.dgVThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgVThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVThongKe.Location = new System.Drawing.Point(11, 153);
            this.dgVThongKe.Margin = new System.Windows.Forms.Padding(2);
            this.dgVThongKe.Name = "dgVThongKe";
            this.dgVThongKe.RowHeadersWidth = 51;
            this.dgVThongKe.RowTemplate.Height = 24;
            this.dgVThongKe.Size = new System.Drawing.Size(1382, 271);
            this.dgVThongKe.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 442);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng doanh thu : ";
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.AutoSize = true;
            this.lblDoanhThu.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhThu.ForeColor = System.Drawing.Color.Red;
            this.lblDoanhThu.Location = new System.Drawing.Point(172, 442);
            this.lblDoanhThu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(0, 26);
            this.lblDoanhThu.TabIndex = 2;
            // 
            // dTNgayKT
            // 
            this.dTNgayKT.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTNgayKT.Location = new System.Drawing.Point(80, 109);
            this.dTNgayKT.Margin = new System.Windows.Forms.Padding(2);
            this.dTNgayKT.Name = "dTNgayKT";
            this.dTNgayKT.Size = new System.Drawing.Size(316, 33);
            this.dTNgayKT.TabIndex = 4;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.ForeColor = System.Drawing.Color.Red;
            this.lblSoLuong.Location = new System.Drawing.Point(172, 470);
            this.lblSoLuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(0, 26);
            this.lblSoLuong.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(15, 470);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tổng Số lượng :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(15, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(18, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "Theo";
            // 
            // cboNgayThangNam
            // 
            this.cboNgayThangNam.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNgayThangNam.FormattingEnabled = true;
            this.cboNgayThangNam.Location = new System.Drawing.Point(80, 61);
            this.cboNgayThangNam.Name = "cboNgayThangNam";
            this.cboNgayThangNam.Size = new System.Drawing.Size(316, 34);
            this.cboNgayThangNam.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(13, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(314, 39);
            this.label7.TabIndex = 11;
            this.label7.Text = "BÁO CÁO DOANH THU";
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnThongKe.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThongKe.Location = new System.Drawing.Point(1207, 455);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(186, 45);
            this.btnThongKe.TabIndex = 13;
            this.btnThongKe.Text = "THỐNG KÊ";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnThongkeDoanhSoNhanVien
            // 
            this.btnThongkeDoanhSoNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnThongkeDoanhSoNhanVien.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongkeDoanhSoNhanVien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThongkeDoanhSoNhanVien.Location = new System.Drawing.Point(985, 53);
            this.btnThongkeDoanhSoNhanVien.Name = "btnThongkeDoanhSoNhanVien";
            this.btnThongkeDoanhSoNhanVien.Size = new System.Drawing.Size(407, 45);
            this.btnThongkeDoanhSoNhanVien.TabIndex = 14;
            this.btnThongkeDoanhSoNhanVien.Text = "Thống kê Doanh Số Nhân Viên";
            this.btnThongkeDoanhSoNhanVien.UseVisualStyleBackColor = false;
            this.btnThongkeDoanhSoNhanVien.Click += new System.EventHandler(this.btnThongkeDoanhSoNhanVien_Click);
            // 
            // btnBackUp
            // 
            this.btnBackUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBackUp.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackUp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBackUp.Location = new System.Drawing.Point(985, 103);
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.Size = new System.Drawing.Size(407, 45);
            this.btnBackUp.TabIndex = 13;
            this.btnBackUp.Text = "Sao lưu dữ liệu hôm nay";
            this.btnBackUp.UseVisualStyleBackColor = false;
            this.btnBackUp.Click += new System.EventHandler(this.btnBackUp_Click);
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1404, 512);
            this.Controls.Add(this.btnThongkeDoanhSoNhanVien);
            this.Controls.Add(this.btnBackUp);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.cboNgayThangNam);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dTNgayKT);
            this.Controls.Add(this.lblDoanhThu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgVThongKe);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo doanh thu";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVThongKe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDoanhThu;
        private System.Windows.Forms.DateTimePicker dTNgayKT;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cboNgayThangNam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnThongkeDoanhSoNhanVien;
        private System.Windows.Forms.Button btnBackUp;
    }
}