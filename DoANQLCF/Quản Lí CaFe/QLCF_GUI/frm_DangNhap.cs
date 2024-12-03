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
        NhanVienBLL NhanVienBLL = new NhanVienBLL();
        public frm_DangNhap()
        {
            InitializeComponent();
            txt_username.Text = "NV001";
            txt_pass.Text = "123";
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
            NhanVienDTO nv = NhanVienBLL.getnv(username, password);
            bool kq = userbll.CheckLogin(user);

            if (kq)
            {

                MessageBox.Show("Đăng nhập thành công! Xin chào " + user.IDDN, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Session.CurrentUser = nv;

                frmTrangChu mainForm = new frmTrangChu();
                this.Hide();
                mainForm.Show(); // Hiển thị form chính
                mainForm.FormClosed += (s, args) => Application.Exit();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
            txt_username.Focus();
            txt_username.TabIndex = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                // Tự động phục hồi cơ sở dữ liệu
                userbll.RestoreDb();
                MessageBox.Show("Khôi phục cơ sở dữ liệu thành công! Hãy đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi phục hồi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
