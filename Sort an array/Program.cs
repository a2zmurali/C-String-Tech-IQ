using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_an_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 4, 2, 9, 5, 6, 3, 11 };
            int temp = 0;
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j]) //  if (arr[i] < arr[j]) desc
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("Array sort in asscending order");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();


        }
    }
}
