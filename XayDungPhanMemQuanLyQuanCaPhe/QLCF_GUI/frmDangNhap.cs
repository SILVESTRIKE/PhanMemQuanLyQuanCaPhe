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
    public partial class frmDangNhap : Form
    {
        NguoiDungBLL userbll = new NguoiDungBLL();

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtIDDN.Text.Trim();
            string password = txtPass.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NguoiDungDTO user = new NguoiDungDTO(txtIDDN.Text, txtPass.Text, null);
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
