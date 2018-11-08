using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2_Metoder_MaxMedelVärde
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMax(2, 4));
            Console.ReadLine();
        }

        static int GetMax(int nr1, int nr2)
        {
            if (nr1 > nr2)
            {
                return nr1;
            }
            else if (nr2 > nr1)
            {
                return nr2;
            }
            else
            {
                return 
            }
        }
    }
}
