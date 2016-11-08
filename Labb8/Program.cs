using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb8
{
    class Program
    {
     
        static void Main(string[] args)
        {
            StringClass stringclass = new StringClass();

            string[] stringArray = new string[3] { "Niclas", "Daniel", "John" };


            // var runtime = new Runtime();
            // runtime.Start();

            Console.WriteLine(stringclass.Concat(stringArray, ','));
        }
    }
}
