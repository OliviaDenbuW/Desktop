using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doFactoryStrategy
{
    class ConcreteStrategyC : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine(
              "Called ConcreteStrategyC.AlgorithmInterface()");
        }
    }
}
