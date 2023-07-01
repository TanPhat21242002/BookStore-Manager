namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SACH")]
    public partial class SACH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SACH()
        {
            HOADONs = new HashSet<HOADON>();
        }

        [Key]
        public int MaSach { get; set; }

        [StringLength(50)]
        public string TenSach { get; set; }

        public int MaDauSach { get; set; }

        [Required]
        [StringLength(50)]
        public string NhaXuatBan { get; set; }

        public int NamXuatBan { get; set; }

        public int SoLuongTon { get; set; }

        public int DonGiaBan { get; set; }

        public virtual DAUSACH DAUSACH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }
    }
}
