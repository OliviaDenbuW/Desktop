using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_ClassMembers_Circel_Kudvenkat
{
    class Circle
    {
        private static float _PI = 3.141F;
        private int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public float CalculateArea()
        {
            return Circle._PI * this.radius * this.radius;
        }
    }
}
