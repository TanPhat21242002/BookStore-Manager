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
    public partial class KhachHang : Form
    {
        int makh = 0;
        public KhachHang()
        {
            InitializeComponent();
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadDgvKhachHang()
        {
            dgvKhachHang.DataSource = KhachHangBL.GetInstance.GetDanhSachKhachHang();
            dgvKhachHang.ClearSelection();
        }
        private void KhachHang_Load(object sender, EventArgs e)
        {
            LoadDgvKhachHang();
        }
        private void LamMoi()
        {
            txtTen.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtSoDienThoai.Clear();
        }
        private void btnThemSP_Click(object sender, EventArgs e)
        {
                            KHACHHANG khDTO = new KHACHHANG();
                            khDTO.MaKH = makh;
                            khDTO.TenKH = txtTen.Text;
                            khDTO.DiaChi = txtDiaChi.Text;
                            khDTO.SDT = txtSoDienThoai.Text;
                            khDTO.Email = txtEmail.Text;

                            if (KhachHangBL.GetInstance.ThemKhachHang(khDTO))
                            {
                                LoadDgvKhachHang();
                                LamMoi();
                            }
        }
      
        private void dgvKhachHang_Click(object sender, EventArgs e)
        {    
            DataGridViewRow dr = dgvKhachHang.SelectedRows[0];
            makh = int.Parse(dr.Cells["Mã KH"].Value.ToString().Trim());
            txtTen.Text = dr.Cells["Tên KH"].Value.ToString().Trim(); 
            txtSoDienThoai.Text = dr.Cells["SĐT"].Value.ToString().Trim();
            txtDiaChi.Text = dr.Cells["Địa Chỉ"].Value.ToString().Trim();
            txtEmail.Text = dr.Cells["Email"].Value.ToString().Trim();
            
        }

        private void btnLamMoiThongTin_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void btnNgungKinhDoanh_Click(object sender, EventArgs e)
        {
            if (KhachHangBL.GetInstance.XoaKhachHang(makh))
            {
                LamMoi();
                LoadDgvKhachHang();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void btnCapNhatSP_Click(object sender, EventArgs e)
        {
      
                KHACHHANG khDTO = new KHACHHANG();
                khDTO.MaKH = makh;
                khDTO.TenKH = txtTen.Text;
                khDTO.DiaChi = txtDiaChi.Text;
                khDTO.SDT = txtSoDienThoai.Text;
                khDTO.Email = txtEmail.Text;

                if (KhachHangBL.GetInstance.SuaThongTinKhachHang(khDTO))
                {
                    LoadDgvKhachHang();
                    LamMoi();
                }
            
        }
    }
}
