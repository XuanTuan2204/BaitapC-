using ModelEF.Model;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelEF.DAO
{
    public class ProductDao
    {
        private PhamTuanContext db;

        public ProductDao()
        {
            db = new PhamTuanContext();
        }
        public string Insert(Product entitySP)
        {
            var SanPham = Find(entitySP.ProductID);
            if (SanPham == null)
            {
                db.Products.Add(entitySP);
            }
            else
            {
                SanPham.ProductID = entitySP.ProductID;
                if (!String.IsNullOrEmpty(entitySP.Name))
                {
                    SanPham.Name = entitySP.Name;
                }
            }
            db.SaveChanges();
            return entitySP.ProductID;
        }

        public Product Find(string productid)
        {
            return db.Products.Find(productid);
        }


        public bool Delete(string productid)
        {
            try
            {
                var sanpham = db.Products.Find(productid);
                db.Products.Remove(sanpham);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

       

        public List<Product> ListAll()
        {
            return db.Products.OrderBy(x=>x.Quantity).ThenByDescending(x=>x.UnitCost).ToList();
        }


        public IEnumerable<Product> ListWhereAll(string keysearch, int page, int pagesize)
        {
            IQueryable<Product> model = db.Products;
            if (!string.IsNullOrEmpty(keysearch))
            {
                model = model.Where(x => x.Name.Contains(keysearch));
            }
            return model.OrderBy(x => x.Name).ToPagedList(page, pagesize);
        }

    }
}