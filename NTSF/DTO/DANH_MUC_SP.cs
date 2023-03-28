namespace NTSF.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DANH_MUC_SP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DANH_MUC_SP()
        {
            CT_HOA_DON = new HashSet<CT_HOA_DON>();
            CT_HOA_DON1 = new HashSet<CT_HOA_DON>();
            CT_PHIEU_XUAT_HUY = new HashSet<CT_PHIEU_XUAT_HUY>();
            CT_PHIEU_XUAT_HUY1 = new HashSet<CT_PHIEU_XUAT_HUY>();
            DON_VI_TINH = new HashSet<DON_VI_TINH>();
            DON_VI_TINH1 = new HashSet<DON_VI_TINH>();
        }

        [Key]
        [StringLength(50)]
        public string MA_SP { get; set; }

        [StringLength(50)]
        public string TEN_SP { get; set; }

        [StringLength(50)]
        public string NHOM_SP { get; set; }

        [StringLength(50)]
        public string HAM_LUONG { get; set; }

        [StringLength(500)]
        public string QUY_CACH_DONG_GOI { get; set; }

        [StringLength(500)]
        public string MO_TA { get; set; }

        [StringLength(200)]
        public string DVT_CO_BAN { get; set; }

        public byte VAT_BAN { get; set; }

        [Column(TypeName = "money")]
        public decimal GIA_BAN { get; set; }

        public int TONG_TON { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_HOA_DON> CT_HOA_DON { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_HOA_DON> CT_HOA_DON1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PHIEU_XUAT_HUY> CT_PHIEU_XUAT_HUY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PHIEU_XUAT_HUY> CT_PHIEU_XUAT_HUY1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DON_VI_TINH> DON_VI_TINH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DON_VI_TINH> DON_VI_TINH1 { get; set; }
    }
}
