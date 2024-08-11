using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_number_ofoccurrences_in_a_sorted_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sortedArray1 = { 1, 2, 2, 2, 3, 4 ,4, 5, 5 , 6};

            Hashtable ht = new Hashtable();

            foreach (int i in sortedArray1)
            {
                if (!ht.ContainsKey(i))
                {
                   ht[i]= 1 ;
                }
                else
                {
                    ht[i] = (int)ht[i] + 1;
                }
            }

         
            // Print the frequencies of all elements
            foreach (DictionaryEntry entry in ht)
            {
                Console.WriteLine($"Element {entry.Key} occurs {entry.Value} times.");
            }




            // Using Dictionary


            int[] sortedArray2 = { 1, 2, 2, 2, 3, 4, 4, 5, 5, 6 };
            Dictionary<int, int> Dic = new Dictionary<int, int>();

            foreach (int i in sortedArray2)
            {
                if (!Dic.ContainsKey(i))
                {
                    Dic.Add(i, 1);
                }
                else
                {
                    Dic[i] += 1;
                }
            }

            Console.WriteLine(String.Join(" ", Dic));
            Console.ReadLine();
        }
    }
}
