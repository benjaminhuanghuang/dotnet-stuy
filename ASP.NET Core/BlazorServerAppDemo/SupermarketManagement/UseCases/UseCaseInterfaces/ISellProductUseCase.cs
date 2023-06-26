﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces
{
    public interface ISellProductUseCase
    {
        public void Execute(string cashierName, int productId, int qtyToSell);
    }
}
