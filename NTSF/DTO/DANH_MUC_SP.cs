namespace NTSF.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DANH_MUC_SP
    {
        [Key]
        [StringLength(50)]
        public string MA_SP { get; set; }

        [StringLength(50)]
        public string TEN_SP { get; set; }

        [StringLength(50)]
        public string NHOM_SP { get; set; }

        [StringLength(50)]
        public string HAM_LUONG { get; set; }

        [StringLength(500)]
        public string QUY_CACH_DONG_GOI { get; set; }

        [StringLength(500)]
        public string MO_TA { get; set; }

        [StringLength(200)]
        public string DVT_CO_BAN { get; set; }

        public byte VAT_BAN { get; set; }

        [Column(TypeName = "money")]
        public decimal GIA_BAN { get; set; }

        public int TONG_TON { get; set; }
    }
}
