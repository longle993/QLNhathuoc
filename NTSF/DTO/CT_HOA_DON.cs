namespace NTSF.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_HOA_DON
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string MA_HD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string MA_SP { get; set; }

        [StringLength(200)]
        public string DVT { get; set; }

        public int SO_LUONG { get; set; }

        [Column(TypeName = "money")]
        public decimal CHIET_KHAU { get; set; }

        public virtual HOA_DON HOA_DON { get; set; }

        public virtual DANH_MUC_SP DANH_MUC_SP { get; set; }
    }
}
