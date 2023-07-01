namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            HOADONs = new HashSet<HOADON>();
        }

        [Key]
        public int MaNV { get; set; }

        [Required]
        [StringLength(50)]
        public string TenNV { get; set; }

        [Required]
        [StringLength(50)]
        public string DiaChi { get; set; }

        [StringLength(15)]
        public string SDT { get; set; }

        public virtual DANGNHAP DANGNHAP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }
    }
}
