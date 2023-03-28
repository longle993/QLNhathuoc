namespace NTSF.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HOA_DON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOA_DON()
        {
            CT_HOA_DON = new HashSet<CT_HOA_DON>();
        }

        [Key]
        [StringLength(50)]
        public string MA_HD { get; set; }

        [Column(TypeName = "date")]
        public DateTime NGAY_HD { get; set; }

        [Required]
        [StringLength(50)]
        public string MA_NV { get; set; }

        [Required]
        [StringLength(50)]
        public string TEN_KH { get; set; }

        [Required]
        [StringLength(50)]
        public string MA_PTTT { get; set; }

        [Column(TypeName = "money")]
        public decimal TRI_GIA { get; set; }

        [StringLength(500)]
        public string GHI_CHU { get; set; }

        public TimeSpan GIO_BAN_HANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_HOA_DON> CT_HOA_DON { get; set; }

        public virtual PTTT PTTT { get; set; }
    }
}
