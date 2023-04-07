namespace NTSF.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PTTT")]
    public partial class PTTT
    {
        [Key]
        [StringLength(50)]
        public string MA_PTTT { get; set; }

        [StringLength(500)]
        public string TEN_PTTT { get; set; }
    }
}
