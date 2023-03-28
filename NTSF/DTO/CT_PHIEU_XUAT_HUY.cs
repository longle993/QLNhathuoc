namespace NTSF.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_PHIEU_XUAT_HUY
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string MA_PHIEU { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string MA_SP { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string SO_LO { get; set; }

        [Required]
        [StringLength(200)]
        public string DVT { get; set; }

        public int SO_LUONG { get; set; }

        [Required]
        [StringLength(500)]
        public string LY_DO { get; set; }

        public virtual PHIEU_XUAT_HUY PHIEU_XUAT_HUY { get; set; }

        public virtual DANH_MUC_SP DANH_MUC_SP { get; set; }

        public virtual TON_KHO TON_KHO { get; set; }
    }
}
