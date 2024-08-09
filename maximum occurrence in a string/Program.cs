using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximum_occurrence_in_a_string
{
    class Program
    {
        //Find duplicate characters in a string
        static void Main(string[] args)
        {
            string Input = "Hello World";
            Findduplicates(Input);
            Console.ReadKey();

        }

        static void Findduplicates(string Input)
        {
            Dictionary<char, int> DupCount = new Dictionary<char, int>();

            foreach (char c in Input)
            {
                if (DupCount.ContainsKey(c))
                {
                    DupCount[c]++;
                }
                else
                {
                    DupCount[c] = 1;
                }

            }

            // Find the character with the maximum occurrence
            char? maxChar = null;
            int maxCount = 0;

            foreach(var item in DupCount)
            {
                if(item.Value > maxCount)
                {
                    maxChar = item.Key;
                    maxCount = item.Value;

                }
            }

            Console.WriteLine($"Character '{maxChar}' appears the most with {maxCount} occurrences.");
        }

    }
}
