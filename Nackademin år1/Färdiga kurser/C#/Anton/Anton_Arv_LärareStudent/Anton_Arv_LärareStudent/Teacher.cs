using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anton_Arv_LärareStudent
{
    class Teacher : Person
    {
        int[] keys = new int[10];
        string[] courses = new string[3];

        public Teacher() : base()
        {
            Console.WriteLine(this.age); 
        }

        public int GetAge()
        {
            return age;
        }
    }
}
