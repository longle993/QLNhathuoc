namespace NTSF.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PHIEU_XUAT_HUY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEU_XUAT_HUY()
        {
            CT_PHIEU_XUAT_HUY = new HashSet<CT_PHIEU_XUAT_HUY>();
            CT_PHIEU_XUAT_HUY1 = new HashSet<CT_PHIEU_XUAT_HUY>();
        }

        [Key]
        [StringLength(50)]
        public string MA_PHIEU { get; set; }

        [Column(TypeName = "date")]
        public DateTime NGAY_XUAT { get; set; }

        public TimeSpan GIO_XUAT { get; set; }

        [Column(TypeName = "money")]
        public decimal TRI_GIA { get; set; }

        [StringLength(500)]
        public string GHI_CHU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PHIEU_XUAT_HUY> CT_PHIEU_XUAT_HUY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PHIEU_XUAT_HUY> CT_PHIEU_XUAT_HUY1 { get; set; }
    }
}
