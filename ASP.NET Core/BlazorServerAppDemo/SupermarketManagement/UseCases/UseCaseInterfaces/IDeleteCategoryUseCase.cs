using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces
{
    public interface IDeleteCategoryUseCase
    {
        public void Delete(int categoryId);
    }
}
