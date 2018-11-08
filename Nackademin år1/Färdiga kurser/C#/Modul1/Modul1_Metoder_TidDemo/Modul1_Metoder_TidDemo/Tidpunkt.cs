using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1_Metoder_TidDemo
{
    class Tidpunkt
    {
        //Instansvariabler
        int tim, min, sek;
        bool visaSek = true;

        public void Sätt (int t, int m, int s)
        {
            if ((t >= 0) && (t < 24) && (m >= 0) && (m < 60) && (s >= 0) && (s < 60))
            {
                tim = t; min = m; sek = s;
            }
            else
            {
                Console.WriteLine("Felaktig tidpunkt");
            }
        }

        //SättVisaSek
        public void SättVisaSek (bool visa)
        {
            visaSek = visa;
        }

        //AvläsTim
        public int AvläsTim()
        {
            return tim;
        }
        //AvläsMin

        //AvläsSek

        //Ticka
    }
}
