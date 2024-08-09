using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRL_UPS
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

        static void Findduplicates( string Input)
        {
            Dictionary<char, int> DupCount = new Dictionary<char, int>();

            foreach(char c in Input)
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

            foreach(var items in DupCount)
            {
                if(items.Value > 1)
                {
                    Console.WriteLine($"{items.Key } appers in {items.Value } Times ") ;
                }
            }

            Console.WriteLine(DupCount);

           

        }
    }
}
