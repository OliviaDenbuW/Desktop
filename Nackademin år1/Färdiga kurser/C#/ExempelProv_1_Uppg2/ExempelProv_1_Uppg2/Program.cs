using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempelProv_1_Uppg2
{
    class Program
    {
        //Sortera strängen "231596874" till strängen "123456789" med en egen sortfunktion 
        static void Main(string[] args)
        {
            string osorteradSträng = "231596874";
            

            SorteradSträng(osorteradSträng);

            Console.ReadLine();
        }

        //Skapar metoden SorteraSträng
        public static void SorteradSträng(string osorteradSträng)
        {
            string[] osträngSplittad = osorteradSträng.Split(' ');
            foreach (var siffra in osträngSplittad)
            {
                Console.WriteLine(siffra);
            }
            
        }
    }
}
