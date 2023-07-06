using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.SQL
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly MarketContext _db;

        public TransactionRepository(MarketContext db)
        {
            this._db = db;
        }


        public IEnumerable<Transaction> Get(string cashierName)
        {
            return this._db.Transactions.ToList();
        }

        public IEnumerable<Transaction> GetByDay(string cashierName, DateTime date)
        {
           if(string.IsNullOrEmpty(cashierName))
            {
                return this._db.Transactions.Where(x => x.TimeStamp.Date == date.Date);
            }
            else
            {
                return this._db.Transactions.Where(x => x.CashierName.Equals(cashierName, StringComparison.OrdinalIgnoreCase) && x.TimeStamp.Date == date.Date);
            }       
        }

        public void Save(string cashierName, int productId, string productName, double price, int beforeQty, int soldQty)
        {
            var transaction = new Transaction
            {
                ProductId = productId,
                ProductName = productName,
                TimeStamp = DateTime.Now,
                Price = price,
                BeforeQty = beforeQty,
                SoldQty = soldQty,
                CashierName = cashierName
            };

            _db.Transactions.Add(transaction);
            _db.SaveChanges();
        }

        public IEnumerable<Transaction> Search(string cashierName, DateTime startDate, DateTime endDate)
        {
            if (string.IsNullOrWhiteSpace(cashierName))
                return _db.Transactions.Where(x => x.TimeStamp >= startDate.Date && x.TimeStamp <= endDate.Date.AddDays(1).Date);
            else
                return _db.Transactions.Where(x =>
                    string.Equals(x.CashierName, cashierName, StringComparison.OrdinalIgnoreCase) &&
                    x.TimeStamp >= startDate.Date && x.TimeStamp <= endDate.Date.AddDays(1).Date);
        }
    }
}
