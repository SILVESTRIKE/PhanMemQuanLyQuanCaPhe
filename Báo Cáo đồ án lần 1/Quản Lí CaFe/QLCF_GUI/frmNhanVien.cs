using QLCF_BLL;
using QLCF_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
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
            List<string> missingFields = new List<string>();

            // Check required fields
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
            else
            {
                // Validate phone number format
                string phonePattern = @"^(\+?\d{1,4}|\d{1,4})?\(?\d{1,4}\)?[\d\s\-]{3,}$";
                if (!Regex.IsMatch(txtSDT.Text, phonePattern))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!");
                    return false;
                }
            }
            if (dTNgaySinh.Value == null || dTNgaySinh.Value == DateTime.MinValue)
            {
                missingFields.Add("Ngày sinh");
            }

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
            try
            {
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
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            RefreshGridView();
            LoadTrangThaiComboBox();
            LoadChucVuComboBox();
            BindControls();
        }

        private void RefreshGridView()
        {
            dgVNhanVien.DataSource = nhanVienBLL.getALL();
        }

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

            // Bind radio buttons for gender (GTinh)
            rdoNam.CheckedChanged -= rdoNam_CheckedChanged; // Remove previous event handler to avoid multiple subscriptions
            rdoNu.CheckedChanged -= rdoNu_CheckedChanged;
            if (dgVNhanVien.DataSource != null)
            {
                var gender = (dgVNhanVien.DataSource as DataRowView)?["GTinh"]?.ToString();
                if (gender == "Nam")
                {
                    rdoNam.Checked = true;
                }
                else if (gender == "Nữ")
                {
                    rdoNu.Checked = true;
                }
            }
            rdoNam.CheckedChanged += rdoNam_CheckedChanged;
            rdoNu.CheckedChanged += rdoNu_CheckedChanged;

            cboTrangThai.DataBindings.Clear();
            cboTrangThai.DataBindings.Add("Text", dgVNhanVien.DataSource, "TrangThai");
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
                // Ask for manager's ID if the user selects "Nhân viên" but no manager is assigned
                if (MessageBox.Show("Vui lòng nhập ID Quản lý", "Nhập ID Quản lý", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    using (var frm = new frmIDQuanLi()) // Assuming this form collects the manager ID
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            idQuanLy = frm.InputText; // Assuming this is where the input is stored
                        }
                        else
                        {
                            return null; // Cancel if no input is provided
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

        // Event handlers for RadioButtons (to ensure proper gender binding)
        private void rdoNam_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNam.Checked)
            {
                rdoNu.Checked = false;
            }
        }

        private void rdoNu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNu.Checked)
            {
                rdoNam.Checked = false;
            }
        }
    }
}
