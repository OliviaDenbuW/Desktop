using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1_1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hoppets svårighetsgrad: ");
            string inputSvårighetsgrad = Console.ReadLine();
            int svårighetsgrad = int.Parse(inputSvårighetsgrad);
            double maxPoängDomare = 0;
            double minPoängDomare = 10;
            double summaMedMinOchMaxPoäng = 0;
            double summanAvDeTreDomarna = 0;
            double slutgiltigPoäng = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Poäng domare {0}: ", i+1);
                string indataDomare = Console.ReadLine();
                double poängEnskildDomare = double.Parse(indataDomare);

                if (poängEnskildDomare > maxPoängDomare)
                {
                    maxPoängDomare = poängEnskildDomare;
                }

                if (poängEnskildDomare < minPoängDomare)
                {
                    minPoängDomare = poängEnskildDomare;
                }

                summaMedMinOchMaxPoäng += poängEnskildDomare;
            }

            summanAvDeTreDomarna = summaMedMinOchMaxPoäng - minPoängDomare - maxPoängDomare;
            slutgiltigPoäng = summanAvDeTreDomarna * svårighetsgrad;

            Console.WriteLine("Slutgiltig poäng: {0}", slutgiltigPoäng);
            Console.ReadLine();
        }
    }
}
