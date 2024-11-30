namespace QLCF_GUI
{
    partial class ListDonHang
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
            this.dgVListHoaDon = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLuuGiaTri = new System.Windows.Forms.Button();
            this.dgvCT = new System.Windows.Forms.DataGridView();
            this.dgvCongThuc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgVListHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVListHoaDon
            // 
            this.dgVListHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgVListHoaDon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.dgVListHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVListHoaDon.Location = new System.Drawing.Point(16, 144);
            this.dgVListHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.dgVListHoaDon.Name = "dgVListHoaDon";
            this.dgVListHoaDon.RowHeadersWidth = 51;
            this.dgVListHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVListHoaDon.Size = new System.Drawing.Size(656, 564);
            this.dgVListHoaDon.TabIndex = 0;
            this.dgVListHoaDon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVListHoaDon_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 49);
            this.label3.TabIndex = 23;
            this.label3.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(294, 35);
            this.label4.TabIndex = 28;
            this.label4.Text = "List Hóa Đơn trong ngày";
            // 
            // dgvChiTietHoaDon
            // 
            this.dgvChiTietHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietHoaDon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHoaDon.Location = new System.Drawing.Point(704, 144);
            this.dgvChiTietHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            this.dgvChiTietHoaDon.RowHeadersWidth = 51;
            this.dgvChiTietHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietHoaDon.Size = new System.Drawing.Size(656, 564);
            this.dgvChiTietHoaDon.TabIndex = 29;
            this.dgvChiTietHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietHoaDon_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(716, 105);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 35);
            this.label6.TabIndex = 30;
            this.label6.Text = "Chi tiết Hóa đơn";
            // 
            // btnLuuGiaTri
            // 
            this.btnLuuGiaTri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnLuuGiaTri.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuGiaTri.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLuuGiaTri.Location = new System.Drawing.Point(1409, 653);
            this.btnLuuGiaTri.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuuGiaTri.Name = "btnLuuGiaTri";
            this.btnLuuGiaTri.Size = new System.Drawing.Size(248, 55);
            this.btnLuuGiaTri.TabIndex = 31;
            this.btnLuuGiaTri.Text = "Lưu Giá Trị";
            this.btnLuuGiaTri.UseVisualStyleBackColor = false;
            this.btnLuuGiaTri.Click += new System.EventHandler(this.btnLuuGiaTri_Click);
            // 
            // dgvCT
            // 
            this.dgvCT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCT.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.dgvCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCT.Location = new System.Drawing.Point(1389, 144);
            this.dgvCT.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCT.Name = "dgvCT";
            this.dgvCT.RowHeadersWidth = 51;
            this.dgvCT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCT.Size = new System.Drawing.Size(483, 452);
            this.dgvCT.TabIndex = 32;
            // 
            // dgvCongThuc
            // 
            this.dgvCongThuc.AutoSize = true;
            this.dgvCongThuc.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCongThuc.ForeColor = System.Drawing.Color.White;
            this.dgvCongThuc.Location = new System.Drawing.Point(1392, 105);
            this.dgvCongThuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dgvCongThuc.Name = "dgvCongThuc";
            this.dgvCongThuc.Size = new System.Drawing.Size(134, 35);
            this.dgvCongThuc.TabIndex = 33;
            this.dgvCongThuc.Text = "Công thức";
            // 
            // ListDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1885, 734);
            this.Controls.Add(this.dgvCongThuc);
            this.Controls.Add(this.dgvCT);
            this.Controls.Add(this.btnLuuGiaTri);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvChiTietHoaDon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgVListHoaDon);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CÔNG THỨC";
            ((System.ComponentModel.ISupportInitialize)(this.dgVListHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVListHoaDon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvChiTietHoaDon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLuuGiaTri;
        private System.Windows.Forms.DataGridView dgvCT;
        private System.Windows.Forms.Label dgvCongThuc;
    }
}