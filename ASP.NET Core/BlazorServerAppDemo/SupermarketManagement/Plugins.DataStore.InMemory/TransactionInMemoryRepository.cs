using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class TransactionInMemoryRepository : ITransactionRepository
    {
        private List<Transaction> _transactions;
        public TransactionInMemoryRepository()
        {
            _transactions = new List<Transaction>();
        }

        public IEnumerable<Transaction> GetByDay(DateTime date)
        {
            throw new NotImplementedException();
        }

        public void Save(string casherName, int productId, double price, int qty)
        {
            int transactionId = 0;
            if (_transactions != null && _transactions.Count > 0)
            {
                int maxId = _transactions.Max(t => t.Transactionid);
                transactionId = maxId + 1;
            }
            else
            {
                transactionId = 1;
            }
            this._transactions.Add(
                new Transaction
                {
                    Transactionid = transactionId,
                    Productid = productId,
                    Timestamp = DateTime.Now,
                    Price = price,
                    Qty = qty,
                });
        }
    }
}
