namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_TACGIA
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaDauSach { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string TenTacGia { get; set; }

        public virtual DAUSACH DAUSACH { get; set; }
    }
}
