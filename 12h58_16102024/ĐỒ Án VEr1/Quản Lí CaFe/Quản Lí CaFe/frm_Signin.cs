using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCF_DAL;
using QLCF_BLL;
using QLCF_DTO;

namespace Quản_Lí_CaFe
{
    public partial class frm_Signin : Form
    {
        NhanVienBLL nvbll = new NhanVienBLL();
        NguoiDungBLL nguoidungbll = new NguoiDungBLL();
        public frm_Signin()
        {
            InitializeComponent();
        }
        private bool KT_DL()
        {
            if (txt_pass.Text == string.Empty)
            {
                MessageBox.Show("nhập đủ!");
                return false;
            }
            if (txt_pass.Text == string.Empty)
            {
                MessageBox.Show("nhập đủ!");
                return false;
            }
            return true;
        }
        private void Load_NV()
        {
            cbo_Ten.DataSource = nvbll.getALL();
            cbo_Ten.DisplayMember = "Ten";
            cbo_Ten.ValueMember = "IDNhanVien";
        }

        private void frm_Signin_Load(object sender, EventArgs e)
        {
            Load_NV();
        }

        private void btn_DK_Click(object sender, EventArgs e)
        {
            bool kt = KT_DL();
            if (kt == true)
            {
                string chucVu = "";
                if (rdoQuanLy.Checked)
                {
                    chucVu = "CV1";
                }
                else if (rdoNhanVien.Checked)
                {
                    chucVu = "CV2";
                }
                NguoiDungDTO user = new NguoiDungDTO(txt_user.Text,txt_pass.Text, chucVu);
                bool kq = nguoidungbll.insert(user);
                if (kq == true)
                    MessageBox.Show("THEM THANH CONG");
                else
                    MessageBox.Show("LOI");

            }
        }
    }
}
