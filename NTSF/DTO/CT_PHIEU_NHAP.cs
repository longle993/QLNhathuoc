namespace NTSF.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_PHIEU_NHAP
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string MA_PHIEU { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string MA_SP { get; set; }

        [Required]
        [StringLength(50)]
        public string MA_NCC { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string SO_LO { get; set; }

        [Column(TypeName = "date")]
        public DateTime HSD { get; set; }

        [Required]
        [StringLength(200)]
        public string DON_VI_NHAP { get; set; }

        public short QUY_DOI { get; set; }

        public int SOLUONG { get; set; }

        [Column(TypeName = "money")]
        public decimal DON_GIA { get; set; }

        [Column(TypeName = "money")]
        public decimal CHIET_KHAU { get; set; }

        public byte VAT_NHAP { get; set; }

        public virtual NHA_CUNG_CAP NHA_CUNG_CAP { get; set; }

        public virtual NHA_CUNG_CAP NHA_CUNG_CAP1 { get; set; }

        public virtual PHIEU_NHAP PHIEU_NHAP { get; set; }

        public virtual PHIEU_NHAP PHIEU_NHAP1 { get; set; }

        public virtual TON_KHO TON_KHO { get; set; }

        public virtual TON_KHO TON_KHO1 { get; set; }
    }
}
