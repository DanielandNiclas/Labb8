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
            
            Runtime runtime = new Runtime(); // Make a new instance of Runtime
            runtime.Start();    // Run the method Start
            runtime.StartNumber();
            Console.ReadKey(); // Just to stop the program to not exit without input.
        }
        
    }
}
