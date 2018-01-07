namespace Web_Ban_Hoa.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBContext : DbContext
    {
        public DBContext()
            : base("name=DBContext")
        {
        }

        public virtual DbSet<Acc> Accs { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CTDatHang> CTDatHangs { get; set; }
        public virtual DbSet<DatHang> DatHangs { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Acc>()
                .Property(e => e.User)
                .IsFixedLength();

            modelBuilder.Entity<Acc>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<Acc>()
                .Property(e => e.MatKhau)
                .IsFixedLength();

            modelBuilder.Entity<Acc>()
                .Property(e => e.PhanQuyen)
                .IsFixedLength();

            modelBuilder.Entity<Category>()
                .Property(e => e.ImageCategory)
                .IsFixedLength();

            modelBuilder.Entity<Category>()
                .HasMany(e => e.SanPhams)
                .WithOptional(e => e.Category)
                .WillCascadeOnDelete();

            modelBuilder.Entity<DatHang>()
                .Property(e => e.User)
                .IsFixedLength();

            modelBuilder.Entity<SanPham>()
                .Property(e => e.Image)
                .IsFixedLength();
        }
    }
}
