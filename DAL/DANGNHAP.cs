namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DANGNHAP")]
    public partial class DANGNHAP
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaNV { get; set; }

        [StringLength(50)]
        public string Passwd { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
