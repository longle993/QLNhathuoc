namespace NTSF.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NHAN_VIEN
    {
        [Key]
        [StringLength(50)]
        public string MA_NV { get; set; }

        [StringLength(50)]
        public string SDT { get; set; }

        [Required]
        [StringLength(500)]
        public string TEN_NV { get; set; }
    }
}
