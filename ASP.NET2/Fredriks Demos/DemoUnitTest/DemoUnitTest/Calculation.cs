using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoUnitTest
{
    //Detta är kod som vi skapar unit test för
    public class Calculation
    {
        public int Addition(int value1, int value2)
        {
            return value1 + value2;

        }

        public float Division(float value1, float value2)
        {
            return value1 / value2;

        }

        public int Multiplication(int value1, int value2)
        {
            return value1 * value2;
        }

    }
}
