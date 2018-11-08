using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2_Rekursiv_SkrivUtTal
{
    class Program
    {
        static void Main(string[] args)
        {
            SkrivUtTal(-11);
            Console.ReadLine();
        }

        static void SkrivUtTal(int tal)
        {
            if (tal > 11)
            {
                return;
            }
            Console.WriteLine(tal);
            SkrivUtTal(tal + 2);
        }
    }
}
