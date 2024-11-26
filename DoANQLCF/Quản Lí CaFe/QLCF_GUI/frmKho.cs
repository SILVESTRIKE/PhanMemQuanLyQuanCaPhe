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
    public partial class frmKho : Form
    {
        NguyenLieuBLL nglieuBLL = new NguyenLieuBLL();

        private bool KT_DL()
        {
            if (string.IsNullOrEmpty(txtMaNL.Text))
            {
                MessageBox.Show("Mã nguyên liệu không được để trống!");
                return false;
            }

            if (string.IsNullOrEmpty(txtTen.Text))
            {
                MessageBox.Show("Tên nguyên liệu không được để trống!");
                return false;
            }

            decimal slTon;
            if (string.IsNullOrEmpty(nbrTon.Text) || !decimal.TryParse(nbrTon.Text, out slTon))
            {
                MessageBox.Show("Số lượng tồn phải là số lớn hơn 0!");
                return false;
            }

            return true;
        }

        public frmKho()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KT_DL())
            {
                string idNguyenLieu = txtMaNL.Text;
                string tenNguyenLieu = txtTen.Text;
                int slTon = int.Parse(nbrTon.Text);
                string dvTinh = cboDVT.Text;

                NguyenLieuDTO nguyenLieu = new NguyenLieuDTO(idNguyenLieu, tenNguyenLieu, slTon, dvTinh);
                bool kq = nglieuBLL.AddNguyenLieu(nguyenLieu);

                if (kq)
                {
                    MessageBox.Show("Thêm nguyên liệu thành công!");
                    Load_Grv();
                }
                else
                {
                    MessageBox.Show("Lỗi: Nguyên liệu đã tồn tại hoặc có lỗi xảy ra!");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (KT_DL())
            {
                string idNguyenLieu = txtMaNL.Text;
                string tenNguyenLieu = txtTen.Text;
                int slTon = int.Parse(nbrTon.Text);
                string dvTinh = cboDVT.Text;

                NguyenLieuDTO nguyenLieu = new NguyenLieuDTO(idNguyenLieu, tenNguyenLieu, slTon, dvTinh);
                bool kq = nglieuBLL.UpdateNguyenLieu(nguyenLieu);

                if (kq)
                {
                    MessageBox.Show("Sửa nguyên liệu thành công!");
                    Load_Grv();
                }
                else
                {
                    MessageBox.Show("Lỗi khi sửa nguyên liệu!");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaNL.Text))
            {
                string idNguyenLieu = txtMaNL.Text;
                bool kq = nglieuBLL.DeleteNguyenLieu(new NguyenLieuDTO { IDNguyenLieu = idNguyenLieu });

                if (kq)
                {
                    MessageBox.Show("Xóa nguyên liệu thành công!");
                    Load_Grv();
                }
                else
                {
                    MessageBox.Show("Lỗi: Không thể xóa nguyên liệu!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu để xóa!");
            }
        }

        public void Load_Grv()
        {
            dgVNguyenLieu.DataSource = nglieuBLL.GetAllNgLieu();
        }

        public void Bindings()
        {
            txtMaNL.DataBindings.Clear();
            txtMaNL.DataBindings.Add("Text", dgVNguyenLieu.DataSource, "IDNguyenLieu");

            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", dgVNguyenLieu.DataSource, "TenNL");

            nbrTon.DataBindings.Clear();
            nbrTon.DataBindings.Add("Text", dgVNguyenLieu.DataSource, "SLTon");

            cboDVT.DataBindings.Clear();
            cboDVT.DataBindings.Add("Text", dgVNguyenLieu.DataSource, "DVTinh");
        }

        public void LoadComboBoxDVT()
        {
            cboDVT.DataSource = nglieuBLL.GetAllNgLieu().Select(nl => nl.DVTinh).Distinct().ToList();
        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            Load_Grv();
            Bindings();
            LoadComboBoxDVT();
        }
    }
}