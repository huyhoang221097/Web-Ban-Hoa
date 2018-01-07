namespace Web_Ban_Hoa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            CTDatHangs = new HashSet<CTDatHang>();
        }

        [Key]
        public int MaSP { get; set; }

        [Required]
        [StringLength(250)]
        public string TenSP { get; set; }

        public int Gia { get; set; }

        public double GiamGia { get; set; }

        public int SL { get; set; }

        [Required]
        [StringLength(200)]
        public string Image { get; set; }

        [Required]
        [StringLength(50)]
        public string TrangThai { get; set; }

        [Required]
        [StringLength(2000)]
        public string MoTa { get; set; }

        public int? IdCategory { get; set; }

        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTDatHang> CTDatHangs { get; set; }
    }
}
