using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_all_possible_substrings_in_a_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "india";          
            if (!string.IsNullOrEmpty(word))
            {
                for (int i = 1; i < word.Length; i++)
                {
                    for (int j = 0; j <= word.Length - i; j++)
                    {
                        Console.WriteLine(word.Substring(j, i));
                    }
                }
                Console.ReadLine();
            }
        }
    }
}