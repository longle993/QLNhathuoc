using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace NTSF.DTO
{
    public partial class NhaThuoc : DbContext
    {
        public NhaThuoc()
            : base("name=NhaThuoc")
        {
        }

        public virtual DbSet<CT_HOA_DON> CT_HOA_DON { get; set; }
        public virtual DbSet<CT_PHIEU_NHAP> CT_PHIEU_NHAP { get; set; }
        public virtual DbSet<CT_PHIEU_XUAT_HUY> CT_PHIEU_XUAT_HUY { get; set; }
        public virtual DbSet<DANH_MUC_SP> DANH_MUC_SP { get; set; }
        public virtual DbSet<DON_VI_TINH> DON_VI_TINH { get; set; }
        public virtual DbSet<GIA_VON> GIA_VON { get; set; }
        public virtual DbSet<HOA_DON> HOA_DON { get; set; }
        public virtual DbSet<KHACH_HANG> KHACH_HANG { get; set; }
        public virtual DbSet<NHA_CUNG_CAP> NHA_CUNG_CAP { get; set; }
        public virtual DbSet<NHAN_VIEN> NHAN_VIEN { get; set; }
        public virtual DbSet<PHIEU_NHAP> PHIEU_NHAP { get; set; }
        public virtual DbSet<PHIEU_XUAT_HUY> PHIEU_XUAT_HUY { get; set; }
        public virtual DbSet<PTTT> PTTTs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CT_HOA_DON>()
                .Property(e => e.MA_HD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_HOA_DON>()
                .Property(e => e.MA_SP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_HOA_DON>()
                .Property(e => e.CHIET_KHAU)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CT_PHIEU_NHAP>()
                .Property(e => e.MA_PHIEU)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_PHIEU_NHAP>()
                .Property(e => e.MA_SP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_PHIEU_NHAP>()
                .Property(e => e.MA_NCC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_PHIEU_NHAP>()
                .Property(e => e.SO_LO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_PHIEU_NHAP>()
                .Property(e => e.DON_GIA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CT_PHIEU_NHAP>()
                .Property(e => e.CHIET_KHAU)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CT_PHIEU_XUAT_HUY>()
                .Property(e => e.MA_PHIEU)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_PHIEU_XUAT_HUY>()
                .Property(e => e.MA_SP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_PHIEU_XUAT_HUY>()
                .Property(e => e.SO_LO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DANH_MUC_SP>()
                .Property(e => e.MA_SP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DANH_MUC_SP>()
                .Property(e => e.NHOM_SP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DANH_MUC_SP>()
                .Property(e => e.HAM_LUONG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DANH_MUC_SP>()
                .Property(e => e.GIA_BAN)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DON_VI_TINH>()
                .Property(e => e.MA_SP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DON_VI_TINH>()
                .Property(e => e.GIA_BAN)
                .HasPrecision(19, 4);

            modelBuilder.Entity<GIA_VON>()
                .Property(e => e.MASP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GIA_VON>()
                .Property(e => e.SOLO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GIA_VON>()
                .Property(e => e.GIAVON)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HOA_DON>()
                .Property(e => e.MA_HD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOA_DON>()
                .Property(e => e.MA_NV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOA_DON>()
                .Property(e => e.MA_PTTT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOA_DON>()
                .Property(e => e.TRI_GIA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HOA_DON>()
                .HasMany(e => e.CT_HOA_DON)
                .WithRequired(e => e.HOA_DON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACH_HANG>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHA_CUNG_CAP>()
                .Property(e => e.MA_NCC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHA_CUNG_CAP>()
                .Property(e => e.MA_SO_THUE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHA_CUNG_CAP>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHAN_VIEN>()
                .Property(e => e.MA_NV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHAN_VIEN>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEU_NHAP>()
                .Property(e => e.MA_PHIEU)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEU_NHAP>()
                .Property(e => e.GIO_NHAP)
                .HasPrecision(0);

            modelBuilder.Entity<PHIEU_NHAP>()
                .Property(e => e.TRI_GIA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PHIEU_NHAP>()
                .HasMany(e => e.CT_PHIEU_NHAP)
                .WithRequired(e => e.PHIEU_NHAP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEU_XUAT_HUY>()
                .Property(e => e.MA_PHIEU)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEU_XUAT_HUY>()
                .Property(e => e.GIO_XUAT)
                .HasPrecision(0);

            modelBuilder.Entity<PHIEU_XUAT_HUY>()
                .Property(e => e.TRI_GIA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PHIEU_XUAT_HUY>()
                .HasMany(e => e.CT_PHIEU_XUAT_HUY)
                .WithRequired(e => e.PHIEU_XUAT_HUY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PTTT>()
                .Property(e => e.MA_PTTT)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
