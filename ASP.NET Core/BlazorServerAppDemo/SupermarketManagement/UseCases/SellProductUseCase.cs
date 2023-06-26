﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces;

namespace UseCases
{
    public class SellProductUseCase:ISellProductUseCase
    {
        private readonly IProductRepository _productRepository;
        public SellProductUseCase(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        public void Execute(int productId, int qtyToSell)
        {
            var product = _productRepository.GetProductById(productId);
            if (product == null)
            {
                return;
            }
            product.Quantity -= qtyToSell;
            _productRepository.UpdateProduct(product);
        }
    }
}
