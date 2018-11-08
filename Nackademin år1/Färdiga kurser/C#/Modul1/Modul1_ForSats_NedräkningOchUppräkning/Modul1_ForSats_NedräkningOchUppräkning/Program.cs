using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1_ForSats_NedräkningOchUppräkning
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int radIndex = 20; radIndex > 0; radIndex--)
                {
                    for (int plustecken = 0; plustecken < radIndex; plustecken++)
                    {
                        Console.Write("+");
                    }
                    Console.WriteLine();
                }

                for (int radIndex = 1; radIndex < 20; radIndex++)
                {
                    for (int plustecken = 0; plustecken < radIndex; plustecken++)
                    {
                        Console.Write("+");
                    }
                    Console.WriteLine();
                }
            }
            
            Console.ReadLine();
        }
    }
}
