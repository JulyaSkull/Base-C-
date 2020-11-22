using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 16, 14, 15, 18, 21, 34, 10, 7 };

            Surveillance_Of_Elements(array);

            Console.ReadKey();
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
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
            Console.WriteLine("Sort array");

            Surveillance_Of_Elements(array);

            Console.ReadKey();
        }

            static void Surveillance_Of_Elements(int[]array)
            {
            int count = 0;
                foreach (int x in array)
                {
                    count++;

                    Console.WriteLine($"#{count} : {x} \t");
                }
            }
        
    }
}

