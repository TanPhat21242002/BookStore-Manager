using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace GUI
{
    public partial class frmNhanVien : Form
    {
        int manv = 0;
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            NHANVIEN nvDTO = new NHANVIEN();
            nvDTO.MaNV = manv;
            nvDTO.TenNV = txtTen.Text;
            nvDTO.DiaChi = txtDiaChi.Text;
            nvDTO.SDT = txtSoDienThoai.Text;

            if (NhanVienBL.GetInstance.ThemNhanVien(nvDTO))
            {
                LoadDgvNhanVien();
                LamMoi();
            }
        }
        private void LamMoi()
        {
            txtTen.Clear();
            txtDiaChi.Clear();
            txtSoDienThoai.Clear();
            txtTenNV.Clear();
        }
        private void LoadDgvNhanVien()
        {
            dgvNhanVien.DataSource = NhanVienBL.GetInstance.GetDanhSachNhanVien();
            dgvNhanVien.ClearSelection();
        }
        private void NhanVien_Load(object sender, EventArgs e)
        {
            LoadDgvNhanVien();
        }

        private void btnLamMoiThongTin_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void btnNgungKinhDoanh_Click(object sender, EventArgs e)
        {
            if (NhanVienBL.GetInstance.XoaNhanVien(manv))
            {
                LamMoi();
                LoadDgvNhanVien();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void NhanVien_Click(object sender, EventArgs e)
        {
           
           
        }

        private void btnCapNhatSP_Click(object sender, EventArgs e)
        {
    
                NHANVIEN nvDTO = new NHANVIEN();
                nvDTO.MaNV = manv;
                nvDTO.TenNV = txtTen.Text;
                nvDTO.DiaChi = txtDiaChi.Text;
                nvDTO.SDT = txtSoDienThoai.Text;
               

                if (NhanVienBL.GetInstance.SuaThongTinNhanVien(nvDTO))
                {
                    LoadDgvNhanVien();
                    LamMoi();
                }
            
        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {

            try
            {
                DataGridViewRow dr = dgvNhanVien.SelectedRows[0];
                
                txtTen.Text = dr.Cells["Tên NV"].Value.ToString().Trim();
                txtSoDienThoai.Text = dr.Cells["SĐT"].Value.ToString().Trim();
                txtDiaChi.Text = dr.Cells["Địa Chỉ"].Value.ToString().Trim();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtMaTK_TextChanged(object sender, EventArgs e)
        {
            if (txtTenNV.Text != "")
            {
                dgvNhanVien.DataSource = NhanVienBL.GetInstance.GetDanhSachNhanVienTimKiem(txtTenNV.Text);
                dgvNhanVien.ClearSelection();
            }
            else
            {
                LoadDgvNhanVien();
            }
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
