namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhomSanPham")]
    public partial class NhomSanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhomSanPham()
        {
            SanPhams = new HashSet<SanPham>();
        }

        public int Id { get; set; }

        [StringLength(500)]
        [Required]
        [Display(Name="Tên danh mục")]
        public string Name { get; set; }

        [StringLength(250)]
        public string MetaTitle { get; set; }
        [Display(Name = "Danh mục cha")]
        public int? ParentID { get; set; }
        [Display(Name = "Thứ tự")]
        public int? Order { get; set; }
        [Display(Name = "Tiêu đề SEO")]
        [StringLength(250)]
        public string SeoTitle { get; set; }
        [Display(Name = "Ngày tạo")]
        [Column(TypeName = "date")]
        public DateTime? CreateDate { get; set; }
        [Display(Name = "Người tạo")]
        [StringLength(50)]
        public string CreateBy { get; set; }
        [Display(Name = "Từ khóa tìm kiếm")]
        [StringLength(250)]
        public string MetaKeyword { get; set; }
        [Display(Name = "Nội dung")]
        [Column(TypeName = "ntext")]
        public string Content { get; set; }
        [Display(Name = "Ảnh")]
        [StringLength(500)]
        public string Images { get; set; }
        [Display(Name = "Trạng thái")]
        public int? Status { get; set; }
        [Display(Name = "Mô tả Meta")]
        [StringLength(250)]
        public string MetaDescription { get; set; }
        [Display(Name = "Hiện lên trang chủ")]
        public bool ShowOnHome { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
