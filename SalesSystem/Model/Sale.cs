using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDatabase.Model
{
    internal class Sale
    {
        //SaleId
        public int SaleId { get; set; }
        //Date
        public DateTime Date { get; set; }

        //Product
        public int ProductId { get; set; }

        //Customer
        public int CustomerId { get; set; }

        //Store
        public int StoreId { get; set; }
        public Store Store { get; set; }

    }
}
