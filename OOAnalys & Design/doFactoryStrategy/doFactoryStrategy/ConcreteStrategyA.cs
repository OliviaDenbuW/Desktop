﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doFactoryStrategy
{
    class ConcreteStrategyA : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine(
              "Called ConcreteStrategyA.AlgorithmInterface()");
        }
    }
}
