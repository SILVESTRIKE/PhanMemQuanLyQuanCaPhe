using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCF_GUI
{
    public partial class frmTrangChu : Form
    {
        private string username;
        private string password;
        public frmTrangChu(string username, string password)
        {
            InitializeComponent();
            this.username = username;

            lblRole.Text = "Chào mừng " + username + " quay trở lại!";
            this.password = password;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.AutoScaleMode = AutoScaleMode.Dpi; // Hoặc AutoScaleMode.Dpi;

            this.TopMost = true;
        }
        private Form CurrentFormChild;
        private void OpenChildForm(Form childForm)
        {
            //if (CurrentFormChild != null)
            //{
            //    CurrentFormChild.Close();
            //}
            //CurrentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Clear();
            panel_body.Controls.Add(childForm);
            //panel_body.Tag = childForm;
            //childForm.BringToFront();
            childForm.Show();
        }
        //private void btnDangKy_Click(object sender, EventArgs e)
        //{
        //    frmDangKy dangKyForm = new frmDangKy();
        //    dangKyForm.ShowDialog();
        //}

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            username = "";
            password = "";

            frm_DangNhap loginForm = new frm_DangNhap();
            loginForm.Show();
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmMon frmmon = new frmMon();
            frmmon.ShowDialog();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhanVien());
        }
        private void btnMenu_Click_1(object sender, EventArgs e)
        {

            OpenChildForm(new frmMon());
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHoaDon());

        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKho());

        }

        private void btnCaTruc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCaTruc());

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongKe()); 
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            this.panelTitleBar.Dock = DockStyle.Top;
            this.panel_body.Dock = DockStyle.Fill;
            this.mnSMain.Dock = DockStyle.Top;

        }

        private void btnCongThuc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCongThuc());
        }
    }
}
