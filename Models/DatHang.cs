namespace Web_Ban_Hoa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DatHang")]
    public partial class DatHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DatHang()
        {
            CTDatHangs = new HashSet<CTDatHang>();
        }

        [Key]
        [StringLength(100)]
        public string MaDH { get; set; }

        [Required]
        [StringLength(50)]
        public string User { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayDatHang { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayGiaoHang { get; set; }

        [Required]
        [StringLength(500)]
        public string DiaChi { get; set; }

        [StringLength(1000)]
        public string GhiChu { get; set; }

        public int TongTien { get; set; }

        public virtual Acc Acc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTDatHang> CTDatHangs { get; set; }
    }
}
