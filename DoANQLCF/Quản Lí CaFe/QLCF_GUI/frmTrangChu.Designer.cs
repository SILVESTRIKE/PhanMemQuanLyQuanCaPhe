﻿namespace QLCF_GUI
{
    partial class frmTrangChu
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
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.PictureBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.mnSMain = new System.Windows.Forms.MenuStrip();
            this.btnDonHang = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCaTruc = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCongThuc = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKho = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.btnListDonHang = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_body = new System.Windows.Forms.Panel();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnThem)).BeginInit();
            this.mnSMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelTitleBar.Controls.Add(this.btnThem);
            this.panelTitleBar.Controls.Add(this.lblRole);
            this.panelTitleBar.ForeColor = System.Drawing.Color.White;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 31);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1270, 73);
            this.panelTitleBar.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Image = global::QLCF_GUI.Properties.Resources.Logo;
            this.btnThem.Location = new System.Drawing.Point(470, 5);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(330, 60);
            this.btnThem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnThem.TabIndex = 17;
            this.btnThem.TabStop = false;
            this.btnThem.Click += new System.EventHandler(this.btnDonHang_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRole.Location = new System.Drawing.Point(22, 41);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(70, 24);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "ADMIN";
            // 
            // mnSMain
            // 
            this.mnSMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnSMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDonHang,
            this.btnNhanVien,
            this.btnCaTruc,
            this.btnMenu,
            this.btnCongThuc,
            this.btnKho,
            this.btnThongKe,
            this.btnListDonHang,
            this.btnDangXuat});
            this.mnSMain.Location = new System.Drawing.Point(0, 0);
            this.mnSMain.Name = "mnSMain";
            this.mnSMain.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnSMain.Size = new System.Drawing.Size(1270, 28);
            this.mnSMain.TabIndex = 3;
            this.mnSMain.Text = "Trang Chủ";
            // 
            // btnDonHang
            // 
            this.btnDonHang.Name = "btnDonHang";
            this.btnDonHang.Size = new System.Drawing.Size(100, 24);
            this.btnDonHang.Text = "ĐƠN HÀNG";
            this.btnDonHang.Click += new System.EventHandler(this.btnDonHang_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(100, 24);
            this.btnNhanVien.Text = "NHÂN VIÊN";
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnCaTruc
            // 
            this.btnCaTruc.Name = "btnCaTruc";
            this.btnCaTruc.Size = new System.Drawing.Size(81, 24);
            this.btnCaTruc.Text = "CA TRỰC";
            this.btnCaTruc.Click += new System.EventHandler(this.btnCaTruc_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(63, 24);
            this.btnMenu.Text = "MENU";
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnCongThuc
            // 
            this.btnCongThuc.Name = "btnCongThuc";
            this.btnCongThuc.Size = new System.Drawing.Size(105, 24);
            this.btnCongThuc.Text = "CÔNG THỨC";
            this.btnCongThuc.Click += new System.EventHandler(this.btnCongThuc_Click);
            // 
            // btnKho
            // 
            this.btnKho.Name = "btnKho";
            this.btnKho.Size = new System.Drawing.Size(52, 24);
            this.btnKho.Text = "KHO";
            this.btnKho.Click += new System.EventHandler(this.btnKho_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(93, 24);
            this.btnThongKe.Text = "THỐNG KÊ";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnListDonHang
            // 
            this.btnListDonHang.Name = "btnListDonHang";
            this.btnListDonHang.Size = new System.Drawing.Size(135, 24);
            this.btnListDonHang.Text = "LIST ĐƠN HÀNG ";
            this.btnListDonHang.Click += new System.EventHandler(this.btnListDonHang_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(104, 24);
            this.btnDangXuat.Text = "ĐĂNG XUẤT";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // panel_body
            // 
            this.panel_body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel_body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_body.Location = new System.Drawing.Point(0, 110);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1281, 350);
            this.panel_body.TabIndex = 4;
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1270, 602);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.mnSMain);
            this.MainMenuStrip = this.mnSMain;
            this.Name = "frmTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí quán cà phê";
            this.Load += new System.EventHandler(this.frmTrangChu_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnThem)).EndInit();
            this.mnSMain.ResumeLayout(false);
            this.mnSMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.MenuStrip mnSMain;
        private System.Windows.Forms.ToolStripMenuItem btnNhanVien;
        private System.Windows.Forms.ToolStripMenuItem btnMenu;
        private System.Windows.Forms.ToolStripMenuItem btnKho;
        private System.Windows.Forms.ToolStripMenuItem btnCaTruc;
        private System.Windows.Forms.ToolStripMenuItem btnThongKe;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.ToolStripMenuItem btnCongThuc;
        private System.Windows.Forms.ToolStripMenuItem btnDangXuat;
        private System.Windows.Forms.ToolStripMenuItem btnDonHang;
        private System.Windows.Forms.PictureBox btnThem;
        private System.Windows.Forms.ToolStripMenuItem btnListDonHang;
    }
}