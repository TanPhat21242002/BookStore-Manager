namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DAUSACH")]
    public partial class DAUSACH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DAUSACH()
        {
            CT_TACGIA = new HashSet<CT_TACGIA>();
            SACHes = new HashSet<SACH>();
        }

        [Key]
        public int MaDauSach { get; set; }

        [Required]
        [StringLength(50)]
        public string TenDauSach { get; set; }

        [StringLength(50)]
        public string TenTacGia { get; set; }

        [Required]
        [StringLength(80)]
        public string TheLoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_TACGIA> CT_TACGIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SACH> SACHes { get; set; }
    }
}
