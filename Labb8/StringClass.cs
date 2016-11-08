using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb8
{
    class StringClass
    {

        public string Concat(string[] stringArray, char seperator)
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
