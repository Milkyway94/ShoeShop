namespace Models.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ShoeShopDbContext : DbContext
    {
        public ShoeShopDbContext()
            : base("name=ShoeShopDbContext1")
        {
        }

        public virtual DbSet<ChiTietDatHang> ChiTietDatHangs { get; set; }
        public virtual DbSet<Content> Contents { get; set; }
        public virtual DbSet<DatHang> DatHangs { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Footer> Footers { get; set; }
        public virtual DbSet<HoTro> HoTroes { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LienHe> LienHes { get; set; }
        public virtual DbSet<LogoBanner> LogoBanners { get; set; }
        public virtual DbSet<Mau_layout> Mau_layout { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<MenuType> MenuTypes { get; set; }
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }
        public virtual DbSet<NhomSanPham> NhomSanPhams { get; set; }
        public virtual DbSet<Page> Pages { get; set; }
        public virtual DbSet<QuangCao> QuangCaos { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<Slider> Sliders { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<SystemConfig> SystemConfigs { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<ThanhPho> ThanhPhoes { get; set; }
        public virtual DbSet<About> Abouts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Content>()
                .HasMany(e => e.Tags)
                .WithMany(e => e.Contents)
                .Map(m => m.ToTable("ContentTag").MapLeftKey("ContentID").MapRightKey("TagID"));

            modelBuilder.Entity<DatHang>()
                .HasMany(e => e.ChiTietDatHangs)
                .WithOptional(e => e.DatHang)
                .HasForeignKey(e => e.Dathang_ID);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.DatHangs)
                .WithOptional(e => e.KhachHang)
                .HasForeignKey(e => e.Khachhang_ID);

            modelBuilder.Entity<Mau_layout>()
                .Property(e => e.Mamau)
                .IsUnicode(false);

            modelBuilder.Entity<NhomSanPham>()
                .HasMany(e => e.Contents)
                .WithOptional(e => e.NhomSanPham)
                .HasForeignKey(e => e.NhomSP_ID);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.PromotionPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.ChiTietDatHangs)
                .WithOptional(e => e.SanPham)
                .HasForeignKey(e => e.Sanpham_ID);

            modelBuilder.Entity<SystemConfig>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Tag>()
                .Property(e => e.ID)
                .IsUnicode(false);
        }
    }
}
