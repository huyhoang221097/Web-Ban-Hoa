namespace Web_Ban_Hoa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTDatHang")]
    public partial class CTDatHang
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string MaDH { get; set; }

        public int MaSP { get; set; }

        public int SL { get; set; }

        public int Gia { get; set; }

        public double GiamGia { get; set; }

        public virtual DatHang DatHang { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
