using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.SQL
{
    public class ProductRepository : IProductRepository
    {
        private readonly MarketContext _db;

        public ProductRepository(MarketContext db)
        {
            this._db = db;    
        }
        public void AddProduct(Product product)
        {
           this._db.Products.Add(product);
            this._db.SaveChanges();
        }

        public void DeleteProduct(int productId)
        {
            var product = this._db.Products.Find(productId);
            if (product != null)
            {
                this._db.Products.Remove(product);
                this._db.SaveChanges();
            }
        }

        public Product GetProductById(int productId)
        {
            return this._db.Products.Find(productId);
        }

        public IEnumerable<Product> GetProducts()
        {
            return this._db.Products.ToList();
        }

        public IEnumerable<Product> GetProductsByCategoryById(int categoryId)
        {
            return this._db.Products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void UpdateProduct(Product product)
        {
            var prod = this._db.Products.Find(product.ProductId);
            prod.CategoryId = product.CategoryId;
            prod.Name = product.Name;
            prod.Price = product.Price;
            prod.Quantity = product.Quantity;

            this._db.SaveChanges();
        }
    }
}
