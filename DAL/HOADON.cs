namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADON")]
    public partial class HOADON
    {
        [Key]
        public int SoHD { get; set; }

        public int? MaSach { get; set; }

        public int? SoLuong { get; set; }

        public int MaNV { get; set; }

        public int MaKH { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgHD { get; set; }

        public int? TongTien { get; set; }

        [StringLength(50)]
        public string SoTienTra { get; set; }
        [StringLength(50)]
        public string ConLai { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual SACH SACH { get; set; }
    }
}
