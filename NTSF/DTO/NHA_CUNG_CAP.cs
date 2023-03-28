namespace NTSF.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NHA_CUNG_CAP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHA_CUNG_CAP()
        {
            CT_PHIEU_NHAP = new HashSet<CT_PHIEU_NHAP>();
            CT_PHIEU_NHAP1 = new HashSet<CT_PHIEU_NHAP>();
        }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PHIEU_NHAP> CT_PHIEU_NHAP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PHIEU_NHAP> CT_PHIEU_NHAP1 { get; set; }
    }
}
