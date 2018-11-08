using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            Cat c1 = new Cat("olivia", "red", 1);
            Cat c2 = new Cat("lilly", "white", 3);
            Cat c3 = new Cat("milly", "black", 5);
            Cat c4 = new Cat("silly", "black", 55);
            Cat c5 = new Cat("dilly", "brown", 0);
            Cat c6 = new Cat("allly", "white", 3);

            var result = from cat in 

            var orderByResult = from s in studentList
                                orderby s.StudentName
                                select s;

            Console.ReadLine();
        }
    }
}
