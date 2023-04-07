namespace NTSF.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NHA_CUNG_CAP
    {
        [Key]
        [StringLength(50)]
        public string MA_NCC { get; set; }

        [Required]
        [StringLength(500)]
        public string TEN_NCC { get; set; }

        [Required]
        [StringLength(50)]
        public string MA_SO_THUE { get; set; }

        [StringLength(50)]
        public string SDT { get; set; }

        [StringLength(500)]
        public string GHI_CHU { get; set; }
    }
}
