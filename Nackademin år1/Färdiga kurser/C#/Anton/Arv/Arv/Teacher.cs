using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Teacher:Person
    {
        int[] keys = new int[10];
        int[] courses = new int[3];

        public Teacher():base()
        {
            Console.WriteLine(this.age);
            /*this.age = 18;
            this.name = "Olivia";
            this.length = 170;*/
        }
    }
}
