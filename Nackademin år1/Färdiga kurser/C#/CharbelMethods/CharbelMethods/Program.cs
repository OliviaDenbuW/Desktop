using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharbelMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program.EvenNumbers(100);

            Program p = new Program();
            int sum = p.Sum(283738, 3);

            Console.WriteLine(sum);
            Console.ReadLine();
        }

        public int Sum(int nr1, int nr2)
        {
            return nr1 + nr2;
        }

        public static void EvenNumbers(int target)
        {
            int start = 0;

            while (start <= target)
            {
                Console.WriteLine(start);
                start = start + 2;
            }
        }
    }
}
