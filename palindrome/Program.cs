using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string Input = "radar";
            Program P = new Program();
            Console.WriteLine(P.Checkpalindrome(Input)); 
            Console.ReadKey();
        }
        public bool Checkpalindrome(string Input)
        {
            if (string.IsNullOrEmpty(Input))
                return false;
            Input = Input.ToLower().Trim();
            int min = 0; 
            int max = Input.Length - 1;

            while(max >= min)
            {
                if (Input[min] == Input[max])
                {
                    min++;
                    max--;
                }
                else
                {
                    return false;
                }
                
            }
            return true;
        }
    }
}
