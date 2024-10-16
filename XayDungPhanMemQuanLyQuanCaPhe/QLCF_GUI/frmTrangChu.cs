using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            frmDangNhap dangKyForm = new frmDangNhap();
            dangKyForm.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            username = "";
            password = "";

            frmDangNhap loginForm = new frmDangNhap();
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
