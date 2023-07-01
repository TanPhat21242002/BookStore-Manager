using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DAL;
using System.Data;
namespace BLL
{
    public class AddData
    {
        private static AddData Instance;
        public static AddData GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new AddData();
                }
                return Instance;
            }
        }
        private AddData() { }
        public void themdulieu()
        {
            VerifyDatabaseExists();
            InsertDataNhanVien();
            InsertDataKhachHang();
            InsertDataDauSach();
            InsertDataSach();
        }

        private static void VerifyDatabaseExists()
        {
            using (var context = new Context())
            {
                context.Database.CreateIfNotExists();
            }
        }
        static void InsertDataNhanVien()
        {
            using (var context = new Context())
            {
                var nhanvien1 = new NHANVIEN { TenNV = "Võ Trường Vỹ", SDT = "0367151727", DiaChi = "QN" };
                var nhanvien2 = new NHANVIEN { TenNV = "Nguyễn Tấn Phát", SDT = "0367151729", DiaChi = "QN" };
                var nhanvien3 = new NHANVIEN { TenNV = "Cao Hoàng Anh", SDT = "0367151728", DiaChi = "Dăk Nông" };
                context.NHANVIENs.Add(nhanvien1);
                context.NHANVIENs.Add(nhanvien2);
                context.NHANVIENs.Add(nhanvien3);
                context.SaveChanges();
            }
        }
        static void InsertDataKhachHang()
        {
            using (var context = new Context())
            {
                var khachhang1 = new KHACHHANG { TenKH = "Nguyễn Hoàng Thiên Bảo", DiaChi = "TP.HCM", SDT = "03545345345", Email = "NHTB@gmail.com" };
                var khachhang2 = new KHACHHANG { TenKH = "Nguyễn Thị Kiều Diễm", DiaChi = "Quảng Ngãi", SDT = "0999112911", Email = "NTKD@gmail.com" };
                var khachhang3 = new KHACHHANG { TenKH = "Phan Hoàng Khải", DiaChi = "Đồng Nai", SDT = "0999112912", Email = "PHK@gmail.com" };
                var khachhang4 = new KHACHHANG { TenKH = "Nguyễn Hồng Sơn", DiaChi = "Đồng Nai", SDT = "0999112913", Email = "NHS@gmail.com" };
                context.KHACHHANGs.Add(khachhang1);
                context.KHACHHANGs.Add(khachhang2);
                context.KHACHHANGs.Add(khachhang3);
                context.KHACHHANGs.Add(khachhang4);
                context.SaveChanges();
            }
        }
        static void InsertDataDauSach()
        {
            using (var context = new Context())
            {
                var loaisanpham1 = new DAUSACH { TenDauSach = "Trinh Thám", TenTacGia = "Conan Doyle", TheLoai = "Trinh Thám" };
                var loaisanpham2 = new DAUSACH { TenDauSach = "Học đường ", TenTacGia = "Ái Giang", TheLoai = "Lãng mạn" };
                var loaisanpham3 = new DAUSACH { TenDauSach = "Thiếu nhi", TenTacGia = "Nguyễn Nhật Ánh", TheLoai = "Drama" };
                var loaisanpham4 = new DAUSACH { TenDauSach = "Học đường", TenTacGia = "Thanh Thiên", TheLoai = "Hài" };
                context.DAUSACHes.Add(loaisanpham1);
                context.DAUSACHes.Add(loaisanpham2);
                context.DAUSACHes.Add(loaisanpham3);
                context.DAUSACHes.Add(loaisanpham4);
                context.SaveChanges();
            }
        }
        static void InsertDataSach()
        {
            using (var context = new Context())
            {
                var loaisanpham1 = new SACH {MaDauSach=4 ,TenSach = "Tôi yêu em", NhaXuatBan = "Kim Đồng", NamXuatBan = 2014, SoLuongTon = 10, DonGiaBan = 100000 };
                var loaisanpham2 = new SACH {MaDauSach=2 ,TenSach = "Em là ai", NhaXuatBan = "Tiên phong", NamXuatBan = 2022, SoLuongTon = 20, DonGiaBan = 300000 };
                var loaisanpham3 = new SACH {MaDauSach=1 ,TenSach = "Vụ án trong toilet", NhaXuatBan = "Tiên phong", NamXuatBan = 2015, SoLuongTon = 5, DonGiaBan = 200000 };
                var loaisanpham4 = new SACH {MaDauSach=3 ,TenSach = "Mai ăn món gì ?", NhaXuatBan = "Tuổi trẻ", NamXuatBan = 2018, SoLuongTon = 15, DonGiaBan = 150000 };
                context.SACHes.Add(loaisanpham1);
                context.SACHes.Add(loaisanpham2);
                context.SACHes.Add(loaisanpham3);
                context.SACHes.Add(loaisanpham4);
                context.SaveChanges();
            }
        }
    }
}