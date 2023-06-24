﻿using CoreBusiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces;

namespace UseCases
{
	public class ViewCategoriesUseCase: IViewCategoriesUseCase
	{
		private readonly ICategoryRepository _categoryRepository;
		public ViewCategoriesUseCase(ICategoryRepository categoryRepository)
		{
			this._categoryRepository = categoryRepository;
		}
		public IEnumerable<Category> Execute()
		{
			return _categoryRepository.GetCategoreis();
		}
	}
}