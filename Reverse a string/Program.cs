using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_a_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string Input = "Hello Murali Suganya";
            Reversestring(Input);
            Console.ReadKey();
        }
        static void Reversestring( string Input)
        {
            StringBuilder revers = new StringBuilder();

            //  Console.WriteLine(Input.Length); //5
            // Console.WriteLine(Input[Input.Length-1]);

            for ( int i = Input.Length - 1; i >= 0 ; i--)
            {
                revers.Append(Input[i]);
            }

            Console.WriteLine(revers);
        }
    }
}
