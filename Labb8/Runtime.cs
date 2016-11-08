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

        public delegate float DFloatOperator(float[] floatArray);

        public void Start()
        {
            // Define a string array
            string[] stringArray = new string[3] { "Niclas", "Daniel", "John" };

            // Make a new instance of the string delegator that uses the concat method.
            DStringConcatinator del1 = new DStringConcatinator(concat);

            // Just write the result to console for first implementation.
            Console.WriteLine(del1(stringArray, ','));  // This cw calls the delegate and sends our stringArray and separator as parameters.


        }

        public void StartNumber()
        {
            // Define a float array
            float[] floatArray = new float[3] { 5.5F, 3.5F, 25.1F };

            // Make a new instances of the float delegators.
            DFloatOperator FloatAdd = new DFloatOperator(floatAddMethod);
            DFloatOperator FloatMultiply = new DFloatOperator(floatMultiplyMethod);

            // Write the results to screen
            Console.WriteLine(FloatAdd(floatArray).ToString());
            Console.WriteLine(FloatMultiply(floatArray).ToString());
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

        private float floatAddMethod(float[] floatArray)
        {
            float retFloat = 0F;
            foreach(float f in floatArray)
            {
                retFloat += f;
            }
            return retFloat;
        }

        private float floatMultiplyMethod(float[] floatArray)
        {
            // This class multiplying all the floats in floatArray.
            // Returns: float
            // Method is private because delegate uses it and should not be used outside this class.

            float retFloat = floatArray[0]; // Start with first float

            // Start a for loop with i = 1 because thats our two first numbers. 
            for (int i = 1; i < floatArray.Length; i++)
            {
                Console.Write("Multiplying " + retFloat.ToString() + " and " +floatArray[i].ToString());

                retFloat *= floatArray[i];  // Multiply retFloat with next float from floatArray

                Console.WriteLine(" = " +retFloat.ToString());
            }

            return retFloat; // Return our completed float result

        }

    }

}
