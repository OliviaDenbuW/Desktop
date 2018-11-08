using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern;

namespace TestBengansBowlinghall
{
    class Program
    {
        static void Main(string[] args)
        {
            ContextStrategy contextStrategy;

            contextStrategy = new ContextStrategy(new ConcreteStrategyA());
            contextStrategy.ContextInterface();

            Console.ReadLine();
        }
    }
}
