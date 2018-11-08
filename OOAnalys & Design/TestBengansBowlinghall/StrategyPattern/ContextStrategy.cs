using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class ContextStrategy
    {
        private Strategy _strategy;

        public ContextStrategy(Strategy strategy)
        {
            _strategy = strategy;
        }

        public void ContextInterface()
        {
            _strategy.AlgorithmInterface();
        }
    }
}
