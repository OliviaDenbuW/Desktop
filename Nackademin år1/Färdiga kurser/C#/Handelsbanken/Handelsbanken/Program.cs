using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handelsbanken
{
    class Program
    {
        static void Main(string[] args)
        {
            int blå = 5;
            int grön = 3;
            int gul = 2;

            while (gul > 27)
            {
                grön += 3;
                if (((gul / 2) == 6) || ((gul / 2) == 9))
                {
                    gul -= 2;
                    break;
                }
                gul = blå * grön;
                break;
            }
        }
    }
}
