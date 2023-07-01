using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class KhachHangBL
    {
        private static KhachHangBL Instance;
        public static KhachHangBL GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new KhachHangBL();
                }
                return Instance;
            }
        }
        private KhachHangBL() { }
        Context db = new Context();
        public DataTable GetDanhSachKhachHang()
        {
            return db.DataTable("SELECT MaKH as N'Mã KH',TenKH as N'Tên KH',DiaChi as N'Địa Chỉ',Email ,SDT as N'SĐT' from KHACHHANG");
        }
        public bool ThemKhachHang(KHACHHANG c)
        {
            var context = new Context();
            var khachhang = new KHACHHANG { TenKH = c.TenKH, DiaChi = c.DiaChi, SDT = c.SDT, Email = c.Email };
            context.KHACHHANGs.Add(khachhang);
            context.SaveChanges();
            return true;
        }
        public bool XoaKhachHang(int MAKH)
        {
            Context context = new Context();
            var khachhang = context.KHACHHANGs.Find(MAKH);
            if (khachhang != null)
            {
                context.KHACHHANGs.Remove(khachhang);
                context.SaveChanges();
            }
            return true;
        }
        public bool SuaThongTinKhachHang(KHACHHANG c)
        {
            Context context = new Context();
            var qr = context.KHACHHANGs;
            if (qr.Any())
            {
                var khachhang = qr.First(o => o.MaKH == c.MaKH);
                khachhang.TenKH = c.TenKH;
                khachhang.SDT = c.SDT;
                khachhang.DiaChi = c.DiaChi;
                khachhang.Email = c.Email;
                context.SaveChanges();
            }
            return true;
        }
    }
  

}
