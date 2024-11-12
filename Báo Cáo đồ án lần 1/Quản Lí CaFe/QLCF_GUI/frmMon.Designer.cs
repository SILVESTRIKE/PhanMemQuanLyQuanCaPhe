namespace QLCF_GUI
{
    partial class frmMon
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
            this.dgVMon = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.txtmamon = new System.Windows.Forms.TextBox();
            this.txtgia = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.PictureBox();
            this.btnSua = new System.Windows.Forms.PictureBox();
            this.btnThem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgVMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVMon
            // 
            this.dgVMon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgVMon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.dgVMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVMon.Location = new System.Drawing.Point(16, 95);
            this.dgVMon.Margin = new System.Windows.Forms.Padding(4);
            this.dgVMon.Name = "dgVMon";
            this.dgVMon.RowHeadersWidth = 51;
            this.dgVMon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVMon.Size = new System.Drawing.Size(707, 409);
            this.dgVMon.TabIndex = 0;
            this.dgVMon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVMon_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(763, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên món:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(763, 190);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 37);
            this.label5.TabIndex = 5;
            this.label5.Text = "Đơn giá:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(769, 284);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 37);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ghi chú :";
            // 
            // txtTenMon
            // 
            this.txtTenMon.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMon.Location = new System.Drawing.Point(948, 95);
            this.txtTenMon.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(329, 44);
            this.txtTenMon.TabIndex = 8;
            // 
            // txtmamon
            // 
            this.txtmamon.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmamon.Location = new System.Drawing.Point(948, 284);
            this.txtmamon.Margin = new System.Windows.Forms.Padding(4);
            this.txtmamon.Multiline = true;
            this.txtmamon.Name = "txtmamon";
            this.txtmamon.Size = new System.Drawing.Size(329, 122);
            this.txtmamon.TabIndex = 10;
            // 
            // txtgia
            // 
            this.txtgia.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgia.Location = new System.Drawing.Point(948, 190);
            this.txtgia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtgia.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(331, 44);
            this.txtgia.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 49);
            this.label3.TabIndex = 23;
            this.label3.Text = "MENU";
            // 
            // btnXoa
            // 
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Image = global::QLCF_GUI.Properties.Resources.xoa;
            this.btnXoa.Location = new System.Drawing.Point(1199, 430);
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
            this.btnSua.Location = new System.Drawing.Point(984, 430);
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
            this.btnThem.Location = new System.Drawing.Point(769, 430);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 74);
            this.btnThem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnThem.TabIndex = 24;
            this.btnThem.TabStop = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1295, 518);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtgia);
            this.Controls.Add(this.txtmamon);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgVMon);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sản phẩm";
            this.Load += new System.EventHandler(this.frmMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVMon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.TextBox txtmamon;
        private System.Windows.Forms.NumericUpDown txtgia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btnXoa;
        private System.Windows.Forms.PictureBox btnSua;
        private System.Windows.Forms.PictureBox btnThem;
    }
}