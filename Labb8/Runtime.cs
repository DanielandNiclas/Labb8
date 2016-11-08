using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb8
{


    class Runtime
    {
        public delegate string DStringConcatinator(string[] stringArray, char separator);

        public void Start()
        {
            // Define a string array
            string[] stringArray = new string[3] { "Niclas", "Daniel", "John" };

            // Make a new instance of the string delegator that uses the concat method.
            DStringConcatinator del1 = new DStringConcatinator(concat);

            // Just write the result to console for first implementation.
            Console.WriteLine(del1(stringArray, ','));  // This cw calls the delegate and sends our stringArray and separator as parameters.


        }

        private string concat(string[] stringArray, char separator)
        {
            // This class concatinates all the strings in stringArray with separator.
            // Returns: string
            // Method is private because delegate uses it and should not be used outside this class.

            string retString = ""; // A string variable that is empty at start but will contain full return string at the end.

            foreach (string s in stringArray)
            {
                // For each string in the string array...
                
                retString += s + separator; // Add the string to retString variable and add the separator to the end.
            }

            // When we have added all strings we have one separator too much in the retString.
           
            retString = retString.Remove(retString.Length - 1);  // Delete the last char in retString.
            
            return retString; // Return our completed retString.

        }
    }

}
