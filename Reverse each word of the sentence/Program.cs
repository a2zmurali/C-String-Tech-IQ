using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_each_word_of_the_sentence
{
    class Program
    {
        static void Main(string[] args)
        {
            string Input = "Hello Murali Suganya";
            Program a = new Program();
            Console.WriteLine(a.ReverseEachWordstring(Input));
            
            Console.ReadKey();
        }
        public string ReverseEachWordstring(string Input)
        {
            string[] words = Input.Split(' ');
            StringBuilder result = new StringBuilder();
            for (int i =0; i< words.Length;i++)
            {
                result.Append(Reversestring(words[i]));

                if(i != words.Length )
                {
                    result.Append(' ');
                }

            }
            return result.ToString();

        }

        public string Reversestring(string Input)
        {
            StringBuilder revers = new StringBuilder();


            for (int i = Input.Length - 1; i >= 0; i--)
            {
                revers.Append(Input[i]);
            }

            return revers.ToString();

        }
    }
}
