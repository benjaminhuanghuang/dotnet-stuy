using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness
{
    public class Transaction
    {
        public int Transactionid { get; set; }
        public DateTime Timestamp { get; set; }
        public int Productid { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }
        public string CashierName { get; set; }
    }
}
