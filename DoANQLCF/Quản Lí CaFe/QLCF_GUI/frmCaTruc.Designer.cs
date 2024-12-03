namespace QLCF_GUI
{
    partial class frmCaTruc
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
            this.dgvLichTruc = new System.Windows.Forms.DataGridView();
            this.dTNgayTruc = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTenCa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboIDNhanVien = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.PictureBox();
            this.btn_Sua = new System.Windows.Forms.PictureBox();
            this.btnThem = new System.Windows.Forms.PictureBox();
            this.btn_chialichtruc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_TrangThai = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_IDLictruc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichTruc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Xoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Sua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLichTruc
            // 
            this.dgvLichTruc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichTruc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.dgvLichTruc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichTruc.Location = new System.Drawing.Point(19, 71);
            this.dgvLichTruc.Name = "dgvLichTruc";
            this.dgvLichTruc.RowHeadersWidth = 51;
            this.dgvLichTruc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichTruc.Size = new System.Drawing.Size(969, 511);
            this.dgvLichTruc.TabIndex = 2;
            this.dgvLichTruc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichTruc_CellClick);
            // 
            // dTNgayTruc
            // 
            this.dTNgayTruc.CustomFormat = "yyyy-MM-dd";
            this.dTNgayTruc.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTNgayTruc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTNgayTruc.Location = new System.Drawing.Point(1142, 176);
            this.dTNgayTruc.Name = "dTNgayTruc";
            this.dTNgayTruc.Size = new System.Drawing.Size(243, 33);
            this.dTNgayTruc.TabIndex = 35;
            this.dTNgayTruc.ValueChanged += new System.EventHandler(this.dTNgayTruc_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(1005, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 26);
            this.label3.TabIndex = 34;
            this.label3.Text = "Mã Nhân viên";
            // 
            // cboTenCa
            // 
            this.cboTenCa.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenCa.FormattingEnabled = true;
            this.cboTenCa.Items.AddRange(new object[] {
            "Ca sáng",
            "Ca chiều",
            "Ca tối"});
            this.cboTenCa.Location = new System.Drawing.Point(1142, 226);
            this.cboTenCa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTenCa.Name = "cboTenCa";
            this.cboTenCa.Size = new System.Drawing.Size(243, 34);
            this.cboTenCa.TabIndex = 37;
            this.cboTenCa.SelectedIndexChanged += new System.EventHandler(this.cboTenCa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(1005, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 26);
            this.label1.TabIndex = 38;
            this.label1.Text = "Ngày trực";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(1005, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 26);
            this.label2.TabIndex = 39;
            this.label2.Text = "Ca trực";
            // 
            // cboIDNhanVien
            // 
            this.cboIDNhanVien.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboIDNhanVien.FormattingEnabled = true;
            this.cboIDNhanVien.Location = new System.Drawing.Point(1142, 127);
            this.cboIDNhanVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboIDNhanVien.Name = "cboIDNhanVien";
            this.cboIDNhanVien.Size = new System.Drawing.Size(243, 34);
            this.cboIDNhanVien.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 39);
            this.label4.TabIndex = 44;
            this.label4.Text = "CA TRỰC";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Xoa.Image = global::QLCF_GUI.Properties.Resources.xoa;
            this.btn_Xoa.Location = new System.Drawing.Point(1316, 365);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(60, 60);
            this.btn_Xoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Xoa.TabIndex = 43;
            this.btn_Xoa.TabStop = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sua.Image = global::QLCF_GUI.Properties.Resources.sua;
            this.btn_Sua.Location = new System.Drawing.Point(1175, 365);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(60, 60);
            this.btn_Sua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Sua.TabIndex = 43;
            this.btn_Sua.TabStop = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Image = global::QLCF_GUI.Properties.Resources.them;
            this.btnThem.Location = new System.Drawing.Point(1021, 365);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(60, 60);
            this.btnThem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnThem.TabIndex = 41;
            this.btnThem.TabStop = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btn_chialichtruc
            // 
            this.btn_chialichtruc.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chialichtruc.Location = new System.Drawing.Point(1021, 479);
            this.btn_chialichtruc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_chialichtruc.Name = "btn_chialichtruc";
            this.btn_chialichtruc.Size = new System.Drawing.Size(355, 48);
            this.btn_chialichtruc.TabIndex = 45;
            this.btn_chialichtruc.Text = "Xem lịch trực của mình";
            this.btn_chialichtruc.UseVisualStyleBackColor = true;
            this.btn_chialichtruc.Click += new System.EventHandler(this.btn_chialichtruc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(1005, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 26);
            this.label5.TabIndex = 46;
            this.label5.Text = "Trạng thái";
            // 
            // cbo_TrangThai
            // 
            this.cbo_TrangThai.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_TrangThai.FormattingEnabled = true;
            this.cbo_TrangThai.Location = new System.Drawing.Point(1142, 275);
            this.cbo_TrangThai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbo_TrangThai.Name = "cbo_TrangThai";
            this.cbo_TrangThai.Size = new System.Drawing.Size(243, 34);
            this.cbo_TrangThai.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(1005, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 26);
            this.label6.TabIndex = 48;
            this.label6.Text = "ID Lịch trực";
            // 
            // txt_IDLictruc
            // 
            this.txt_IDLictruc.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IDLictruc.Location = new System.Drawing.Point(1142, 77);
            this.txt_IDLictruc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_IDLictruc.Name = "txt_IDLictruc";
            this.txt_IDLictruc.Size = new System.Drawing.Size(243, 34);
            this.txt_IDLictruc.TabIndex = 49;
            // 
            // frmCaTruc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1410, 594);
            this.Controls.Add(this.txt_IDLictruc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbo_TrangThai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_chialichtruc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTenCa);
            this.Controls.Add(this.cboIDNhanVien);
            this.Controls.Add(this.dTNgayTruc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvLichTruc);
            this.Name = "frmCaTruc";
            this.Text = " Quản lý ca trực";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichTruc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Xoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Sua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLichTruc;
        private System.Windows.Forms.DateTimePicker dTNgayTruc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTenCa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboIDNhanVien;
        private System.Windows.Forms.PictureBox btn_Sua;
        private System.Windows.Forms.PictureBox btnThem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btn_Xoa;
        private System.Windows.Forms.Button btn_chialichtruc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_TrangThai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_IDLictruc;
    }
}