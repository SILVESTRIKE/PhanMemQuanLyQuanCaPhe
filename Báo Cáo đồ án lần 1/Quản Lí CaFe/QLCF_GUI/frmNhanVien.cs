using QLCF_BLL;
using QLCF_DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QLCF_GUI
{
    public partial class frmNhanVien : Form
    {
        private NhanVienBLL nhanVienBLL = new NhanVienBLL();

        public frmNhanVien()
        {
            InitializeComponent();
        }

        // Validate input data
        private bool ValidateInput()
        {
            // Collect all the missing fields in a list
            List<string> missingFields = new List<string>();

            if (string.IsNullOrWhiteSpace(txtIDNhanVien.Text))
            {
                missingFields.Add("Mã nhân viên");
            }
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                missingFields.Add("Tên nhân viên");
            }
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                missingFields.Add("Số điện thoại");
            }
            if (dTNgaySinh.Value == null || dTNgaySinh.Value == DateTime.MinValue)
            {
                missingFields.Add("Ngày sinh");
            }

            // If any fields are missing, show them all in one message box
            if (missingFields.Count > 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cho các trường: " + string.Join(", ", missingFields));
                return false;
            }

            return true;
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var nhanVien = GetNhanVienFromForm();
                if (nhanVienBLL.insert(nhanVien))
                {
                    MessageBox.Show("Thêm nhân viên thành công!");
                    RefreshGridView();
                }
                else
                {
                    MessageBox.Show("Lỗi: Nhân viên đã tồn tại hoặc có lỗi xảy ra!");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var nhanVien = GetNhanVienFromForm();
                if (nhanVienBLL.edit(nhanVien))
                {
                    MessageBox.Show("Sửa nhân viên thành công!");
                    RefreshGridView();
                }
                else
                {
                    MessageBox.Show("Lỗi: Không thể sửa thông tin nhân viên!");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var idNhanVien = txtIDNhanVien.Text;
            if (nhanVienBLL.delete(new NhanVienDTO { IDNhanVien = idNhanVien }))
            {
                MessageBox.Show("Xóa nhân viên thành công!");
                RefreshGridView();
            }
            else
            {
                MessageBox.Show("Lỗi: Không thể xóa nhân viên!");
            }
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            RefreshGridView();
            LoadTrangThaiComboBox();
            LoadChucVuComboBox();
            BindControls();
        }

        // Load data to DataGridView
        private void RefreshGridView()
        {
            dgVNhanVien.DataSource = nhanVienBLL.getALL();
        }

        // Bind data from DataGridView to form controls
        private void BindControls()
        {
            txtIDNhanVien.DataBindings.Clear();
            txtIDNhanVien.DataBindings.Add("Text", dgVNhanVien.DataSource, "IDNhanVien");
            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", dgVNhanVien.DataSource, "Ten");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dgVNhanVien.DataSource, "SDT");
            dTNgaySinh.DataBindings.Clear();
            dTNgaySinh.DataBindings.Add("Text", dgVNhanVien.DataSource, "NgSinh");
            rdoNam.DataBindings.Clear();
            rdoNam.DataBindings.Add("Checked", dgVNhanVien.DataSource, "GTinh", true, DataSourceUpdateMode.OnPropertyChanged);
            rdoNu.DataBindings.Clear();
            rdoNu.DataBindings.Add("Checked", dgVNhanVien.DataSource, "GTinh", false, DataSourceUpdateMode.OnPropertyChanged);
            cboTrangThai.DataBindings.Clear();
            cboTrangThai.DataBindings.Add("Checked", dgVNhanVien.DataSource, "TrangThai");
            cboChucVu.DataBindings.Clear();
            cboChucVu.DataBindings.Add("Text", dgVNhanVien.DataSource, "IDQuanLy");
            txtPass.DataBindings.Clear();
            txtPass.DataBindings.Add("Text", dgVNhanVien.DataSource, "Pass");
        }
        private void LoadTrangThaiComboBox()
        {
            List<string> trangThaiOptions = nhanVienBLL.GetTrangThaiOptions();
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.AddRange(trangThaiOptions.ToArray());
            cboTrangThai.SelectedIndex = 0;
        }
        private void LoadChucVuComboBox()
        {
            cboChucVu.Items.Clear();
            cboChucVu.Items.AddRange(nhanVienBLL.GetChucVuOptions());
            cboChucVu.SelectedIndex = 0; 
        }
        private NhanVienDTO GetNhanVienFromForm()
        {
            bool trangThai = cboTrangThai.SelectedItem.ToString() == "Hoạt động" ? true : false;
            string chucVu = cboChucVu.SelectedItem.ToString();
            string idQuanLy = nhanVienBLL.GetIDQuanLy(chucVu, txtIDNhanVien.Text);

            if (chucVu == "Nhân viên" && string.IsNullOrEmpty(idQuanLy))
            {
                // If "Nhân viên" is selected and IDQuanLy is not provided, ask for the manager's ID
                if (MessageBox.Show("Vui lòng nhập ID Quản lý", "Nhập ID Quản lý", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    // Open a prompt to get IDQuanLy (can be a simple TextBox or input box)
                    using (var frm = new frmIDQuanLi()) // Assuming InputBoxForm is a form to get user input
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            idQuanLy = frm.InputText; // Assuming this is where the input is stored
                        }
                        else
                        {
                            return null; // Cancel if no input is provideds
                        }
                    }
                }
            }
            return new NhanVienDTO
            {
                IDNhanVien = txtIDNhanVien.Text,
                Ten = txtTen.Text,
                SDT = txtSDT.Text,
                GTinh = rdoNam.Checked ? "Nam" : (rdoNu.Checked ? "Nữ" : ""),
                NgSinh = dTNgaySinh.Value,
                TrangThai = trangThai,
                IDQuanLy = cboChucVu.Text,
                Pass = txtPass.Text
            };
        }
    }
}
