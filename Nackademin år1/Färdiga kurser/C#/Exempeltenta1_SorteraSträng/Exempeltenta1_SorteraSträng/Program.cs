using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exempeltenta1_SorteraSträng
{
    class Program
    {
        static void Main(string[] args)
        {
            string osorteradSträng = "231596874";

            char[] array = osorteradSträng.ToArray();


            for (int i = array.Length - 1; i > -1; i--)
            {
                for (int j = 0; j < i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        char temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            string sorteradSträng = "";

            foreach (var nr in array)
            {
                Console.Write(nr);
            }
            Console.ReadLine();
        }
    }
}
