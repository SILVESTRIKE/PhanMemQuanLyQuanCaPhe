using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lí_CaFe
{
    public partial class frm_Main : Form
    {
        private string username;
        private string password;

        public frm_Main(string username, string password)
        {
            InitializeComponent();
            this.username = username;

            // Cập nhật nội dung của Label để hiển thị lời chào
            lbl_welcome.Text = "Chào mừng " + username + " quay trở lại!";
            this.password = password;
        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            frm_Signin dangKyForm = new frm_Signin();
            dangKyForm.ShowDialog(); 
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            username = "";
            password = "";

            frm_Login loginForm = new frm_Login();
            loginForm.Show();
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frm_Mon frmmon =new frm_Mon();
            frmmon.ShowDialog();
        }
    }
}
