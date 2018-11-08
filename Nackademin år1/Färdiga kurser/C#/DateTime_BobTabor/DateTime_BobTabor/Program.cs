using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_BobTabor
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            Console.WriteLine(today.ToString()); //2017-11-12 17:26:45
            Console.WriteLine(today.ToShortDateString()); //2017 - 11 - 12
            Console.WriteLine(today.ToShortTimeString()); //17:28
            Console.WriteLine(today.ToLongDateString()); //den 12 november 2017
            Console.WriteLine(today.ToLongTimeString()); //17:28:51

            Console.WriteLine();
            Console.WriteLine(today.AddDays(3).ToLongDateString());
            Console.WriteLine(today.AddHours(3).ToShortTimeString());
            Console.WriteLine(today.AddDays(-3).ToShortDateString());
            Console.WriteLine(today.AddDays(-3).ToLongDateString());

            Console.WriteLine();
            Console.WriteLine(today.Month.ToString()); //11

            DateTime myBirthday = new DateTime(1991, 11, 22);
            Console.WriteLine(myBirthday.ToShortDateString()); //1991-11-22

            DateTime myBday = DateTime.Parse("11/22/1991");
            TimeSpan myAge = DateTime.Now.Subtract(myBday);
            Console.WriteLine(myAge.TotalDays);

            /*****************************************
                2017-11-11 13:15:59
                2017-11-11
                13:15
                den 11 november 2017
                13:15:59

                den 14 november 2017
                16:15
                2017-11-08
                den 8 november 2017

                11
                1991-11-22
                9486,5527768112
            *********************************************/

            Console.ReadLine();
        }
    }
}
