namespace QLCF_GUI
{
    partial class frmCongThuc
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
            this.dgVCongThuc = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nrSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.PictureBox();
            this.btnSua = new System.Windows.Forms.PictureBox();
            this.btnThem = new System.Windows.Forms.PictureBox();
            this.cboTenMon = new System.Windows.Forms.ComboBox();
            this.cboTenNgLieu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_DVT = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgVCongThuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVCongThuc
            // 
            this.dgVCongThuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgVCongThuc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.dgVCongThuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVCongThuc.Location = new System.Drawing.Point(16, 95);
            this.dgVCongThuc.Margin = new System.Windows.Forms.Padding(4);
            this.dgVCongThuc.Name = "dgVCongThuc";
            this.dgVCongThuc.RowHeadersWidth = 51;
            this.dgVCongThuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVCongThuc.Size = new System.Drawing.Size(1275, 613);
            this.dgVCongThuc.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1327, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên nguyên liệu: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1333, 277);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 37);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số lượng:";
            // 
            // nrSoLuong
            // 
            this.nrSoLuong.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrSoLuong.Location = new System.Drawing.Point(1565, 277);
            this.nrSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nrSoLuong.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nrSoLuong.Name = "nrSoLuong";
            this.nrSoLuong.Size = new System.Drawing.Size(277, 44);
            this.nrSoLuong.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 49);
            this.label3.TabIndex = 23;
            this.label3.Text = "CÔNG THỨC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1327, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên món:";
            // 
            // btnXoa
            // 
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Image = global::QLCF_GUI.Properties.Resources.xoa;
            this.btnXoa.Location = new System.Drawing.Point(1763, 517);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 74);
            this.btnXoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnXoa.TabIndex = 26;
            this.btnXoa.TabStop = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Image = global::QLCF_GUI.Properties.Resources.sua;
            this.btnSua.Location = new System.Drawing.Point(1548, 517);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 74);
            this.btnSua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSua.TabIndex = 25;
            this.btnSua.TabStop = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Image = global::QLCF_GUI.Properties.Resources.them;
            this.btnThem.Location = new System.Drawing.Point(1333, 517);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 74);
            this.btnThem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnThem.TabIndex = 24;
            this.btnThem.TabStop = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cboTenMon
            // 
            this.cboTenMon.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenMon.FormattingEnabled = true;
            this.cboTenMon.Location = new System.Drawing.Point(1565, 95);
            this.cboTenMon.Margin = new System.Windows.Forms.Padding(4);
            this.cboTenMon.Name = "cboTenMon";
            this.cboTenMon.Size = new System.Drawing.Size(276, 40);
            this.cboTenMon.TabIndex = 27;
            this.cboTenMon.SelectedIndexChanged += new System.EventHandler(this.cboTenMon_SelectedIndexChanged);
            // 
            // cboTenNgLieu
            // 
            this.cboTenNgLieu.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenNgLieu.FormattingEnabled = true;
            this.cboTenNgLieu.Location = new System.Drawing.Point(1565, 182);
            this.cboTenNgLieu.Margin = new System.Windows.Forms.Padding(4);
            this.cboTenNgLieu.Name = "cboTenNgLieu";
            this.cboTenNgLieu.Size = new System.Drawing.Size(276, 40);
            this.cboTenNgLieu.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1333, 359);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 37);
            this.label4.TabIndex = 28;
            this.label4.Text = "Đơn vị tính";
            // 
            // cbo_DVT
            // 
            this.cbo_DVT.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_DVT.FormattingEnabled = true;
            this.cbo_DVT.Location = new System.Drawing.Point(1565, 359);
            this.cbo_DVT.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_DVT.Name = "cbo_DVT";
            this.cbo_DVT.Size = new System.Drawing.Size(276, 40);
            this.cbo_DVT.TabIndex = 29;
            // 
            // frmCongThuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1885, 734);
            this.Controls.Add(this.cbo_DVT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboTenNgLieu);
            this.Controls.Add(this.cboTenMon);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nrSoLuong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgVCongThuc);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCongThuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CÔNG THỨC";
            this.Load += new System.EventHandler(this.frmCongThuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVCongThuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVCongThuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nrSoLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btnXoa;
        private System.Windows.Forms.PictureBox btnSua;
        private System.Windows.Forms.PictureBox btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTenMon;
        private System.Windows.Forms.ComboBox cboTenNgLieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_DVT;
    }
}