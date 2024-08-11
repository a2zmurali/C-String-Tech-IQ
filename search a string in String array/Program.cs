using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace search_a_string_in_String_array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "DotNet", "Munesh Sharma", "Kishan", "Ravi", "Mohan", "Rahul", "Govind" };

            var stringToFind = "Rahul";

            var result = Array.Find(names, x => x == stringToFind);

             Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
