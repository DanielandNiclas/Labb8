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
            var loop = true;
            while (loop)
            {
                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
