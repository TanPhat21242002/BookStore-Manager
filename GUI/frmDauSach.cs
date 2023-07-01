using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace GUI
{
    public partial class frmDauSach : Form
    {
        int madausach = 0;
        public frmDauSach()
        {
            InitializeComponent();
        }
        private void LoadDgvDauSach()
        {
            dgvDauSach.DataSource = DauSachBL.GetInstance.GetDanhSachDauSach();
            dgvDauSach.ClearSelection();
        }
        private void DauSach_Load(object sender, EventArgs e)
        {
            LoadDgvDauSach();
        }
        private void LamMoi()
        {
            txtTenSach.Clear();
            txtTG.Clear();
            txtTheLoai.Clear();
        }
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            DAUSACH dsDTO = new DAUSACH();
            dsDTO.MaDauSach = madausach;
            dsDTO.TenDauSach = txtTenSach.Text;
            dsDTO.TenTacGia = txtTG.Text;
            dsDTO.TheLoai = txtTheLoai.Text;

            if (DauSachBL.GetInstance.ThemDauSach(dsDTO))
            {
                LoadDgvDauSach();
                LamMoi();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (DauSachBL.GetInstance.XoaDauSach(madausach))
            {
                LamMoi();
                LoadDgvDauSach();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void dgvDauSach_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgvDauSach.SelectedRows[0];
                madausach = int.Parse(dr.Cells["Mã đầu sách"].Value.ToString().Trim());
                txtTenSach.Text = dr.Cells["Tên sách"].Value.ToString().Trim();
                txtTG.Text = dr.Cells["Tên tác giả"].Value.ToString().Trim();
                txtTheLoai.Text = dr.Cells["Thể loại"].Value.ToString().Trim();
            }
            catch (Exception)
            {

               
            }
        }

        private void btnCapNhatSP_Click(object sender, EventArgs e)
        {
            DAUSACH ds = new DAUSACH();
            ds.MaDauSach = madausach;
            ds.TenDauSach = txtTenSach.Text;
            ds.TenTacGia = txtTG.Text;
            ds.TheLoai = txtTheLoai.Text;


            if (DauSachBL.GetInstance.SuaThongTinDauSach(ds))
            {
                LoadDgvDauSach();
                LamMoi();
            }
        }

        private void txtTenSach_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
