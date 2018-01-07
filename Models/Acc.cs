namespace Web_Ban_Hoa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Acc")]
    public partial class Acc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Acc()
        {
            DatHangs = new HashSet<DatHang>();
        }

        [Key]
        [StringLength(50)]
        public string User { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int SDT { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(20)]
        public string MatKhau { get; set; }

        [StringLength(50)]
        public string PhanQuyen { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatHang> DatHangs { get; set; }
    }
}
