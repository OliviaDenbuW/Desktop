using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1_DateTime_DagensDatum
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime todaysDate1 = new DateTime(2017, 11, 01);
            Console.WriteLine("Dagens datum är {0}", todaysDate1.ToString("MMMM dd, yyyy"));
            Console.ReadLine();
        }
    }
}
