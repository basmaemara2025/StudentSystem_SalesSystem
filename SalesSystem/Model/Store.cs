using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDatabase.Model
{
    internal class Store
    {
        //StoreId
        public int StoreId { get; set; }
        //Name(up to 80 characters, unicode)
        public string Name { get; set; }

        //Sales
        public List<Sale> Sales { get; set; }
    }
}
