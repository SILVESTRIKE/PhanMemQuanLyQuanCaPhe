﻿namespace QLCF_GUI
{
    partial class frmDatHang
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSLuong = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.dgVMon = new System.Windows.Forms.DataGridView();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTra = new System.Windows.Forms.Button();
            this.btnSinhTo = new System.Windows.Forms.Button();
            this.lstMon = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCaPhe = new System.Windows.Forms.Button();
            this.btnKhac = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVMon)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(849, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số lượng:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(849, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ghi chú :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtSLuong
            // 
            this.txtSLuong.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLuong.Location = new System.Drawing.Point(853, 101);
            this.txtSLuong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSLuong.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtSLuong.Name = "txtSLuong";
            this.txtSLuong.Size = new System.Drawing.Size(60, 37);
            this.txtSLuong.TabIndex = 17;
            this.txtSLuong.ValueChanged += new System.EventHandler(this.txtSLuong_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 39);
            this.label3.TabIndex = 23;
            this.label3.Text = "ĐẶT HÀNG";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(853, 180);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(188, 237);
            this.txtGhiChu.TabIndex = 8;
            this.txtGhiChu.TextChanged += new System.EventHandler(this.txtGhiChu_TextChanged);
            // 
            // dgVMon
            // 
            this.dgVMon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgVMon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.dgVMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVMon.Location = new System.Drawing.Point(10, 69);
            this.dgVMon.Name = "dgVMon";
            this.dgVMon.ReadOnly = true;
            this.dgVMon.RowHeadersWidth = 51;
            this.dgVMon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVMon.Size = new System.Drawing.Size(827, 608);
            this.dgVMon.TabIndex = 0;
            this.dgVMon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVMon_CellClick);
            this.dgVMon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVMon_CellContentClick);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnThanhToan.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThanhToan.Location = new System.Drawing.Point(853, 431);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(187, 45);
            this.btnThanhToan.TabIndex = 28;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1305, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "LOẠI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnTra
            // 
            this.btnTra.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTra.Location = new System.Drawing.Point(1310, 193);
            this.btnTra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTra.Name = "btnTra";
            this.btnTra.Size = new System.Drawing.Size(121, 76);
            this.btnTra.TabIndex = 29;
            this.btnTra.Text = "TRÀ";
            this.btnTra.UseVisualStyleBackColor = true;
            this.btnTra.Click += new System.EventHandler(this.btnTra_Click);
            // 
            // btnSinhTo
            // 
            this.btnSinhTo.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinhTo.Location = new System.Drawing.Point(1310, 288);
            this.btnSinhTo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSinhTo.Name = "btnSinhTo";
            this.btnSinhTo.Size = new System.Drawing.Size(121, 76);
            this.btnSinhTo.TabIndex = 29;
            this.btnSinhTo.Text = "SINH TỐ";
            this.btnSinhTo.UseVisualStyleBackColor = true;
            this.btnSinhTo.Click += new System.EventHandler(this.btnSinhTo_Click);
            // 
            // lstMon
            // 
            this.lstMon.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMon.FormattingEnabled = true;
            this.lstMon.ItemHeight = 22;
            this.lstMon.Location = new System.Drawing.Point(1057, 101);
            this.lstMon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstMon.Name = "lstMon";
            this.lstMon.Size = new System.Drawing.Size(238, 554);
            this.lstMon.TabIndex = 30;
            this.lstMon.SelectedIndexChanged += new System.EventHandler(this.lstMon_SelectedIndexChanged);
            this.lstMon.DoubleClick += new System.EventHandler(this.lstMon_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1051, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "MÓN";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCaPhe
            // 
            this.btnCaPhe.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaPhe.Location = new System.Drawing.Point(1310, 101);
            this.btnCaPhe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCaPhe.Name = "btnCaPhe";
            this.btnCaPhe.Size = new System.Drawing.Size(121, 76);
            this.btnCaPhe.TabIndex = 29;
            this.btnCaPhe.Text = "CÀ PHÊ";
            this.btnCaPhe.UseVisualStyleBackColor = true;
            this.btnCaPhe.Click += new System.EventHandler(this.btnCaPhe_Click);
            // 
            // btnKhac
            // 
            this.btnKhac.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhac.Location = new System.Drawing.Point(1310, 381);
            this.btnKhac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKhac.Name = "btnKhac";
            this.btnKhac.Size = new System.Drawing.Size(121, 76);
            this.btnKhac.TabIndex = 29;
            this.btnKhac.Text = "KHÁC";
            this.btnKhac.UseVisualStyleBackColor = true;
            this.btnKhac.Click += new System.EventHandler(this.btnKhac_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(927, 100);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(112, 37);
            this.btnXacNhan.TabIndex = 29;
            this.btnXacNhan.Text = "XÁC NHẬN";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1310, 474);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 203);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "LÀM MỚI";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnXoa.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.Location = new System.Drawing.Point(852, 482);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(187, 45);
            this.btnXoa.TabIndex = 28;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.XoaItem_Click);
            // 
            // frmDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1155, 687);
            this.Controls.Add(this.lstMon);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnKhac);
            this.Controls.Add(this.btnSinhTo);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btnCaPhe);
            this.Controls.Add(this.btnTra);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSLuong);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgVMon);
            this.Name = "frmDatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E";
            this.Load += new System.EventHandler(this.frmDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txtSLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.DataGridView dgVMon;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTra;
        private System.Windows.Forms.Button btnSinhTo;
        private System.Windows.Forms.ListBox lstMon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCaPhe;
        private System.Windows.Forms.Button btnKhac;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnXoa;
    }
}