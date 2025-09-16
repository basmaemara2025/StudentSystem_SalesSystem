using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDatabase.Model
{
    internal class Product
    {
        // ProductId
        public int ProductId { get; set; }
        //Name(up to 50 characters, unicode)
        public string Name { get; set; }
        // Quantity(real number)
        public decimal Quantity { get; set; }
        // Price
        public decimal Price { get; set; }
        //For table Products add string column Description, up to 250 symbols constraint will be added using Fluent API
        public string Description { get; set; }="No description";
        // Sales
        public List<Sale> Sales { get; set; }

    }
}
