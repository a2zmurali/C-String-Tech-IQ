using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Move_zeros_to_end_of_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 0, 0, 6, 10, 9 };

            int index = 0;

            for(int i = 0; i < array.Length; i++ )
            {
                if(array[i] != 0)
                {
                    array[index] = array[i];
                    index ++;
                }
            }

            for(int i = index; i < array.Length; i++ )
            {

                array[i] = 0;
            }

            Console.WriteLine(String.Join(" ",array));

            Console.ReadKey();


        }
    }
}
