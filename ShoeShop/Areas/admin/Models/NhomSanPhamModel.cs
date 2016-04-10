using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoeShop.Areas.admin.Models
{
    public class NhomSanPhamModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string MetaTitle { get; set; }
        public int? ParentID{ get; set; }
        public int? Order { get; set; }
        public string SeoTitle { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public string MetaKeyword { get; set; }
        public string Content { get; set; }
        public string Images { get; set; }
        public int? Status { get; set; }
        public string MetaDescription { get; set; }
        public bool? ShowOnHome { get; set; }
        public NhomSanPhamModel(NhomSanPham cate)
        {
            this.ID = cate.Id;
            this.Name = cate.Name;
            this.MetaTitle= cate.MetaTitle;
            this.ParentID = cate.ParentID;
            this.Order = cate.Order;
            this.SeoTitle = cate.SeoTitle;
            this.CreateDate = cate.CreateDate;
            this.CreateBy = cate.CreateBy;
            this.MetaKeyword = cate.MetaKeyword;
            this.Content = cate.Content;
            this.Images = cate.Images;
            this.Status = cate.Status;
            this.MetaDescription = cate.MetaDescription;
            this.ShowOnHome = cate.ShowOnHome;
        }
    }
   
}