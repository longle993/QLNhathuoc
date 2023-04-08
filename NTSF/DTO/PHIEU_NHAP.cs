namespace NTSF.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PHIEU_NHAP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEU_NHAP()
        {
            CT_PHIEU_NHAP = new HashSet<CT_PHIEU_NHAP>();
        }

        [Key]
        [StringLength(50)]
        public string MA_PHIEU { get; set; }

        public DateTime NGAY_NHAP { get; set; }

        [Column(TypeName = "money")]
        public decimal TRI_GIA { get; set; }

        [StringLength(500)]
        public string GHI_CHU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PHIEU_NHAP> CT_PHIEU_NHAP { get; set; }
    }
}
