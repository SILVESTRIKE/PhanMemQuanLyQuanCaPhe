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
            lbl_welcome.Text = "Chào mừng " + username + " quay trở lại!";
            this.password = password;
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


    }
}
