using CoreBusiness;
using System.Xml.Linq;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
	public class CategoryInMemoryRepository : ICategoryRepository
	{
		private readonly List<Category> _categories;
		public CategoryInMemoryRepository()
		{
			// add some default categories
			this._categories = new List<Category>() {
				new Category { CategoryId = 1, Name = "Category 1", Description = "Description 1" },
				new Category { CategoryId = 2, Name = "Category 2", Description = "Description 2" },
				new Category { CategoryId = 3, Name = "Category 3", Description = "Description 3" }
			};
		}


		public IEnumerable<Category> GetCategoreis()
		{
			return this._categories;
		}
		 
 		public void AddCategory(Category category)
		{
            if (_categories.Any(x => x.Name.Equals(category.Name, StringComparison.OrdinalIgnoreCase))) return;

            if (_categories != null && _categories.Count > 0)
			{
                var maxId = _categories.Max(x => x.CategoryId);
                category.CategoryId = maxId + 1;
            }
			else
			{
                category.CategoryId = 1;
            }
            _categories.Add(category);
        }

		public void UpdateCategory(Category category)
		{
			var categoryToUpdate = this.GetCategoryById(category.CategoryId);

            if (categoryToUpdate != null)
			{
				categoryToUpdate.Name = category.Name;
				categoryToUpdate.Description = category.Description;
            }
		}

        public Category GetCategoryById(int categoryId)
		{
            return _categories?.FirstOrDefault(x => x.CategoryId == categoryId);
        }

		public void DeleteCategory(int categoryId)
		{
			_categories.Remove(this.GetCategoryById(categoryId));
		}
    }
}