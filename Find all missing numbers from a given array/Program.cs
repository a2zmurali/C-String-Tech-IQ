using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_all_missing_numbers_from_a_given_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 5, 5, 7 };
            int temp = 0;

            //sort the array
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }


            // remove duplicate from array 
            List<int> uniqueNumbers = new List<int>();
            foreach (int number in array)
            {
                // Check if the list already contains the element
                if (!uniqueNumbers.Contains(number))
                {
                    // If not, add the element to the list
                    uniqueNumbers.Add(number);
                }
            }

            //          
            // Actual logic gones here
            int diff = array[0] - 0;

            for (int i = 0; i < array.Length; i++)
            {
                // Check if diff and arr[i]-i
                // both are equal or not

                if (array[i] - i != diff)
                {
                    // Loop for consecutive
                    // missing elements
                    while (diff < array[i] - i)
                    {
                        Console.WriteLine(i + diff + " ");
                        diff++;
                    }
                }
            }

            Console.ReadLine();
        }
    }
}