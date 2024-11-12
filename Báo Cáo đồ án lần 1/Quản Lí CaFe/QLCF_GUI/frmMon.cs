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
    public partial class frmMon : Form
    {
        MonBLL monBLL = new MonBLL();
        private bool KT_DL()
        {
            if (txtmamon.Text == string.Empty)
            {
                MessageBox.Show("Ma mon khong duoc de trong!");
                return false;
            }

            if (txtmamon.Text == string.Empty)
            {
                MessageBox.Show("Ten mon khong duoc de trong!");
                return false;
            }
            decimal price;
            if (txtgia.Text == string.Empty || !decimal.TryParse(txtgia.Text, out price))
            {
                MessageBox.Show("Giá món không hợp lệ!");
                return false;
            }
            return true;
        }
        public frmMon()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bool kt = KT_DL();
            if (kt == true)
            {
                string idMon = txtmamon.Text;
                string tenMon = txtTenMon.Text;
                decimal price = Convert.ToDecimal(txtgia.Text);

                MonDTO mon = new MonDTO(idMon, tenMon, price);
                bool kq = monBLL.AddMon(mon);

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
                string idMon = txtmamon.Text;
                string tenMon = txtTenMon.Text;
                decimal price = Convert.ToDecimal(txtgia.Text);
                MonDTO mon = new MonDTO(idMon, tenMon, price);
                bool kq = monBLL.UpdateMon(mon);
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
                string idMon = txtmamon.Text;
                string tenMon = txtTenMon.Text;
                decimal price = Convert.ToDecimal(txtgia.Text);
                MonDTO mon = new MonDTO(idMon, tenMon, price);
                bool kq = monBLL.DeleteMon(mon);


                if (kq == true)
                {
                    MessageBox.Show("XÓA MÓN THÀNH CÔNG!");
                    Load_Grv(); // Cập nhật lại danh sách
                }
                else
                {
                    MessageBox.Show("LỖI: Không thể xóa món!");
                }
            }
        }

        private void dgVMon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void Load_Grv()
        {
            dgVMon.DataSource = monBLL.GetAllMon();
        }
        public void Bindings()
        {
            txtTenMon.DataBindings.Clear();
            txtTenMon.DataBindings.Add("Text", dgVMon.DataSource, "TenMon");
            txtgia.DataBindings.Clear();
            txtgia.DataBindings.Add("Text", dgVMon.DataSource, "Gia");
            txtmamon.DataBindings.Clear();
            txtmamon.DataBindings.Add("Text", dgVMon.DataSource, "IDMon");
        }

        private void frmMon_Load(object sender, EventArgs e)
        {
            Load_Grv();
            Bindings();
        }
    }
}
