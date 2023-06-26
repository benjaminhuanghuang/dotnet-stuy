﻿using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.ProductsUseCases;
using UseCases.UseCaseInterfaces;

namespace UseCases
{
    public class RecordTransactionUseCase
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly IGetProductByIdUseCase _getProductByIdUseCase;
        public RecordTransactionUseCase(
            ITransactionRepository transactionRepository,
            IGetProductByIdUseCase getProductByIdUseCase
            )
        {
            _transactionRepository = transactionRepository;
            _getProductByIdUseCase = getProductByIdUseCase;

        }

        public void Execute(string cashierName, int productId, int qty)
        {
            var product = _getProductByIdUseCase.Execute(productId);
            _transactionRepository.Save(cashierName, productId, product.Price.Value, qty);
        }
    }
}
