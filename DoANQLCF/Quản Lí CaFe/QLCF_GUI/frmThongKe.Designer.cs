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
            this.btnThongKeNgay = new System.Windows.Forms.Button();
            this.btnThongKeThang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgVThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVThongKe
            // 
            this.dgVThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgVThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVThongKe.Location = new System.Drawing.Point(15, 188);
            this.dgVThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgVThongKe.Name = "dgVThongKe";
            this.dgVThongKe.RowHeadersWidth = 51;
            this.dgVThongKe.RowTemplate.Height = 24;
            this.dgVThongKe.Size = new System.Drawing.Size(1843, 334);
            this.dgVThongKe.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(20, 544);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng doanh thu : ";
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.AutoSize = true;
            this.lblDoanhThu.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhThu.ForeColor = System.Drawing.Color.Red;
            this.lblDoanhThu.Location = new System.Drawing.Point(229, 544);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(81, 33);
            this.lblDoanhThu.TabIndex = 2;
            this.lblDoanhThu.Text = "label2";
            // 
            // dTNgayKT
            // 
            this.dTNgayKT.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTNgayKT.Location = new System.Drawing.Point(107, 123);
            this.dTNgayKT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dTNgayKT.Name = "dTNgayKT";
            this.dTNgayKT.Size = new System.Drawing.Size(420, 40);
            this.dTNgayKT.TabIndex = 4;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.ForeColor = System.Drawing.Color.Red;
            this.lblSoLuong.Location = new System.Drawing.Point(229, 578);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(81, 33);
            this.lblSoLuong.TabIndex = 7;
            this.lblSoLuong.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(20, 578);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 33);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tổng Số lượng :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(19, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 33);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(24, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 33);
            this.label6.TabIndex = 11;
            this.label6.Text = "Theo";
            // 
            // cboNgayThangNam
            // 
            this.cboNgayThangNam.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNgayThangNam.FormattingEnabled = true;
            this.cboNgayThangNam.Location = new System.Drawing.Point(107, 75);
            this.cboNgayThangNam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboNgayThangNam.Name = "cboNgayThangNam";
            this.cboNgayThangNam.Size = new System.Drawing.Size(420, 40);
            this.cboNgayThangNam.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(17, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(389, 49);
            this.label7.TabIndex = 11;
            this.label7.Text = "BÁO CÁO DOANH THU";
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnThongKe.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThongKe.Location = new System.Drawing.Point(1609, 560);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(248, 55);
            this.btnThongKe.TabIndex = 13;
            this.btnThongKe.Text = "THỐNG KÊ";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnThongKeNgay
            // 
            this.btnThongKeNgay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnThongKeNgay.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeNgay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThongKeNgay.Location = new System.Drawing.Point(1610, 13);
            this.btnThongKeNgay.Margin = new System.Windows.Forms.Padding(4);
            this.btnThongKeNgay.Name = "btnThongKeNgay";
            this.btnThongKeNgay.Size = new System.Drawing.Size(248, 55);
            this.btnThongKeNgay.TabIndex = 14;
            this.btnThongKeNgay.Text = "Thống kê ngày";
            this.btnThongKeNgay.UseVisualStyleBackColor = false;
            // 
            // btnThongKeThang
            // 
            this.btnThongKeThang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnThongKeThang.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeThang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThongKeThang.Location = new System.Drawing.Point(1609, 79);
            this.btnThongKeThang.Margin = new System.Windows.Forms.Padding(4);
            this.btnThongKeThang.Name = "btnThongKeThang";
            this.btnThongKeThang.Size = new System.Drawing.Size(248, 55);
            this.btnThongKeThang.TabIndex = 15;
            this.btnThongKeThang.Text = "Thống kê tháng";
            this.btnThongKeThang.UseVisualStyleBackColor = false;
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1872, 630);
            this.Controls.Add(this.btnThongKeThang);
            this.Controls.Add(this.btnThongKeNgay);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button btnThongKeNgay;
        private System.Windows.Forms.Button btnThongKeThang;
    }
}