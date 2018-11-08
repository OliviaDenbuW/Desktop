using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tentaUppg4
{
    class Program
    {
        static void Main(string[] args)
        {
            Klubb klubb = new Klubb();
            Medlem medlem = new Medlem();

            medlem = klubb.Ordförande;
        }
    }
}
