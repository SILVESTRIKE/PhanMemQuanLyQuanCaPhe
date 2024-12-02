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
    public partial class frmTrangChu : Form
    {
        private string username;
        private string password;
        public NhanVienDTO _nv = new NhanVienDTO();
        public frmTrangChu()
        {

            InitializeComponent();
            var nv = Session.CurrentUser;
            OpenChildForm(new frmDatHang());
            


            this.username = nv.IDNhanVien;

            lblRole.Text = "Chào mừng " + nv.Ten + " quay trở lại!";
            this.password = nv.Pass;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.AutoScaleMode = AutoScaleMode.Dpi;
            if (nv.ChucVu == "Nhân viên")
            {
                this.btnNhanVien.Enabled = false;
                this.btnThongKe.Enabled = false;
                this.btnKho.Enabled = false;
            }
            

            //this.TopMost = true;
        }
        private Form CurrentFormChild;
        public void OpenChildForm(Form childForm)
        {

            this.CurrentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Clear();
            panel_body.Controls.Add(childForm);
            childForm.Show();
            
        }
       
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            username = "";
            password = "";

            frm_DangNhap loginForm = new frm_DangNhap();
            loginForm.Show();
            this.Hide();
        }

        //private void btnMenu_Click(object sender, EventArgs e)
        //{
        //    frmMon frmmon = new frmMon();
        //    frmmon.ShowDialog();
        //}

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhanVien());
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmMon());
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            List<ChiTietHDDTO> chiTietHoaDon = LayDonHang();

            if (chiTietHoaDon.Count > 0)
            {
                frmHoaDon hoaDonForm = new frmHoaDon(chiTietHoaDon);
                OpenChildForm(hoaDonForm);
            }
            else
            {
                //frmHoaDon hoaDonForm = new frmHoaDon(); 
                //OpenChildForm(hoaDonForm);
                MessageBox.Show("Chua co mon trong hoa don");
            }
        }
        private List<ChiTietHDDTO> LayDonHang()
        {
            return new List<ChiTietHDDTO>();
        }
        private void btnKho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKho());

        }

        private void btnCaTruc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCaTruc());

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongKe()); 
        }

        private void btnCongThuc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCongThuc());
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDatHang(this));

        }
        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            this.panelTitleBar.Dock = DockStyle.Top;
            this.panel_body.Dock = DockStyle.Fill;
            this.mnSMain.Dock = DockStyle.Top;

        }

        private void btnListDonHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ListDonHang());
        }
    }
}
