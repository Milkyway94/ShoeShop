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
                var res = db.NhomSanPhams.Find(id);
                db.NhomSanPhams.Remove(res);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }
        public IEnumerable<NhomSanPham> ListAll(int page, int pageSize)
        {
            return db.NhomSanPhams.OrderByDescending(o=>o.CreateDate).ToPagedList(page,pageSize);
        }
    }
}