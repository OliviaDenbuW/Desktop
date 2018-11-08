using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace halloween
{
    public abstract class Fest
    {
        protected string name;
        protected DateTime date;
        protected double cost;

        public double GetCost()
        {
            return cost;
        }

        public void SetCost(double cost)
        {
            this.cost = cost;
        }

        public abstract double Inträde(); 
    }
}
