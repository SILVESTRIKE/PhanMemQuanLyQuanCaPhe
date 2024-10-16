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
    public partial class frmDKTK : Form
    {
        NhanVienBLL nvbll = new NhanVienBLL();
        NguoiDungBLL nguoidungbll = new NguoiDungBLL();
        public frmDKTK()
        {
            InitializeComponent();
        }
        private bool KT_DL()
        {
            if (txtTen.Text == string.Empty)
            {
                MessageBox.Show("nhập đủ!");
                return false;
            }
            if (txtpass.Text == string.Empty)
            {
                MessageBox.Show("nhập đủ!");
                return false;
            }
            return true;
        }
        private void Load_NV()
        {
            cboTen.DataSource = nvbll.getALL();
            cboTen.DisplayMember = "Ten";
            cboTen.ValueMember = "IDNhanVien";
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
                if (ckbNhanVien.Checked)
                {
                    chucVu = "CV1";
                }
                else if (ckbNhanVien.Checked)
                {
                    chucVu = "CV2";
                }
                NguoiDungDTO user = new NguoiDungDTO(txtTen.Text, txtpass.Text, chucVu);
                bool kq = nguoidungbll.insert(user);
                if (kq == true)
                    MessageBox.Show("THEM THANH CONG");
                else
                    MessageBox.Show("LOI");

            }
        }
    }
}
