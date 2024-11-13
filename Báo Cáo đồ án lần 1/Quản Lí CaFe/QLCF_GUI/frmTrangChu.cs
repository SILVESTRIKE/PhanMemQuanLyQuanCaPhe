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

            // Cập nhật nội dung của Label để hiển thị lời chào
            //lbl_welcome.Text = "Chào mừng " + username + " quay trở lại!";
            this.password = password;
        }
        private Form CurrentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (CurrentFormChild != null)
            {
                CurrentFormChild.Close();
            }
            CurrentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            frmDangKy dangKyForm = new frmDangKy();
            dangKyForm.ShowDialog();
        }

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

        }

        private void btnKho_Click(object sender, EventArgs e)
        {

        }

        private void btnCaTruc_Click(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongKe()); 
        }
    }
}
