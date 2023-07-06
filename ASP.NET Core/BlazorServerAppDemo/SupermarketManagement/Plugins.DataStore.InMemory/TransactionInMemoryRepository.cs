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

        public IEnumerable<Transaction> Get(string cashierName)
        {
            if (string.IsNullOrWhiteSpace(cashierName))
            {
                return _transactions;
            }
            else
            {
                return _transactions.Where(t => string.Equals(t.CashierName, cashierName, StringComparison.OrdinalIgnoreCase));
            }

        }

        public IEnumerable<Transaction> GetByDay(string cashierName, DateTime date)
        {
            if (string.IsNullOrWhiteSpace(cashierName))
            {
                return _transactions.Where(t => t.TimeStamp.Date == date.Date);
            }
            else
            {
                return _transactions.Where(t => string.Equals(t.CashierName, cashierName, StringComparison.OrdinalIgnoreCase) && t.TimeStamp.Date == date.Date);
            }

        }

        public void Save(string casherName, int productId, string productName, double price, int beforeQty, int soldQty)
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
                    CashierName = casherName,
                    Transactionid = transactionId,
                    ProductId = productId,
                    ProductName = productName,
                    TimeStamp = DateTime.Now,
                    Price = price,
                    BeforeQty = beforeQty,
                    SoldQty = soldQty,
                });
        }

        public IEnumerable<Transaction> Search(string cashierName, DateTime startDate, DateTime endDate)
        {
            if (string.IsNullOrWhiteSpace(cashierName))
                return _transactions.Where(x => x.TimeStamp >= startDate.Date && x.TimeStamp <= endDate.Date.AddDays(1).Date);
            else
                return _transactions.Where(x =>
                    string.Equals(x.CashierName, cashierName, StringComparison.OrdinalIgnoreCase) &&
                    x.TimeStamp >= startDate.Date && x.TimeStamp <= endDate.Date.AddDays(1).Date);

        }
    }
}
