using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_an_array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reverse an array using the in-build method | using the Reverse() method
            int[] numbers = { 1, 2, 3, 4, 5 };
            Array.Reverse(numbers);
            Console.WriteLine("Reversed Array : ");
            foreach (int value in numbers)
            {
                Console.WriteLine(value);
            }

            //Reverse an array without using the Reverse() method
            int[] arr = { 1, 2, 3, 4, 5 }; 
            int length = arr.Length - 1;
            List<int> numbersList = new List<int>();

            while (length >=0)
            {
                numbersList.Add(arr[length]);
                length--;
            }
            Console.WriteLine("Reversed Array : " );
            foreach (int value in numbersList)
            {
                Console.WriteLine(value);
            }

            Console.ReadLine();


        }


    }
}
