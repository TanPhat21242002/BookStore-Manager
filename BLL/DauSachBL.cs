using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class DauSachBL
    {
        private static DauSachBL Instance;
        public static DauSachBL GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new DauSachBL();
                }
                return Instance;
            }
        }
        private DauSachBL() { }
        Context db = new Context();
        public DataTable GetDanhSachDauSach()
        {
            return db.DataTable("SELECT MaDauSach as N'Mã đầu sách',TenDauSach as N'Tên sách',TenTacGia as N'Tên tác giả',TheLoai as N'Thể loại' from DAUSACH");
        }
        public bool ThemDauSach(DAUSACH c)
        {
            var context = new Context();
            var dausach = new DAUSACH { TenDauSach = c.TenDauSach, TenTacGia = c.TenTacGia, TheLoai = c.TheLoai };
            context.DAUSACHes.Add(dausach);
            context.SaveChanges();
            return true;
        }
        public bool XoaDauSach(int MaDauSach)
        {
            Context context = new Context();
            var dausach = context.DAUSACHes.Find(MaDauSach);
            if (dausach != null)
            {
                context.DAUSACHes.Remove(dausach);
                context.SaveChanges();
            }
            return true;
        }
        public bool SuaThongTinDauSach(DAUSACH c)
        {
            Context context = new Context();
            var qr = context.DAUSACHes;
            if (qr.Any())
            {
                var dausach = qr.First(o => o.MaDauSach == c.MaDauSach);
                dausach.TenDauSach = c.TenDauSach;
                dausach.TenTacGia = c.TenTacGia;
                dausach.TheLoai = c.TheLoai;
                context.SaveChanges();
            }
            return true;
        }
        public object getDsDauSach()
        {
            return db.DAUSACHes.Select(o => o).ToList();
        }
    }
}
