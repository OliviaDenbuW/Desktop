using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omtenta_1DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("When are you born: (11/12/1991) ");
            string dayPersonIsBorn = Console.ReadLine();

            DateTime birthday = DateTime.Parse(dayPersonIsBorn);
            TimeSpan age = DateTime.Now.Subtract(birthday);
            double daysBorn = age.TotalDays;
            double years = (int)daysBorn / 365;

            Console.WriteLine("You are " + years + " years old");
            Console.ReadLine();
        }
    }
}
