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
            if (kt)
            {
                string idMon = cboTenMon.SelectedValue.ToString();
                string tenMon = cboTenMon.Text;
                string idNguyenLieu = cboTenNgLieu.SelectedValue.ToString();
                string tenNguyenLieu = cboTenNgLieu.Text;
                decimal soLuong = Convert.ToDecimal(nrSoLuong.Text);
                string dvTinh = cbo_DVT.Text; // Giả sử bạn có TextBox để nhập đơn vị tính

                CongThucDTO congThuc = new CongThucDTO
                {
                    IDMon = idMon,
                    TenMon = tenMon,
                    IDNguyenLieu = idNguyenLieu,
                    TenNguyenLieu = tenNguyenLieu,
                    SoLuong = soLuong,
                    DVTinh = dvTinh
                };

                CongThucBLL congThucBLL = new CongThucBLL();
                bool kq = congThucBLL.AddCongThuc(congThuc);

                if (kq)
                {
                    MessageBox.Show("Thêm công thức thành công!");
                    Load_Grv(); // Cập nhật lại danh sách
                }
                else
                {
                    MessageBox.Show("Lỗi: Công thức đã tồn tại hoặc có lỗi xảy ra!");
                }
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            bool kt = KT_DL();
            if (kt)
            {
                string idMon = cboTenMon.SelectedValue.ToString();
                string tenMon = cboTenMon.Text;
                string idNguyenLieu = cboTenNgLieu.SelectedValue.ToString();
                string tenNguyenLieu = cboTenNgLieu.Text;
                decimal soLuong = Convert.ToDecimal(nrSoLuong.Text);
                string dvTinh = cbo_DVT.Text; // Giả sử bạn có TextBox để nhập đơn vị tính

                CongThucDTO congThuc = new CongThucDTO
                {
                    IDMon = idMon,
                    TenMon = tenMon,
                    IDNguyenLieu = idNguyenLieu,
                    TenNguyenLieu = tenNguyenLieu,
                    SoLuong = soLuong,
                    DVTinh = dvTinh
                };

                CongThucBLL congThucBLL = new CongThucBLL();
                bool kq = congThucBLL.UpdateCongThuc(congThuc);

                if (kq)
                {
                    MessageBox.Show("Sửa công thức thành công!");
                    Load_Grv(); // Cập nhật lại danh sách
                }
                else
                {
                    MessageBox.Show("Lỗi: Không thể sửa!");
                }
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            bool kt = KT_DL();
            if (kt)
            {
                string idMon = cboTenMon.SelectedValue.ToString();
                string idNguyenLieu = cboTenNgLieu.SelectedValue.ToString();

                CongThucDTO congThuc = new CongThucDTO
                {
                    IDMon = idMon,
                    IDNguyenLieu = idNguyenLieu
                };

                CongThucBLL congThucBLL = new CongThucBLL();
                bool kq = congThucBLL.DeleteCongThuc(congThuc);

                if (kq)
                {
                    MessageBox.Show("Xóa công thức thành công!");
                    Load_Grv(); // Cập nhật lại danh sách
                }
                else
                {
                    MessageBox.Show("Lỗi: Không thể xóa!");
                }
            }
        }


        public void Load_Grv()
        {
            CongThucBLL congThucBLL = new CongThucBLL();
            dgVCongThuc.DataSource = congThucBLL.GetAllCongThuc();

            // Ẩn cột IDMon và IDNguyenLieu
            if (dgVCongThuc.Columns["IDMon"] != null)
            {
                dgVCongThuc.Columns["IDMon"].Visible = false;
            }

            if (dgVCongThuc.Columns["IDNguyenLieu"] != null)
            {
                dgVCongThuc.Columns["IDNguyenLieu"].Visible = false;
            }

            // Thiết lập tên cột hiển thị (nếu cần)
            if (dgVCongThuc.Columns["TenMon"] != null)
            {
                dgVCongThuc.Columns["TenMon"].HeaderText = "Tên Món";
            }

            if (dgVCongThuc.Columns["TenNguyenLieu"] != null)
            {
                dgVCongThuc.Columns["TenNguyenLieu"].HeaderText = "Tên Nguyên Liệu";
            }

            if (dgVCongThuc.Columns["SoLuong"] != null)
            {
                dgVCongThuc.Columns["SoLuong"].HeaderText = "Số Lượng";
            }

            if (dgVCongThuc.Columns["DVTinh"] != null)
            {
                dgVCongThuc.Columns["DVTinh"].HeaderText = "Đơn Vị Tính";
            }
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

        private void LoadCBODVT()
        {
            List<string> dvt = new List<string> { "kg", "L", "Quả" };
            cbo_DVT.DataSource = dvt;
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
            LoadCBODVT();
            nrSoLuong.DecimalPlaces = 2;   
            nrSoLuong.Increment = 0.01M;  
            nrSoLuong.Minimum = 0.00M;     
            nrSoLuong.Maximum = 1000.00M;
            cboTenMon.SelectedIndexChanged += cboTenMon_SelectedIndexChanged;

        }

        private void cboTenMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}
