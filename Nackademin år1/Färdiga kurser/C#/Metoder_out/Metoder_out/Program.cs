using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder_out
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum;
            double prod;
            double diff = 0;
            double avg = 0;
            
            SumAndProd(19, 10, out sum, out prod);
            DiffAndAvg(22, 10, ref diff, ref avg);
            Console.WriteLine("Summan: {0}", sum);
            Console.WriteLine("Produkten: {0}", prod);
            Console.WriteLine();
            Console.WriteLine("Diff: {0}", diff);
            Console.WriteLine("Avg: {0}", avg);
            Console.ReadLine();
        }

        //Skapa metod som summerar och multiplicerar
        public static void SumAndProd(double firstNr, double secNr, out double sum, out double prod)
        {
            sum = firstNr + secNr;
            prod = firstNr * secNr;
        }

        //Skapa metod som minus och medelvärde
        public static void DiffAndAvg(double firstNr, double secNr, ref double diff, ref double avg)
        {
            diff = firstNr - secNr;
            avg = (firstNr + secNr) / 2;
        }
    }
}
