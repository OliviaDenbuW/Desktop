using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoLoopar
{
    class Program
    {

        static void Main(string[] args)
        {
            //VanligLoop();

            //ForLoopMedIf();

            //EnWhileLoop();

            //WhileLoopMedIfOchGoto();

            EnDoWhileLoop();


            Console.WriteLine("Klar!");
        }

        private static void EnDoWhileLoop()
        {
            int i = 10;

            do
            {
                Console.WriteLine(i);

                i = i - 1; // i--;
            } while (i >= 0);
        }

        private static void WhileLoopMedIfOchGoto()
        {
            int i = 10;

            loop2:
            if (i >= 0)
            {
                Console.WriteLine(i);

                i = i - 1; // i--;

                goto loop2;
            }
        }

        private static void EnWhileLoop()
        {
            int i = 10;

            while (i >= 0)
            {
                Console.WriteLine(i);

                i = i - 1; // i--;
            }
        }

        static void VanligLoop()
        {
            //int sägAntalSägHej = -5;

            for (double d = 0.0; d < Math.PI; d = d + 0.1)
            {
                Console.WriteLine("Hej " + d.ToString());
            }
        }

        private static void ForLoopMedIf()
        {
            double d = 0.0;

            loop:
            if (d < Math.PI)
            {
                Console.WriteLine("Hej " + d.ToString());

                d = d + 0.1;

            }
        }
    }
}
