namespace NTSF.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GIA_VON
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string MA_SP { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string SO_LO { get; set; }

        [Column(TypeName = "money")]
        public decimal GIAVON { get; set; }

        public virtual HANG_HOA HANG_HOA { get; set; }
    }
}
