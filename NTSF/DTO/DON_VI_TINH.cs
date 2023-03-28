namespace NTSF.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DON_VI_TINH
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string MA_SP { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(200)]
        public string DVT_KHAC { get; set; }

        public short QUY_DOI { get; set; }

        [Column(TypeName = "money")]
        public decimal GIA_BAN { get; set; }

        public virtual DANH_MUC_SP DANH_MUC_SP { get; set; }

        public virtual DANH_MUC_SP DANH_MUC_SP1 { get; set; }
    }
}
