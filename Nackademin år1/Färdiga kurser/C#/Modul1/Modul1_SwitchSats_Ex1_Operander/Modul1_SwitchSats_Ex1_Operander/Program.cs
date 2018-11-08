using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1_SwitchSats_Ex1_Operander
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("y: ");
            double y = double.Parse(Console.ReadLine());

            Console.Write("Operand: ");
            char operand = char.Parse(Console.ReadLine());

            switch (operand)
            {
                case '+':
                    Console.WriteLine("{0} + {1} = {2}", x, y, x+y);
                    break;
                case '-':
                    Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
                    break;
                case '/':
                    Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
                    break;
                case '*':
                    Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
                    break;
            }

            Console.ReadLine();
        }
    }
}
