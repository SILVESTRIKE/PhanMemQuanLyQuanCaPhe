using QLCF_BLL;
using QLCF_DTO;
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
    public partial class frm_DangNhap : Form
    {
        NguoiDungBLL userbll = new NguoiDungBLL();

        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text.Trim();
            string password = txt_pass.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NguoiDungDTO user = new NguoiDungDTO(txt_username.Text, txt_pass.Text, null);
            bool kq = userbll.CheckLogin(user);

            if (kq)
            {

                MessageBox.Show("Đăng nhập thành công! Xin chào " + user.IDDN, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                this.Hide();
                frmTrangChu mainForm = new frmTrangChu(user.IDDN, user.Pass);
                mainForm.Show(); // Hiển thị form chính
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
