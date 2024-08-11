using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_all_missing_numbers_from_a_given_array__2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example array
            int[] arr = { -2, 2 , 2, 3, 7, 4, 9 };           
            int n = arr[arr.Length -1 ];

            List<int> missingNumbers = FindMissingNumbers( arr, n );
            Console.WriteLine(String.Join(" ", missingNumbers));
            Console.ReadLine();
        }

        public static List<int> FindMissingNumbers(int[] arr, int n)
        {
            HashSet<int> numbers = new HashSet<int>(arr);
            int start_n = numbers.First();
            List<int> MissingNumbers = new List<int>();

            for(int i = start_n ; i <= n ; i++)
            {
                if(!numbers.Contains(i))
                {
                    MissingNumbers.Add(i);
                }
            }


            return MissingNumbers;
        }


    }
}
