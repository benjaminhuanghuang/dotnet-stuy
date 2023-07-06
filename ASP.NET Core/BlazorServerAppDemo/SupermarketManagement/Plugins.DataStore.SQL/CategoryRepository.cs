using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.SQL
{
    public class CategoryRepository: ICategoryRepository
    {
        private readonly MarketContext _db;
        public CategoryRepository(MarketContext db)
        {

            this._db = db;

        }

        public void AddCategory(Category category)
        {
            _db.Categories.Add(category);
            _db.SaveChanges();
        }

        public void DeleteCategory(int categoryId)
        {
            var category = _db.Categories.Find(categoryId);
            if (category != null)
            {
                _db.Categories.Remove(category);
                _db.SaveChanges();
            }
        }

        public IEnumerable<Category> GetCategoreis()
        {
           return _db.Categories.ToList();
        }

        public Category GetCategoryById(int categoryId)
        {
            return this._db.Categories.Find(categoryId);
        }

        public void UpdateCategory(Category category)
        {
           var cat = _db.Categories.Find(category.CategoryId);
            if (cat != null)
            {
                cat.Name = category.Name;
                cat.Description = category.Description;
                _db.SaveChanges();
            }   
        }
    }
}
