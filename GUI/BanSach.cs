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
    public partial class BanSach : Form
    {
        public BanSach()
        {
            InitializeComponent();
        }
        int masach;
        private void LoadDgvSach()
        {
            dgvSach.DataSource = SachBL.GetInstance.GetDanhSachSach();
            dgvSach.ClearSelection();
        }
        private void BanSach_Load(object sender, EventArgs e)
        {
            LoadDgvSach();
        }

        private void dgvSach_Click(object sender, EventArgs e)
        {
            try
            {
                SACH u = new SACH();
                DataGridViewRow dr = dgvSach.SelectedRows[0];
                masach = int.Parse(dr.Cells["Mã sách"].Value.ToString().Trim());
                u.TenSach = dr.Cells["Tên sách"].Value.ToString().Trim();
                txtTeSac.Text = u.TenSach;
                u.DonGiaBan = int.Parse(dr.Cells["Đơn giá"].Value.ToString().Trim());
                int tong = u.DonGiaBan;
                for (int i = 0; i < dgvCTHD.Rows.Count; i++)
                {
                    DataGridViewRow r = dgvCTHD.Rows[i];
                    //dgvCTHD.Rows[i].Cells[4].Value = int.Parse(r.Cells[4].Value.ToString()) + 1;
                    dgvCTHD.Rows[i].Selected = true;
                    dgvCTHD.Rows[i].Cells[5].Value = tong;



                   

                    dgvCTHD.Rows.Insert(dgvCTHD.Rows.Count, u.TenSach, u.DonGiaBan, 1, tong, "-", "+");
                    dgvCTHD.Rows[dgvCTHD.Rows.Count - 1].Selected = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void pnlThongTinSanPham_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvCTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
