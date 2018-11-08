using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2_ArrayList_Mosh_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            char[] array = new char[name.Length];

            for (int i = name.Length; i > 0; i--)
            {
                array[name.Length - 1]
            }

            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];

            var reversed = new string(array);
            Console.WriteLine("Reversed name: " + reversed);

            //char[] letters = name.ToCharArray();

            //for (int i = letters.Length; i >= 0; i--)
            //{
            //    Console.Write(letters[i]);
            //}
            Console.ReadLine();
        }
    }
}
