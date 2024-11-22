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

        public frmDatHang(frmTrangChu parent)
        {
            InitializeComponent();
            parentForm = parent;  // Gán tham chiếu đến frmTrangChu
        }

        MonBLL monBLL = new MonBLL();
        List<MonDTO> DSMON = new List<MonDTO>();
        public frmDatHang()
        {
            InitializeComponent();
        }

        private void frmDatHang_Load(object sender, EventArgs e)
        {
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
                if (dgVMon.Columns.Count == 0)
                {
                    dgVMon.Columns.Add("Column0", "ID Món");

                    dgVMon.Columns.Add("Column1", "Tên Món");
                    dgVMon.Columns.Add("Column2", "Số Lượng");
                    dgVMon.Columns.Add("Column3", "Giá");
                }
                var monDTO = (MonDTO)lstMon.SelectedItem;

                dgVMon.Rows.Add( monDTO.IDMon, monDTO.TenMon, 1, monDTO.gia);

            }
            dgVMon.CurrentCell = null;

        }

        private void dgVMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dòng hiện tại
                DataGridViewRow row = dgVMon.Rows[e.RowIndex];

                txtSLuong.Text = row.Cells[1].Value?.ToString() ?? "";
            }
        }
        
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (dgVMon.SelectedRows.Count > 0)
            {
                if (dgVMon.SelectedRows[0].Cells[1].Value != null && dgVMon.SelectedRows[0].Cells[2].Value != null)
                {
                    decimal soLuong = Convert.ToDecimal(txtSLuong.Text);
                    decimal gia = Convert.ToDecimal(dgVMon.SelectedRows[0].Cells[2].Value);

                    decimal totalPrice = soLuong * gia;
                    dgVMon.SelectedRows[0].Cells[1].Value = soLuong;

                    dgVMon.SelectedRows[0].Cells[2].Value = totalPrice;
                }
                else
                {
                    MessageBox.Show("Dữ liệu không hợp lệ.");
                }
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
        private List<MonDTO> GetDataFromDataGridView()
        {
            List<MonDTO> monList = new List<MonDTO>();

            foreach (DataGridViewRow row in dgVMon.Rows)
            {
                // Kiểm tra nếu dòng không phải dòng trống
                if (!row.IsNewRow)
                {
                    MonDTO mon = new MonDTO
                    {
                        IDMon = Convert.ToInt32(row.Cells[0].Value), // Thay "ID" bằng tên cột bạn cần
                        TenMon = row.Cells[1].Value?.ToString() ?? "",
                        SoLuong = Convert.ToInt32(row.Cells["SoLuong"].Value), // Thay "SoLuong" bằng tên cột bạn cần
                        Gia = Convert.ToDecimal(row.Cells["Gia"].Value) // Thay "Gia" bằng tên cột bạn cần
                    };

                    monList.Add(mon);
                }
            }

            return monList;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            frmHoaDon hoaDonForm = new frmHoaDon();
            parentForm.OpenChildForm(hoaDonForm);
        }
    }
}