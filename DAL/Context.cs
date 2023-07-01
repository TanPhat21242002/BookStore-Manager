using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL
{
    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<CT_TACGIA> CT_TACGIA { get; set; }
        public virtual DbSet<DANGNHAP> DANGNHAPs { get; set; }
        public virtual DbSet<DAUSACH> DAUSACHes { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<SACH> SACHes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DAUSACH>()
                .HasMany(e => e.CT_TACGIA)
                .WithRequired(e => e.DAUSACH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DAUSACH>()
                .HasMany(e => e.SACHes)
                .WithRequired(e => e.DAUSACH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.HOADONs)
                .WithRequired(e => e.KHACHHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasOptional(e => e.DANGNHAP)
                .WithRequired(e => e.NHANVIEN);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.HOADONs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);
        }
    }
}
