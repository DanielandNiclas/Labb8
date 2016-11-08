using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb8
{
    class Program
    {
        public delegate string StringConcatinator(string[] stringArray, char seperator);
        static void Main(string[] args)
        {
            //StringClass stringclass = new StringClass();
            StringConcatinator del1 = new StringConcatinator(concat);

            string[] stringArray = new string[3] { "Niclas", "Daniel", "John" };


            // var runtime = new Runtime();
            // runtime.Start();

            Console.WriteLine(del1(stringArray, ','));


        }
        public static string concat(string[] stringArray, char seperator)
        {
            string ret = "";

            foreach (string s in stringArray)
            {
                ret += s + seperator;
            }
            ret = ret.Remove(ret.Length - 1);
            return ret;

        }
    }
}
