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
    public partial class frmDangKy : Form
    {
        NhanVienBLL nvbll = new NhanVienBLL();
        NguoiDungBLL nguoidungbll = new NguoiDungBLL();
        public frmDangKy()
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

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            Load_NV();
        }

        private void btnDK_Click(object sender, EventArgs e)
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
                NguoiDungDTO user = new NguoiDungDTO(txt_user.Text, txt_pass.Text, chucVu);
                bool kq = nguoidungbll.insert(user);
                if (kq == true)
                    MessageBox.Show("THEM THANH CONG");
                else
                    MessageBox.Show("LOI");

            }
        }
    }
}
