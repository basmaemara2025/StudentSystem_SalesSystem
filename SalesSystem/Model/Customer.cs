using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDatabase.Model
{
    internal class Customer
    {
        // CustomerId
        public int CustomerId { get; set; }
        // Name(up to 100 characters, unicode)
        public string Name { get; set; }

        // Email(up to 80 characters, not unicode)
        public string Email { get; set; }

        // CreaditCardNumber(string)
        public string CreaditCardNumber { get; set; }

        //Sales
       public List<Sale> Sales { get;set; }


    }
}
