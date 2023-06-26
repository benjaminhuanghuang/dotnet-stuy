using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class ProductInMemoryRepository : IProductRepository
    {
        private List<Product> _products;

        public ProductInMemoryRepository()
        {
            _products = new List<Product>()
            {
                new Product { ProductId = 1, CategoryId = 1, Name="Iced Tea", Quantity = 100, Price = 1.99},
                new Product { ProductId = 2, CategoryId = 1, Name="Iced Tea1", Quantity = 100, Price = 1.99},
                new Product { ProductId = 3, CategoryId = 2, Name="addccccc1", Quantity= 100, Price = 1.99},
                new Product { ProductId = 4, CategoryId = 2, Name="addccccc2", Quantity= 100, Price = 1.99},
            };
        }

        public IEnumerable<Product> GetProducts()
        {
            return _products;
        }
        public void AddProduct(Product product)
        {
            if (_products.Any(x => x.Name.Equals(product.Name, StringComparison.OrdinalIgnoreCase))) return;
            if (_products != null && _products.Count > 0)
            {
                var maxId = _products.Max(x => x.ProductId);
                product.ProductId = maxId + 1;
            }
            else
            {
                product.ProductId = 1;
            }
            _products.Add(product);
        }
    }
}
