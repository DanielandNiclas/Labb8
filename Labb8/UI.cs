using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb8
{
    class UI
    {

        public static void MainMenu()
        {
            Console.WriteLine("1 - Show Products");
            Console.WriteLine("2 - Show only names");
            Console.WriteLine("3 - Show prices including discounts and taxes");
            Console.WriteLine("4 - Exit");
        }

        public static void MainMenuInput()
        {
            ProductManager prodManager = new ProductManager();

        var loop = true;
            while (loop)
            {
                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        prodManager.PrintAllProducts();
                        break;

                    case 2:
                        Console.WriteLine(prodManager.GetProducts(prodManager.Products));
                        break;

                    case 3:
                        Console.WriteLine("This is the total price + 20%");
                        Console.WriteLine(prodManager.CalcPrice(prodManager.Products, 1.2F));
                        Console.WriteLine("This is all the products that costs at least 1000 and with the discount");
                        List<Product> product2 = prodManager.Products.FindAll(product => product.Price > 1000);
                        Console.WriteLine(prodManager.CalcPrice(product2, 0.9F));

                        break;

                    case 4:
                        Environment.Exit(0);
                        break;
                }
            }
        }

       
    }
}
