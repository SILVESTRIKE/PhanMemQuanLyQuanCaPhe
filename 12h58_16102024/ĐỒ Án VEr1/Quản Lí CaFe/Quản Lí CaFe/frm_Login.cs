using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCF_BLL;
using QLCF_DAL;
using QLCF_DTO;

namespace Quản_Lí_CaFe
{
    public partial class frm_Login : Form
    {
        NguoiDungBLL userbll = new NguoiDungBLL();  
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_signin_Click(object sender, EventArgs e)
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
                frm_Main mainForm = new frm_Main(user.IDDN,user.Pass); 
                mainForm.Show(); // Hiển thị form chính
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
