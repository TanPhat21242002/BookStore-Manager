using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class SachBL
    {
        private static SachBL Instance;
        public static SachBL GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new SachBL();
                }
                return Instance;
            }
        }
        private SachBL() { }
        Context db = new Context();
        public bool CapNhatSoLuongKhiBanHang(int MaSP, int SoLuong)
        {
            //string sql = "UPDATE SANPHAM SET SoLuong = SoLuong-@SoLuong WHERE MASP = @MASP";
            var context = new Context();
            var saveSoLuongSanPHam = context.SACHes;
            if (saveSoLuongSanPHam.Any())
            {
                var sanpham = saveSoLuongSanPHam.First(o => o.MaSach == MaSP);
                sanpham.SoLuongTon = sanpham.SoLuongTon - SoLuong;
                context.SaveChanges();
            }
            return true;
        }
        public DataTable GetDanhSachTacGiaTimKiem(string tentg)
        {
            return db.DataTable("SELECT DAUSACH.TenDauSach as N'Thể loại', DAUSACH.TenTacGia as N'Tác giả', TenSach as N'Tên sách', MaSach as N'Mã sách', NhaXuatBan as N'NXB', NamXuatBan as N'Năm xuất bản', SoLuongTon as N'Số lượng', DonGiaBan as N'Đơn giá' from SACH INNER JOIN DAUSACH ON SACH.MaDauSach = DAUSACH.MaDauSach WHERE MaSach != 1 AND TenTacGia LIKE N'%" + tentg + "%'");
        }
        public DataTable GetDanhSachSach()
        {
            return db.DataTable("SELECT SACH.MaSach as N'Mã sách', SACH.TenSach as N'Tên sách', DAUSACH.TenTacGia as N'Tác giả',DAUSACH.TenDauSach as N'Đầu sách', NhaXuatBan as N'NXB', NamXuatBan as N'Năm xuất bản', SoLuongTon as N'Số lượng', DonGiaBan as N'Đơn giá',DAUSACH.MaDauSach as N'Mã đầu sách' from SACH INNER JOIN DAUSACH ON SACH.MaDauSach = DAUSACH.MaDauSach");
        }
        public bool ThemSach(SACH c)
        {
            var context = new Context();
           
            var sach = new SACH {MaDauSach=c.MaDauSach,NhaXuatBan = c.NhaXuatBan, NamXuatBan = c.NamXuatBan, SoLuongTon = c.SoLuongTon, DonGiaBan = c.DonGiaBan };
          
            context.SACHes.Add(sach);
            context.SaveChanges();
            return true;
        }
        public bool XoaSach(int MaSach)
        {
            Context context = new Context();
            var sach = context.SACHes.Find(MaSach);
            if (sach != null)
            {
                context.SACHes.Remove(sach);
                context.SaveChanges();
            }
            return true;
        }
        public bool SuaThongTinSach(SACH c)
        {
            Context context = new Context();
            var qr = context.SACHes;
            if (qr.Any())
            {
                var sach = qr.First(o => o.MaSach == c.MaSach);
                sach.NhaXuatBan = c.NhaXuatBan;
                sach.NamXuatBan = c.NamXuatBan;
                sach.DonGiaBan = c.DonGiaBan;
                sach.SoLuongTon = c.SoLuongTon;
                context.SaveChanges();
            }
            return true;
        }
    }
}

