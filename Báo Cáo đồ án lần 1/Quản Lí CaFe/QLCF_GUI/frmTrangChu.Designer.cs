namespace QLCF_GUI
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
            this.lblRole = new System.Windows.Forms.Label();
            this.TopLabel = new System.Windows.Forms.Label();
            this.mnSMain = new System.Windows.Forms.MenuStrip();
            this.btnNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCaTruc = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCongThuc = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKho = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_body = new System.Windows.Forms.Panel();
            this.panelTitleBar.SuspendLayout();
            this.mnSMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelTitleBar.Controls.Add(this.lblRole);
            this.panelTitleBar.Controls.Add(this.TopLabel);
            this.panelTitleBar.Location = new System.Drawing.Point(-1, 28);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1252, 68);
            this.panelTitleBar.TabIndex = 1;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRole.Location = new System.Drawing.Point(13, 35);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(70, 24);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "ADMIN";
            // 
            // TopLabel
            // 
            this.TopLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TopLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.TopLabel.Enabled = false;
            this.TopLabel.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopLabel.ForeColor = System.Drawing.Color.White;
            this.TopLabel.Location = new System.Drawing.Point(455, 8);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(365, 47);
            this.TopLabel.TabIndex = 0;
            this.TopLabel.Text = "DFS COFFEE";
            this.TopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mnSMain
            // 
            this.mnSMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnSMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNhanVien,
            this.btnCaTruc,
            this.btnMenu,
            this.btnCongThuc,
            this.btnKho,
            this.btnHoaDon,
            this.btnThongKe,
            this.btnDangXuat});
            this.mnSMain.Location = new System.Drawing.Point(0, 0);
            this.mnSMain.Name = "mnSMain";
            this.mnSMain.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnSMain.Size = new System.Drawing.Size(1253, 28);
            this.mnSMain.TabIndex = 3;
            this.mnSMain.Text = "Trang Chủ";
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
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click_1);
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
            // btnHoaDon
            // 
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(90, 24);
            this.btnHoaDon.Text = "HÓA ĐƠN";
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(93, 24);
            this.btnThongKe.Text = "THỐNG KÊ";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
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
            this.panel_body.Location = new System.Drawing.Point(0, 91);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1253, 543);
            this.panel_body.TabIndex = 4;
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1253, 638);
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
            this.mnSMain.ResumeLayout(false);
            this.mnSMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label TopLabel;
        private System.Windows.Forms.MenuStrip mnSMain;
        private System.Windows.Forms.ToolStripMenuItem btnNhanVien;
        private System.Windows.Forms.ToolStripMenuItem btnMenu;
        private System.Windows.Forms.ToolStripMenuItem btnHoaDon;
        private System.Windows.Forms.ToolStripMenuItem btnKho;
        private System.Windows.Forms.ToolStripMenuItem btnCaTruc;
        private System.Windows.Forms.ToolStripMenuItem btnThongKe;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.ToolStripMenuItem btnCongThuc;
        private System.Windows.Forms.ToolStripMenuItem btnDangXuat;
    }
}