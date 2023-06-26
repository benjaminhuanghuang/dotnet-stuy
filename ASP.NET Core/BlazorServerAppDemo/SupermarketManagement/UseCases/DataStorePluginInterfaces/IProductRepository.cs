﻿using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        void AddProduct(Product product);
        //void UpdateCategory(Category category);
        //Category GetCategoryById(int categoryId);
        //void DeleteCategory(int categoryId);
    }
}
