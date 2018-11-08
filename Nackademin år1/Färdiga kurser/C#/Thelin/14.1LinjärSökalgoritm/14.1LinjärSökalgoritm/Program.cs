using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._1LinjärSökalgoritm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myList = new int[] { 3, 15, 7, 1, 42, 97, 52, 33, 82, 19 };
            int key = 33;

            for (int i = 0; i < myList.Length; i++)
            {
                if (myList[i] == key)
                {
                    Console.Write("Element finns på index {0}", i);
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
