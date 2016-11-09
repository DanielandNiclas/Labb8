using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb8
{

    class ProductManager
    {
        public delegate float NumberOperator(List<Product> priceList, float totalMultiply);
        public delegate string StringConcatinator(List<Product> prodList);

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

        private float PriceCalculation(List<Product> priceList, float totalMultiply)
        {
            float ret = 0F;

            foreach (Product product in priceList)
            {
                ret += product.Price;
            }
            if (totalMultiply != 0)
            {
                ret *= totalMultiply;
            }
            return ret;

        }

        public float CalcPrice(List<Product> prodList, float totalMultiply )
        {
            NumberOperator numbOperator = new NumberOperator(PriceCalculation);

            return numbOperator(prodList, totalMultiply);

        }

        private string FormatProductNames(List<Product> prodList)
        {
            string ret = "";

            foreach (Product product in prodList)
            {
                ret += product.Name + ",";
            }

            ret = ret.Remove(ret.Length - 1);

            return ret;
        }

        public void PrintAllProducts()
        {
            foreach (var product in Products)
            {
                Console.WriteLine("ID: {0}, Name: {1}, Price: {2}", product.ID, product.Name, product.Price);
            }
        }

        public string GetProducts(List<Product> proList)
        {
            StringConcatinator stringConcat = new StringConcatinator(FormatProductNames);

            return stringConcat(Products);

        }
    }
}

