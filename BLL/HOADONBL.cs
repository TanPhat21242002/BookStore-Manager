using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace BLL
{
    public class HOADONBL
    {
        private static HOADONBL Instance;
        public static HOADONBL GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new HOADONBL();
                }
                return Instance;
            }
        }
        private HOADONBL() { }
        Context db = new Context();
        private int sohd;
        public void ThemHoaDon(HOADON hdDTO)
        {
            var context = new Context();
            var hoadon = new HOADON
            {
                NgHD = hdDTO.NgHD,
                MaKH = hdDTO.MaKH,
                MaNV = hdDTO.MaNV,
            };
            context.HOADONs.Add(hoadon);
            context.SaveChanges();
        }
        public int GetSOHDMax()
        {
            Context db = new Context();
            var qr = from p in db.HOADONs
                     orderby p.SoHD descending
                     select p.SoHD;
            foreach (var n in qr.Take(1))
            {
                sohd = n;
            }
            return sohd;
        }
        public bool ThemCTHD(DataTable dt, int SOHD, decimal THANHTIEN,string sotientra, string conlai)
        {
            //Thêm chi tiết hóa đơn
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var context = new Context();
                var savedHoaDon = context.HOADONs;
                if (savedHoaDon.Any())
                {
                    var hd = savedHoaDon.First(o=>o.SoHD==SOHD);
                    hd.MaSach = int.Parse(dt.Rows[i][0].ToString());
                    hd.SoLuong = int.Parse(dt.Rows[i][3].ToString());
                    hd.TongTien = (int?)THANHTIEN;
                    hd.SoTienTra = sotientra;
                    hd.ConLai = conlai; 

                    context.SaveChanges();
                }
            }
            return true;
        }
        public DataTable GetDanhSachHoaDon()
        {
            return db.DataTable("SELECT MaSach as N'Mã sách',SoLuong as N'Số lượng',TongTien as N'Tổng tiền',SoTienTra as N'Số tiền khách trả', ConLai as N'Tiền thừa' from HOADON");
        }
    }
}
