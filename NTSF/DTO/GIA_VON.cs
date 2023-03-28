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
        public string MASP { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string SOLO { get; set; }

        [Column(TypeName = "money")]
        public decimal GIAVON { get; set; }

        public virtual TON_KHO TON_KHO { get; set; }
    }
}
