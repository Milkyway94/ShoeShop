using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;
namespace Models.Dao
{
    public class NhomsanphamDao
    {
        private ShoeShopDbContext db = null;
        public NhomsanphamDao()
        {
            db = new ShoeShopDbContext();
        }
        public int Insert(NhomSanPham entity)
        {
            db.NhomSanPhams.Add(entity);
            db.SaveChanges();
            return entity.Id;
        }
        
        public bool Delete(int id)
        {
            try
            {
                var res = db.NhomSanPhams.Where(o => o.Id == id);
                if (res.Count() > 0)
                {
                    NhomSanPham cate = res.SingleOrDefault();
                    db.NhomSanPhams.Remove(cate);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            catch (Exception)
            {

                return false;
            }
            
        }
        public bool Update(NhomSanPham entity)
        {
            try
            {
                var cate = db.NhomSanPhams.Find(entity.Id);
                cate.Name = entity.Name;
                cate.MetaTitle = entity.MetaTitle;
                cate.Order = entity.Order;
                cate.ParentID = entity.ParentID;
                cate.ShowOnHome = entity.ShowOnHome;
                cate.Status = entity.Status;
                cate.SeoTitle = entity.SeoTitle;
                cate.MetaKeyword = entity.MetaKeyword;
                cate.Images = entity.Images;
                cate.MetaDescription = entity.MetaDescription;
                cate.CreateBy = entity.CreateBy;
                cate.CreateDate = DateTime.Now;
                cate.Content = entity.Content;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }
        public NhomSanPham ViewDetail(int id)
        {
            return db.NhomSanPhams.Find(id);
        }
        public IEnumerable<NhomSanPham> SearchResult(string searchKey, int page, int pageSize)
        {
            var catecol = db.NhomSanPhams.Where(o => o.Name.Contains(searchKey) || o.Id.ToString() == searchKey); 
            return catecol.OrderByDescending(o=>o.CreateDate).ToPagedList(page,pageSize);
        }
        public IEnumerable<NhomSanPham> ListAll(int page, int pageSize)
        {
            return db.NhomSanPhams.OrderByDescending(o => o.CreateDate).ToPagedList(page, pageSize);
        }
        public IEnumerable<NhomSanPham> ListAll()
        {
            return db.NhomSanPhams;
        }
        public NhomSanPham SelectCateById(int id)
        {
            return db.NhomSanPhams.Find(id);
        }
    }
}