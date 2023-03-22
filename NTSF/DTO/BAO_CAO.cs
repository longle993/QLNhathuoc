namespace NTSF.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BAO_CAO
    {
        [Key]
        [Column(TypeName = "date")]
        public DateTime THOI_GIAN { get; set; }

        [Column(TypeName = "money")]
        public decimal? DOANH_THU { get; set; }

        [Column(TypeName = "money")]
        public decimal? TIEN_VON { get; set; }

        [Column(TypeName = "money")]
        public decimal? LOI_NHUAN { get; set; }
    }
}
