using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unique_characters_in_a_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "google";
            GetUniqueCharacters(input);
            Console.ReadKey();
        }

        static void GetUniqueCharacters(string input)
        {

            HashSet<char> UniqueChar = new HashSet<char>(input);

            foreach(char c in UniqueChar)
            {
               
                Console.Write(c + " ");
            }

        }
    }
}
