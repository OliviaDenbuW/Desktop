using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2_Rekursiv_EttTillTjugo
{
    class Program
    {
        static void Main(string[] args)
        {
            SkrivUtTal(40);
            Console.ReadLine();
        }

        static void SkrivUtTal (int tal)
        {
            if (tal < 20)
            {
                return;
            }
            Console.WriteLine(tal);
            SkrivUtTal(tal - 1);
        }
        //static void SkrivUtTal (int tal)
        //{
        //    if (tal > 20)
        //    {
        //        return;
        //    }
        //    Console.WriteLine(tal);
        //    SkrivUtTal(tal + 1);
        //}
    }
}
