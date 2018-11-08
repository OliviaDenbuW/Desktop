using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anton_Arv_LärareStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher t1 = new Teacher();
            Student s1 = new Student();

            Console.WriteLine(t1.GetAge());
            Console.ReadLine();
        }
    }
}
