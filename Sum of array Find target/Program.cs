using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_array_Find_target
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4 ,5 , 6};
            int lenght = array.Length;
            int traget = 7;

            List<int[]> listarray = new List<int[]>();

            for( int i = 0; i < lenght -1; i++)
            {
                for (int j = i +1; j < lenght ; j++)
                {
                    if(array[i] + array [j] == traget)
                    {
                        int[] ary = { array[i], array[j] };
                        listarray.Add(ary);
                       // listarray.Add(new int[] { array[i], array[j] });
                    }
                }
            }

            foreach (var a in listarray)
            {
                Console.WriteLine(string.Join(", ", a));
            }


            Console.ReadLine();

        }
    }
}
