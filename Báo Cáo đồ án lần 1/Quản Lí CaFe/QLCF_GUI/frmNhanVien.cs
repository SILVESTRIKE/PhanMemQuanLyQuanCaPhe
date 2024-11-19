using QLCF_BLL;
using QLCF_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

        private bool ValidateInput()
        {
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
            else
            {
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
                    //LoadChucVuComboBox();
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
            //LoadIDQuanLiComboBox();
            //Loadmaql();
            //Bindings();
        }



        private void Bindings()
        {
            txtIDNhanVien.DataBindings.Clear();
            txtIDNhanVien.DataBindings.Add("Text", dgVNhanVien.DataSource, "IDNhanVien");
            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", dgVNhanVien.DataSource, "Ten");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dgVNhanVien.DataSource, "SDT");
            dTNgaySinh.DataBindings.Clear();
            dTNgaySinh.DataBindings.Add("Text", dgVNhanVien.DataSource, "NgSinh");
            cboGTinh.DataBindings.Clear();
            cboGTinh.DataBindings.Add("Text", dgVNhanVien.DataSource, "GTinh");

            //cboTrangThai.DataBindings.Clear();
            //Binding trangThaiBinding = new Binding("Text", dgVNhanVien.DataSource, "TrangThai");

            //trangThaiBinding.Format += (sender, e) =>
            //{
            //    e.Value = (e.Value.ToString() == true) ? Hoat : false;
            //};
            //cboTrangThai.DataBindings.Add(trangThaiBinding);

            ////cboChucVu.DataBindings.Clear();
            ////Binding chucVuBinding = new Binding("Text", dgVNhanVien.DataSource, "IDQuanLy");

            ////chucVuBinding.Format += (sender, e) =>
            ////{
            ////    var row = ((DataRowView)e.Value).Row;
            ////    int idQuanLy = Convert.ToInt32(row["IDQuanLy"]);
            ////    int idNhanVien = Convert.ToInt32(row["IDNhanVien"]);

            ////    e.Value = (idQuanLy == idNhanVien) ? "Quản lý" : "Nhân viên";
            ////};

            ////cboChucVu.DataBindings.Add(chucVuBinding);

            //cboIDQuanLi.DataBindings.Clear();
            //cboIDQuanLi.DataBindings.Add("Text", dgVNhanVien.DataSource, "IDQuanLy");
            txtPass.DataBindings.Clear();
            txtPass.DataBindings.Add("Text", dgVNhanVien.DataSource, "Pass");
        }

        private void LoadChucVuComboBox()
        {
            cboChucVu.Items.Clear();
            cboChucVu.Items.AddRange(new string[] { "Quản lý", "Nhân viên" });
            cboChucVu.SelectedIndex = 0;
        }

        private void LoadTrangThaiComboBox()
        {
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.AddRange(new string[] { "Hoạt động", "Nghỉ" });
            cboTrangThai.SelectedIndex = 0;
        }

        private void RefreshGridView()
        {
            var danhSachNhanVien = nhanVienBLL.getALL();

            DataTable dtNV = new DataTable();
            dtNV.Columns.Add("IDNhanVien");
            dtNV.Columns.Add("Ten");
            dtNV.Columns.Add("SDT");
            dtNV.Columns.Add("GTinh");
            dtNV.Columns.Add("NgSinh");
            dtNV.Columns.Add("TrangThai");
            dtNV.Columns.Add("ChucVu");
            dtNV.Columns.Add("Pass");

            foreach (var nhanVien in danhSachNhanVien)
            {

                string trangThaiText = nhanVien.TrangThai ? "Hoạt động" : "Nghỉ";

                dtNV.Rows.Add(
                    nhanVien.IDNhanVien,
                    nhanVien.Ten,
                    nhanVien.SDT,
                    nhanVien.GTinh,
                    nhanVien.NgSinh.ToString("yyyy-MM-dd"),
                    trangThaiText,
                    nhanVien.ChucVu,
                    nhanVien.Pass
                );
            }

            dgVNhanVien.DataSource = dtNV;
        }



        //private void LoadIDQuanLiComboBox()
        //{
        //    cboIDQuanLi.Items.Clear();
        //    cboIDQuanLi.DataSource = nhanVienBLL.getALL().Select(nl => nl.IDQuanLy).Distinct().ToList();
        //    cboIDQuanLi.SelectedIndex = 0;
        //}

        private NhanVienDTO GetNhanVienFromForm()
        {
            bool trangThai = cboTrangThai.SelectedItem.ToString() == "Hoạt động" ? true : false;
            return new NhanVienDTO
            {
                IDNhanVien = txtIDNhanVien.Text,
                Ten = txtTen.Text,
                SDT = txtSDT.Text,
                GTinh = cboGTinh.Text,
                NgSinh = dTNgaySinh.Value,
                TrangThai = trangThai,
                ChucVu = cboChucVu.Text,
                Pass = txtPass.Text
            };
        }

        private void cboIDQuanLi_Click(object sender, EventArgs e)
        {
            //LoadIDQuanLiComboBox();
        }

        private void dgVNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có click vào dòng hợp lệ hay không
            if (e.RowIndex >= 0)
            {
                // Lấy dòng hiện tại
                DataGridViewRow row = dgVNhanVien.Rows[e.RowIndex];

                // Gán giá trị từ các cột của DataGridView vào các điều khiển
                txtIDNhanVien.Text = row.Cells["IDNhanVien"].Value?.ToString() ?? "";
                txtTen.Text = row.Cells["Ten"].Value?.ToString() ?? "";
                txtSDT.Text = row.Cells["SDT"].Value?.ToString() ?? "";

                // Kiểm tra và gán giá trị cho dTNgaySinh
                if (row.Cells["NgSinh"].Value != DBNull.Value && row.Cells["NgSinh"].Value != null)
                {
                    dTNgaySinh.Value = Convert.ToDateTime(row.Cells["NgSinh"].Value);
                }
                else
                {
                    dTNgaySinh.Value = DateTime.Now; // Hoặc bạn có thể để giá trị mặc định khác
                }

                cboGTinh.Text = row.Cells["GTinh"].Value?.ToString() ?? "";
                txtPass.Text = row.Cells["Pass"].Value?.ToString() ?? "";

                // Xử lý combo box trạng thái (nếu có)
                cboTrangThai.Text = row.Cells["TrangThai"].Value?.ToString() ?? "";


                // Xử lý combo box chức vụ (nếu có)
                cboChucVu.Text = row.Cells["ChucVu"].Value?.ToString() ?? "";
            }
        }
    }
}
