using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb8
{

    class ProductManager
    {
        public delegate string StringConcatinator();

        public List<Product> Products { get; set; }

        public ProductManager()
        {
            Products = new List<Product>()
            {
                new Product { ID = 101, Name = "Milk", Price = 10.5F },
                new Product { ID = 102, Name = "Spaghetti", Price = 20.5F },
                new Product { ID = 103, Name = "Golden Meatballs", Price = 1025.5F },
                new Product { ID = 104, Name = "Diamond Ketchup", Price = 2030.5F }
        };
        }

    }
}

