namespace NTSF.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TAI_KHOAN
    {
        [Key]
        [StringLength(50)]
        public string TEN_TK { get; set; }

        [Required]
        [StringLength(1000)]
        public string PASSWORD { get; set; }

    }
}
