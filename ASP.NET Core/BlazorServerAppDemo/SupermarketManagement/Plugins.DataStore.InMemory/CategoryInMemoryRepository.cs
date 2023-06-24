using CoreBusiness;
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


		IEnumerable<Category> ICategoryRepository.GetCategoreis()
		{
			return this._categories;
		}
	}
}