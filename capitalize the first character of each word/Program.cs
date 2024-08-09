using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capitalize_the_first_character_of_each_word
{
    class Program
    {
        static void Main()
        {
            string input = "example string to capitalize";
            string result = CapitalizeFirstLetterOfEachWord(input);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        static string CapitalizeFirstLetterOfEachWord(string input)
        {
            // Split the string into words
            string[] words = input.Split(' ');
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < words.Length; i ++)
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
            }

            foreach(var i in words)
            {
                sb.Append(i + " ");
            }

            return sb.ToString();
            //Or we can simply use below
            // Join the words back into a single string
            // return string.Join(" ", words);
        }
    }
}