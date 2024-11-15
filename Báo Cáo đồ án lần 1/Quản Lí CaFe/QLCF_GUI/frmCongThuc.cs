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
    public partial class frmCongThuc : Form
    {
        CongThucBLL CongThucBLL = new CongThucBLL();
        MonBLL MonBLL = new MonBLL();
        NguyenLieuBLL NgLieuBLL = new NguyenLieuBLL();

        private bool KT_DL()
        {
            if (cboTenMon.Text == string.Empty)
            {
                MessageBox.Show("Tên món không được để trống!");
                return false;
            }

            if (cboTenNgLieu.Text == string.Empty)
            {
                MessageBox.Show("Tên nguyên liệu không được để trống!");
                return false;
            }
            decimal sl;
            if (nrSoLuong.Text == string.Empty || !decimal.TryParse(nrSoLuong.Text, out sl))
            {
                MessageBox.Show("Giá món không hợp lệ!");
                return false;
            }
            return true;
        }
        public frmCongThuc()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bool kt = KT_DL();
            if (kt == true)
            {
                string idMon = cboTenMon.Text;
                string idNguyenLieu = cboTenNgLieu.Text;
                decimal sl = Convert.ToDecimal(nrSoLuong.Text);

                CongThucDTO CongThuc = new CongThucDTO(idMon, idNguyenLieu, sl);
                bool kq = CongThucBLL.AddCongThuc(CongThuc);

                if (kq == true)
                {
                    MessageBox.Show("THÊM MÓN THÀNH CÔNG!");
                    Load_Grv(); // Cập nhật lại danh sách
                }
                else
                {
                    MessageBox.Show("LỖI: Món đã tồn tại hoặc có lỗi xảy ra!");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            bool kt = KT_DL();
            if (kt == true)
            {
                string idMon = cboTenMon.Text;
                string idNguyenLieu = cboTenNgLieu.Text;
                decimal sl = Convert.ToDecimal(nrSoLuong.Text);
                CongThucDTO CongThuc = new CongThucDTO(idMon, idNguyenLieu, sl);
                bool kq = CongThucBLL.UpdateCongThuc(CongThuc);
                if (kq == true)
                {
                    MessageBox.Show("SUA THANH CONG");
                    Load_Grv(); // Cập nhật lại danh sách
                }
                else
                    MessageBox.Show("LOI");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bool kt = KT_DL();
            if (kt == true)
            {
                string idMon = cboTenMon.Text;
                string idNguyenLieu = cboTenNgLieu.Text;
                decimal sl = Convert.ToDecimal(nrSoLuong.Text);
                CongThucDTO CongThuc = new CongThucDTO(idMon, idNguyenLieu, sl);
                bool kq = CongThucBLL.DeleteCongThuc(CongThuc);


                if (kq == true)
                {
                    MessageBox.Show("XÓA CÔNG THỨC THÀNH CÔNG!");
                    Load_Grv(); // Cập nhật lại danh sách
                }
                else
                {
                    MessageBox.Show("LỖI: Không thể xóa!");
                }
            }
        }

        public void Load_Grv()
        {
            dgVCongThuc.DataSource = CongThucBLL.GetAllCongThuc();
        }
        private void LoadMon()
        {
            List<MonDTO> dishes = MonBLL.GetAllMon(); 
            cboTenMon.DataSource = dishes;
            cboTenMon.DisplayMember = "TenMon"; 
            cboTenMon.ValueMember = "IDMon";
        }

        private void LoadNgLieu()
        {
            List<NguyenLieuDTO> ingredients = NgLieuBLL.GetAllNgLieu(); // Adjust this based on your method name in NguyenLieuDAL
            cboTenNgLieu.DataSource = ingredients;
            cboTenNgLieu.DisplayMember = "TenNL"; // Ensure this matches the property for ingredient name
            cboTenNgLieu.ValueMember = "IDNguyenLieu";
        }
        public void Bindings()
        {
            cboTenNgLieu.DataBindings.Clear();
            nrSoLuong.DataBindings.Clear();
            cboTenMon.DataBindings.Clear();
            cboTenNgLieu.DataBindings.Add("SelectedValue", dgVCongThuc.DataSource, "idNguyenLieu");
            nrSoLuong.DataBindings.Add("Value", dgVCongThuc.DataSource, "SoLuong");
            cboTenMon.DataBindings.Add("SelectedValue", dgVCongThuc.DataSource, "idMon");
        }

        private void frmCongThuc_Load(object sender, EventArgs e)
        {
            Load_Grv();
            LoadNgLieu();
            LoadMon();
            Bindings();
            nrSoLuong.DecimalPlaces = 2;   
            nrSoLuong.Increment = 0.01M;  
            nrSoLuong.Minimum = 0.00M;     
            nrSoLuong.Maximum = 1000.00M;  
        }
    }
}
