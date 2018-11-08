using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan_Kap2_Uppg8_Grattis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Personnummer: ");
            string personnummer = Console.ReadLine();

            //Hitta månad och dag i personnummer
            //  911122
            //  012345
            int monthOfBirthday = int.Parse(personnummer.Substring(2, 2));
            int dayOfBirthday = int.Parse(personnummer.Substring(4, 2));

            //Dagens datum
            DateTime today = DateTime.Now;

            if (monthOfBirthday == today.Month && dayOfBirthday == today.Day)
            {
                Console.WriteLine("Congratulations");
            }
            else
            {
                Console.WriteLine("Not ur birthday");
            }

            Console.WriteLine(today.Day);
            Console.WriteLine(today.Month);
            Console.ReadLine();
        }
    }
}
