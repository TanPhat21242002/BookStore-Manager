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
    public partial class Sach : Form
    {
        int masach = 0;
        public Sach()
        {
            InitializeComponent();
        }
        private void LoadDgvSach()
        {
            dgvSach.DataSource = SachBL.GetInstance.GetDanhSachSach();
            dgvSach.ClearSelection();
        }
        private void LamMoi()
        {
            txtSoLuong.Clear();
            txtNXB.Clear();
            txtnamxb.Clear();
            txtGia.Clear();
        }
        private void btnApDung_Click(object sender, EventArgs e)
        {

        }

        private void cboLocLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Sach_Load(object sender, EventArgs e)
        {
            CboDauSach.DataSource = DauSachBL.GetInstance.getDsDauSach();
            CboDauSach.DisplayMember = "TenDauSach";
            CboDauSach.ValueMember = "MaDauSach";
            LoadDgvSach();

        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            SACH sachDTO = new SACH();
            sachDTO.MaSach = masach;
            sachDTO.NamXuatBan = int.Parse(txtnamxb.Text);
            sachDTO.NhaXuatBan = txtNXB.Text;
            sachDTO.DonGiaBan= int.Parse(txtGia.Text);
            sachDTO.SoLuongTon = int.Parse(txtSoLuong.Text);
            sachDTO.MaDauSach = int.Parse(CboDauSach.SelectedValue.ToString().Trim());


            if (SachBL.GetInstance.ThemSach(sachDTO))
            {
                LoadDgvSach();
                LamMoi();
            }
        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void CboDauSach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnCapNhatSP_Click(object sender, EventArgs e)
        {
            SACH sachDTO = new SACH();
            sachDTO.MaSach = masach;
            sachDTO.NamXuatBan = int.Parse(txtnamxb.Text);
            sachDTO.NhaXuatBan = txtNXB.Text;
            sachDTO.DonGiaBan = int.Parse(txtGia.Text);
            sachDTO.SoLuongTon = int.Parse(txtSoLuong.Text);

            if (SachBL.GetInstance.SuaThongTinSach(sachDTO))
            {
                LoadDgvSach();
                LamMoi();
            }
        }

        private void dgvSach_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgvSach.SelectedRows[0];
                masach =int.Parse(dr.Cells["Mã sách"].Value.ToString().Trim());
                txtNXB.Text = dr.Cells["NXB"].Value.ToString().Trim();
                txtnamxb.Text = dr.Cells["Năm xuất bản"].Value.ToString().Trim();
                txtSoLuong.Text = dr.Cells["Số lượng"].Value.ToString().Trim();
                txtGia.Text = dr.Cells["Đơn giá"].Value.ToString().Trim();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnLamMoiThongTin_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void btnNgungKinhDoanh_Click(object sender, EventArgs e)
        {
            if (SachBL.GetInstance.XoaSach(masach))
            {
                LamMoi();
                LoadDgvSach();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void pnlThongTinSanPham_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
