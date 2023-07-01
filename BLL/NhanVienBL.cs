using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class NhanVienBL
    {
        private static NhanVienBL Instance;
        public static NhanVienBL GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new NhanVienBL();
                }
                return Instance;
            }
        }
        private NhanVienBL() { }
        Context db = new Context();
        public DataTable GetDanhSachNhanVienTimKiem(string tennv)
        {
            return db.DataTable("SELECT MaNV as N'Mã NV',TenNV as N'Tên NV',DiaChi as N'Địa Chỉ',SDT as N'SĐT' FROM NHANVIEN WHERE MaNV != 1 AND TenNV LIKE N'%" + tennv + "%' ");
        }
        public DataTable GetDanhSachNhanVien()
        {
            return db.DataTable("SELECT MaNV as N'Mã NV',TenNV as N'Tên NV',DiaChi as N'Địa Chỉ',SDT as N'SĐT' from NHANVIEN");
        }
        public bool ThemNhanVien(NHANVIEN c)
        {
            var context = new Context();
            var nhanvien = new NHANVIEN { TenNV = c.TenNV, DiaChi = c.DiaChi, SDT = c.SDT };
            context.NHANVIENs.Add(nhanvien);
            context.SaveChanges();
            return true;
        }
        public bool XoaNhanVien(int MaNV)
        {
            Context context = new Context();
            var nhanvien = context.NHANVIENs.Find(MaNV);
            if (nhanvien != null)
            {
                context.NHANVIENs.Remove(nhanvien);
                context.SaveChanges();
            }
            return true;
        }
        public bool SuaThongTinNhanVien(NHANVIEN c)
        {
            Context context = new Context();
            var qr = context.NHANVIENs;
            if (qr.Any())
            {
                var nhanvien = qr.First(o => o.MaNV == c.MaNV);
                nhanvien.TenNV = c.TenNV;
                nhanvien.SDT = c.SDT;
                nhanvien.DiaChi = c.DiaChi;
                context.SaveChanges();
            }
            return true;
        }
    }
}
