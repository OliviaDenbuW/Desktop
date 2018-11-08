using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codefights_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 3, 3, 1, 5, 2 };

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        Console.WriteLine(array[i]);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
