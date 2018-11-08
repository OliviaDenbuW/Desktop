using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1_DateTime_IgårOchIdag
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime mariasBday = new DateTime(2017, 11, 01);
            DateTime oliviasBday = new DateTime(2017, 11, 22);

            TimeSpan mellan = oliviasBday.Subtract(mariasBday);
            
            Console.WriteLine(mellan);  //OUTPUT 21.00:00:00
            Console.WriteLine("{0} dagar", mellan.TotalDays);  //OUTPUT: 21 dagar

            //MÅNADER
            /*
            int days = DateTime.DaysInMonth(2014, 9); // September.
            Console.WriteLine(days);

            days = DateTime.DaysInMonth(2014, 2); // February.
            Console.WriteLine(days);
            /*
            DateTime tomorrow = DateTime.Today.AddDays(1);
            Console.WriteLine("Tomorrow: {0}", tomorrow);

            DateTime y = DateTime.Today.AddDays(-1);
            Console.WriteLine("Yesterday: {0}", y);

            Console.WriteLine("Today: {0}", DateTime.Today);
            */
            Console.ReadLine();
        }
    }
}
