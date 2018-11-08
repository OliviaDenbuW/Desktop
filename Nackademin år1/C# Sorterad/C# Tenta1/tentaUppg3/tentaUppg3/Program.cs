using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tentaUppg3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nr1: ");
            int nr1 = int.Parse(Console.ReadLine());

            Console.Write("Nr2: ");
            int nr2 = int.Parse(Console.ReadLine());

            Console.Write("Nr3: ");
            int nr3 = int.Parse(Console.ReadLine());

            int biggestNr = 0;
            int average = 0;

            ComparingNumbers(nr1, nr2, nr3, ref biggestNr, ref average);
            Console.WriteLine(biggestNr);
            Console.WriteLine(average);
            Console.ReadLine();
        }

        private static void ComparingNumbers(int nr1, int nr2, int nr3, ref int biggestNr, ref int average)
        {
            if ((nr1 > nr2) && (nr1 > nr3))
            {
                biggestNr = nr1;
                average = (nr1 + nr2 + nr3) / 3;
            }
            else if ((nr2 > nr1) && (nr2 > nr3))
            {
                biggestNr = nr2;
                average = (nr1 + nr2 + nr3) / 3;
            }
            else if ((nr3 > nr1) && (nr3 > nr2))
            {
                biggestNr = nr3;
                average = (nr1 + nr2 + nr3) / 3;
            }
        }



        //public static void ComparingNumbers(int nr1, int nr2, int nr3, ref int biggestNr, ref int middleNr)
        //{      
        //    if ((nr1 > nr2) && (nr1 > nr3))
        //    {
        //        biggestNr = nr1;
        //        middleNr = nr2;
        //    }
        //   // return biggestNr;
        //}
    }
}
//    Console.Write("Nr1: ");
//    int nr1 = int.Parse(Console.ReadLine());

//    Console.Write("Nr2: ");
//    int nr2 = int.Parse(Console.ReadLine());

//    Console.Write("Nr3: ");
//    int nr3 = int.Parse(Console.ReadLine());

//    int biggestNr = 0;
//    int middleNr = 0;
//    ComparingNumbers(nr1, nr2, ref biggestNr, ref middleNr);
//    Console.WriteLine(biggestNr);
//    Console.WriteLine(middleNr);
//    //Console.WriteLine("Biggest  nr: {0}", big);
//    Console.ReadLine();
