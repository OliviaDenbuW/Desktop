using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tenta_Uppg1_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Date you have to pay next bill: ");
            string dayToPay = Console.ReadLine();

            DateTime dayToPayConverted = DateTime.Parse(dayToPay);
            DateTime today = DateTime.Now;

            TimeSpan daysLeftToPay = dayToPayConverted.Subtract(today);
            Console.WriteLine("Days left to pay: {0} days", daysLeftToPay.Days);

            Console.ReadLine();
        }
    }
}
