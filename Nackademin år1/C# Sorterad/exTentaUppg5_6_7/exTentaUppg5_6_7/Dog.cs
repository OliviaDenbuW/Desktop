using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exTentaUppg5_6_7
{
    public class Dog
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public static int counter = 0;

        public Dog()
        {
            counter++;
        }
    }
}
