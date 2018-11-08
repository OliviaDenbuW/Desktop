using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamlaTentor
{
    class Hund
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public Hundägare Ägare { get; set; }
        public static int count = 0;

        public Hund(string name, string color, Hundägare ägare)
        {
            this.Name = name;
            this.Color = color;
            this.Ägare = ägare;
            count++;
        }

        public static void HowManyDogs()
        {
            Console.WriteLine(count);
        }
    }
}
