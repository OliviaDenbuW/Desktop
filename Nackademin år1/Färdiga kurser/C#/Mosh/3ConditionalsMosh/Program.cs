using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3ConditionalsMosh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Width: ");
            string inputW = Console.ReadLine();
            int widht = Convert.ToInt32(inputW);

            Console.Write("Height: ");
            string inputH = Console.ReadLine();
            int height = Convert.ToInt32(inputH);

            var orientation = (widht > height) ? ImageOrientation.Landscape : ImageOrientation.Portrait;
            Console.WriteLine("It is a {0}", orientation);
            Console.ReadLine();
        }

        public enum ImageOrientation
        {
            Landscape,
            Portrait
        }
    }
}
