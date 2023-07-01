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
    public partial class frmBanSach : Form
    {
        int SOHD;
        public frmBanSach()
        {
            InitializeComponent();
        }
        //int masach;
        public static double ThanhTien = 0;
        bool hd = false;
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
            SACH u = new SACH();
            int tong = 0;
            DataGridViewRow dr = dgvSach.SelectedRows[0];
            u.MaSach = int.Parse(dr.Cells["Mã sách"].Value.ToString().Trim());
            u.TenSach = dr.Cells["Tên sách"].Value.ToString();
            u.NhaXuatBan = dr.Cells["NXB"].Value.ToString().Trim();
            u.NamXuatBan = int.Parse(dr.Cells["Năm xuất bản"].Value.ToString().Trim());
            u.SoLuongTon = 1;
            u.DonGiaBan = int.Parse(dr.Cells["Đơn giá"].Value.ToString().Trim());

            //dgvCTHD.Rows.Add(new object[] { u.MaSach, u.TenSach, u.DonGiaBan,0 , u.DonGiaBan });
            for (int i = 0; i < dgvCTHD.Rows.Count; i++)
            {
                DataGridViewRow r = dgvCTHD.Rows[i];
                if (int.Parse(r.Cells[0].Value.ToString()) == u.MaSach)
                {
                    dgvCTHD.Rows[i].Cells[3].Value = int.Parse(r.Cells[3].Value.ToString()) + 1;
                    dgvCTHD.Rows[i].Selected = true;
                    int dongia = int.Parse(r.Cells[2].Value.ToString());
                    tong = dongia * int.Parse(r.Cells[3].Value.ToString());
                    dgvCTHD.Rows[i].Cells[4].Value = tong;
                    LoadTongHoaDon();
                    if (hd == true)
                    {

                    }
                    else
                    {
                        ThemHoaDon();
                        hd = true;
                        //txtSDT.Enabled = false;
                    }
                    return;
                }
            }
            tong = u.DonGiaBan;
            dgvCTHD.Rows.Insert(dgvCTHD.Rows.Count, u.MaSach, u.TenSach, u.DonGiaBan, 1, tong, "-", "+");
            dgvCTHD.Rows[dgvCTHD.Rows.Count - 1].Selected = true;
            LoadTongHoaDon();
            if (hd == true)
            {

            }
            else
            {
                ThemHoaDon();
                hd = true;
                //txtSDT.Enabled = false;
            }
            btnHuy.BackColor = Color.Red;
        }
        private void ThemHoaDon()
        {
            HOADON hddTO = new HOADON();
            if (txtSDT.Text == "")
                hddTO.MaKH = 1;
            //else
                //hddTO.MaKH = KhachHangBL.GetInstance.GetMaKhSDT(txtSDT.Text);
            //hddTO.MaKH = frmDangNhap.TenDangNhap;
            hddTO.NgHD = DateTime.Now;
            hddTO.TongTien = 0;
            hddTO.MaNV = 1;
            HOADONBL.GetInstance.ThemHoaDon(hddTO);
            SOHD = HOADONBL.GetInstance.GetSOHDMax();
            btnHuy.BackColor = Color.OrangeRed;
            frmThongBao frm = new frmThongBao();
            frm.lblThongBao.Text = "Thêm thành công";
            frm.ShowDialog();
            //txtSDT.Enabled = false;
        }
        private void LoadTongHoaDon()
        {
            try
            {
                decimal tong = 0;
                for (int i = 0; i < dgvCTHD.Rows.Count; i++)
                {
                    tong += int.Parse(dgvCTHD.Rows[i].Cells[4].Value.ToString());
                }
                ThanhTien = (double)tong;
                lblTongTien.Text = convertgia((int)tong) + " ₫";
                if (txtTienKHTra.Text == "")
                    return;
                if (tong < int.Parse(txtTienKHTra.Text))
                {
                    txtTienThua.Text = ((Math.Abs(ThanhTien - int.Parse(txtTienKHTra.Text)))) + "";
                    btnThanhToan.BackColor = Color.Green;
                }
                else
                {
                    txtTienThua.Text = "Không đủ";
                    btnThanhToan.BackColor = Color.Gray;
                }
            }
            catch (Exception)
            {

                
            }
        }
        private string convertgia(int gia)
        {
            string giaban = gia.ToString();
            string result = "";
            int d = 0;
            for (int i = giaban.Length - 1; i >= 0; i--)
            {
                d++;
                result += giaban[i];
                if (d == 3 && i != 0)
                {
                    result += ',';
                    d = 0;
                }
            }
            char[] charArray = result.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private void dgvCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                DataGridViewRow r = dgvCTHD.SelectedRows[0];
                for (int i = 0; i < dgvCTHD.Rows.Count; i++)
                {
                    if (r.Cells[0].Value.ToString() == dgvCTHD.Rows[i].Cells[0].Value.ToString())
                    {
                        if (int.Parse(r.Cells[3].Value.ToString()) == 1)
                        {
                            dgvCTHD.Rows.Remove(r);
                            return;
                        }
                        dgvCTHD.Rows[i].Cells[3].Value = int.Parse(r.Cells[3].Value.ToString()) - 1;
                        dgvCTHD.Rows[i].Selected = true;
                        int dongia = int.Parse(r.Cells[2].Value.ToString());
                        int tong = dongia * int.Parse(r.Cells[3].Value.ToString());
                        dgvCTHD.Rows[i].Cells[4].Value = tong;
                        LoadTongHoaDon();
                        if (txtTienKHTra.Text != "")
                        {
                            if (ThanhTien < int.Parse(txtTienKHTra.Text))
                                txtTienThua.Text = ((Math.Abs(ThanhTien - int.Parse(txtTienKHTra.Text)))) + "";
                            else
                            {
                                txtTienThua.Text = "Không đủ";
                                btnThanhToan.BackColor = Color.Gray;
                            }
                        }

                        return;
                    }
                }
            }
            if (e.ColumnIndex == 6)
            {
                DataGridViewRow r = dgvCTHD.SelectedRows[0];
                for (int i = 0; i < dgvCTHD.Rows.Count; i++)
                {
                    if (r.Cells[0].Value.ToString() == dgvCTHD.Rows[i].Cells[0].Value.ToString())
                    {
                        /*                        if (int.Parse(r.Cells[4].Value.ToString()) + 1 > SANPHAMBL.GetInstance.GetSoLuongMatHang(int.Parse(r.Cells[0].Value.ToString())))
                                                {
                                                    MessageBox.Show("Nhập ít thôi, quá số lượng rầu !!");
                                                }
                                                else*/
                        dgvCTHD.Rows[i].Cells[3].Value = int.Parse(r.Cells[3].Value.ToString()) + 1;
                        dgvCTHD.Rows[i].Selected = true;
                        int dongia = int.Parse(r.Cells[2].Value.ToString());
                        int tong = dongia * int.Parse(r.Cells[3].Value.ToString());
                        dgvCTHD.Rows[i].Cells[4].Value = tong;
                        LoadTongHoaDon();
                        try
                        {
                            if (ThanhTien <= int.Parse(txtTienKHTra.Text))
                            {
                                txtTienThua.Text = ((Math.Abs(ThanhTien - int.Parse(txtTienKHTra.Text)))).ToString() + "";

                            }
                            else
                            {
                                txtTienThua.Text = "Không đủ";
                                btnThanhToan.BackColor = Color.Gray;
                            }
                        }
                        catch (Exception)
                        {
                            return;
                        }

                        return;
                    }
                }
            }
        }

        private void txtTienKHTra_TextChanged(object sender, EventArgs e)
        {
             if (txtTienKHTra.Text != "")
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                double value = double.Parse(txtTienKHTra.Text, System.Globalization.NumberStyles.AllowThousands);
                txtTienKHTra.Text = String.Format(culture, "{0:N0}", value);
                txtTienKHTra.Select(txtTienKHTra.Text.Length, 0);

                try
                {
                    if (ThanhTien <= double.Parse(txtTienKHTra.Text))
                    {
                        txtTienThua.Text = Math.Abs((ThanhTien - double.Parse(txtTienKHTra.Text))) + "";
                        System.Globalization.CultureInfo c = new System.Globalization.CultureInfo("en-US");
                        double v = double.Parse(txtTienThua.Text, System.Globalization.NumberStyles.AllowThousands);
                        txtTienThua.Text = String.Format(c, "{0:N0}", v);
                        txtTienThua.Select(txtTienThua.Text.Length, 0);
                        btnThanhToan.BackColor = Color.Green;
                    }
                    else
                    {
                        txtTienThua.Text = "Không đủ";
                        btnThanhToan.BackColor = Color.Gray;
                    }
                }
                catch (Exception)
                {
                    return;
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (btnThanhToan.BackColor == Color.Gray)
                return;
            frmThongBao frm = new frmThongBao();
            frm.lblThongBao.Text = "Đã thanh toán đơn hàng";
            frm.ShowDialog();
            this.Cursor = Cursors.AppStarting;
            if (txtSDT.Text != "")
            {
/*                KhachHangBL.GetInstance.CapNhatDoanhSoKhachHang(txtSDT.Text, ThanhTien);
                HOADONBL.GetInstance.CapNhatTenKhachHang(KhachHangBL.GetInstance.GetMaKhSDT(txtSDT.Text.Trim()), SOHD);*/
            }
            ThemCTDH();
            LoadDgvSach();
            txtSDT.Enabled = true;
            this.Cursor = Cursors.Default;
        }
        private void CapNhatSoLuong()
        {
            for (int i = 0; i < dgvCTHD.Rows.Count; i++)
            {
                DataGridViewRow r = dgvCTHD.Rows[i];
                SachBL.GetInstance.CapNhatSoLuongKhiBanHang(int.Parse(r.Cells[0].Value.ToString()), int.Parse(r.Cells[4].Value.ToString()));
            }
        }
        private void ThemCTDH()
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in dgvCTHD.Columns)
            {
                dt.Columns.Add(col.Name);
            }

            foreach (DataGridViewRow row in dgvCTHD.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
            }
            if (HOADONBL.GetInstance.ThemCTHD(dt, SOHD, decimal.Parse(ThanhTien.ToString()),txtTienKHTra.Text,txtTienThua.Text))
            {
                CapNhatSoLuong();
                //SOHD_Report = SOHD;
                //CapNhatTienKhachHang();
                ClearThongTinHD();
                SOHD = 0;
            }
        }
        private void ClearThongTinHD()
        {
            dgvCTHD.Rows.Clear();
            lblTongTien.Text = "0";
            txtTienKHTra.Text = "";
            txtTienThua.Text = "";
            txtSDT.Text = "";
            btnThanhToan.BackColor = Color.Gray;
            btnHuy.BackColor = Color.Gray;
        }

        private void pnlThongTinSanPham_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
