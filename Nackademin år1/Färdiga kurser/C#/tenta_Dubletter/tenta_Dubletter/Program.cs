using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tenta_Dubletter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 11, 11, 12, 12, 13, 13, 14, 15, 16 };
            var hash = new HashSet<int>(array);

            int[] array2 = hash.ToArray();

            Console.WriteLine(string.Join(", ", array2));
            Console.ReadLine();

          
        }
    }
}
