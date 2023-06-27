﻿using CoreBusiness;

namespace UseCases.UseCaseInterfaces
{
    public interface IGetTodayTransactionsUseCase
    {
        IEnumerable<Transaction> Execute(string cashierName, int productId, int qty);
    }
}