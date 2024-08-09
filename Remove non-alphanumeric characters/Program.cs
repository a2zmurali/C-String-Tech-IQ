using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_non_alphanumeric_characters
{
    class Program
    {
        static void Main()
        {
            string input = "Hello, World! 123";
            string result = RemoveNonAlphanumeric(input);
            Console.WriteLine(result); // Output: HelloWorld123
            Console.ReadLine();
        }

        static string RemoveNonAlphanumeric(string input)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in input)
            {
                // Check if the character is alphanumeric
                if (char.IsLetterOrDigit(c))
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }
    }

}