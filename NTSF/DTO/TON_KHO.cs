namespace NTSF.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TON_KHO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TON_KHO()
        {
            CT_PHIEU_NHAP = new HashSet<CT_PHIEU_NHAP>();
            CT_PHIEU_NHAP1 = new HashSet<CT_PHIEU_NHAP>();
            CT_PHIEU_XUAT_HUY = new HashSet<CT_PHIEU_XUAT_HUY>();
            CT_PHIEU_XUAT_HUY1 = new HashSet<CT_PHIEU_XUAT_HUY>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string MA_SP { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string SO_LO { get; set; }

        public int TON_DAU { get; set; }

        public int SO_LUONG_NHAP { get; set; }

        public int SO_LUONG_XUAT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PHIEU_NHAP> CT_PHIEU_NHAP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PHIEU_NHAP> CT_PHIEU_NHAP1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PHIEU_XUAT_HUY> CT_PHIEU_XUAT_HUY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PHIEU_XUAT_HUY> CT_PHIEU_XUAT_HUY1 { get; set; }

        public virtual GIA_VON GIA_VON { get; set; }

        public virtual GIA_VON GIA_VON1 { get; set; }
    }
}
