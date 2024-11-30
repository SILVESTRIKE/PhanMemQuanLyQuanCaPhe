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
    public partial class frmDatHang : Form
    {
        private frmTrangChu parentForm; // Tham chiếu tới frmTrangChu
        HoaDonBLL hoaDonBLL= new HoaDonBLL();
        public frmDatHang(frmTrangChu parent)
        {
            InitializeComponent();
            parentForm = parent;  // Gán tham chiếu đến frmTrangChu
        }
        MonBLL monBLL = new MonBLL();
        List<MonDTO> DSMON = new List<MonDTO>();
        NhanVienDTO _nv = new NhanVienDTO();
        public frmDatHang(NhanVienDTO nv)
        {
            InitializeComponent();
            _nv = nv;
        }

        private void frmDatHang_Load(object sender, EventArgs e)
        {
            // Cài đặt font chữ
            dgVMon.DefaultCellStyle.Font = new Font("Arial", 16); // Font dữ liệu
            dgVMon.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 18, FontStyle.Bold); // Font tiêu đề
            dgVMon.RowTemplate.Height = 80; // Đặt chiều cao dòng (đơn vị: pixel)

            // Loại bỏ đường kẻ
            dgVMon.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgVMon.GridColor = Color.White;
            //lstMon.DataSource = null; 

            lstMon.DataSource = monBLL.GetAllMon();
            lstMon.DisplayMember = "TenMon";
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            ToolStripMenuItem xoaItem = new ToolStripMenuItem("Xóa");
            xoaItem.Click += XoaItem_Click; // Gắn sự kiện cho mục lệnh Xóa
            contextMenu.Items.Add(xoaItem);

            // Gán ContextMenuStrip vào DataGridView
            dgVMon.ContextMenuStrip = contextMenu;
        }
        private void XoaItem_Click(object sender, EventArgs e)
        {
            // Kiểm tra có dòng nào được chọn không
            if (dgVMon.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgVMon.SelectedRows[0];
                // Xóa dòng đã chọn
                dgVMon.Rows.Remove(selectedRow);
            }
        }
        private void btnCaPhe_Click(object sender, EventArgs e)
        {
            lstMon.DataSource = null; // Ngắt kết nối DataSource

            lstMon.Items.Clear();
            lstMon.DataSource = monBLL.GetMonByLoai("CP");
            lstMon.DisplayMember = "TenMon"; 

        }
        private void btnSinhTo_Click(object sender, EventArgs e)
        {
            lstMon.DataSource = null; // Ngắt kết nối DataSource

            lstMon.Items.Clear();
            lstMon.DataSource = monBLL.GetMonByLoai("ST");
            lstMon.DisplayMember = "TenMon";
        }

        private void btnKhac_Click(object sender, EventArgs e)
        {
            lstMon.DataSource = null; // Ngắt kết nối DataSource

            lstMon.Items.Clear();
            lstMon.DataSource = monBLL.GetMonByLoai("NU");
            lstMon.DisplayMember = "TenMon";
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            lstMon.DataSource = null; // Ngắt kết nối DataSource

            lstMon.Items.Clear();
            lstMon.DataSource = monBLL.GetMonByLoai("TR");
            lstMon.DisplayMember = "TenMon";
        }
        private void lstMon_DoubleClick(object sender, EventArgs e)
        {
            if (lstMon.SelectedItem != null)
            {
                // Kiểm tra và tạo cột nếu chưa có
                if (dgVMon.Columns.Count == 0)
                {
                    dgVMon.Columns.Add("IDMon", "ID Món");
                    dgVMon.Columns.Add("TenMon", "Tên Món");
                    dgVMon.Columns.Add("SoLuong", "Số Lượng");
                    dgVMon.Columns.Add("Gia", "Giá");
                    dgVMon.Columns.Add("TongTien", "Thành Tiền");
                }

                var monDTO = (MonDTO)lstMon.SelectedItem;
                bool isExist = false;

                // Kiểm tra nếu món đã tồn tại
                foreach (DataGridViewRow row in dgVMon.Rows)
                {
                    if (row.Cells["IDMon"].Value?.ToString() == monDTO.IDMon.ToString())
                    {
                        // Món đã tồn tại, tăng số lượng
                        int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                        soLuong++;
                        row.Cells["SoLuong"].Value = soLuong;

                        // Cập nhật Thành Tiền
                        decimal gia = Convert.ToDecimal(row.Cells["Gia"].Value);
                        row.Cells["TongTien"].Value = soLuong * gia;

                        isExist = true;
                        break;
                    }
                }

                // Nếu món chưa tồn tại, thêm mới vào DataGridView
                if (!isExist)
                {
                    dgVMon.Rows.Add(monDTO.IDMon, monDTO.TenMon, 1, monDTO.gia, monDTO.gia);
                }
            }
            dgVMon.CurrentCell = null; // Bỏ chọn dòng hiện tại
        }


        private void dgVMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dòng hiện tại
                DataGridViewRow row = dgVMon.Rows[e.RowIndex];

                txtSLuong.Text = row.Cells["SoLuong"].Value?.ToString() ?? "";
            }
        }
        
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (dgVMon.SelectedRows.Count > 0)
            {
                if (dgVMon.SelectedRows[0].Cells["SoLuong"].Value != null && dgVMon.SelectedRows[0].Cells["Gia"].Value != null)
                {
                    decimal soLuong = Convert.ToDecimal(txtSLuong.Text);
                    decimal gia = Convert.ToDecimal(dgVMon.SelectedRows[0].Cells["Gia"].Value);

                    decimal totalPrice = soLuong * gia;
                    dgVMon.SelectedRows[0].Cells["SoLuong"].Value = soLuong;

                    dgVMon.SelectedRows[0].Cells["TongTien"].Value = totalPrice;
                }
                else
                {
                    MessageBox.Show("Dữ liệu không hợp lệ.");
                }
                txtSLuong.Refresh();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng.");
            }
            
        }

        private void mnSXoa_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            dgVMon.Rows.RemoveAt(dgVMon.SelectedRows[0].Index);
        }
        private List<ChiTietHDDTO> GetDataFromDataGridView(string idHoaDon)
        {
            List<ChiTietHDDTO> chiTietList = new List<ChiTietHDDTO>();
            string idHD = hoaDonBLL.IDHoaDon();
            foreach (DataGridViewRow row in dgVMon.Rows)
            {
                if (!row.IsNewRow)
                {
                    string idMon = row.Cells["IDMon"].Value?.ToString(); // Lấy ID món
                    int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value); // Lấy số lượng
                    decimal donGia = Convert.ToDecimal(row.Cells["Gia"].Value); // Lấy giá món
                    decimal thanhTien = Convert.ToDecimal(row.Cells["TongTien"].Value);
                    bool trangThai = true; // Hoặc sử dụng giá trị nào đó cho trạng thái món

                    ChiTietHDDTO chiTietHoaDon = new ChiTietHDDTO(idHD, idMon, soLuong, donGia, thanhTien, trangThai);
                    chiTietList.Add(chiTietHoaDon);
                }
            }

            return chiTietList;
        }


        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string idHoaDon = Guid.NewGuid().ToString();

            List<ChiTietHDDTO> chiTietHoaDonList = GetDataFromDataGridView(idHoaDon);

            frmHoaDon hoaDonForm = new frmHoaDon(chiTietHoaDonList, _nv.IDNhanVien);
            //parentForm.OpenChildForm(hoaDonForm);
            hoaDonForm.ShowDialog();

        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGhiChu.Clear();
            txtGhiChu.Clear();
            dgVMon.DataSource = null;
            dgVMon.Rows.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
