using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inklpsling_Box_Mr1Buying
{
    class Box
    {
        private double width;
        private double height;
        public double omkrets;
        
        public double GetWidth()
        {
            return this.width;
        }

        public void SetWidth(double width)
        {
            if(width > 200)
            {
                Console.WriteLine("Box is too big");
            }
            else
            {
                this.width = width;
                Omkrets();
            }
        }
    

        public double GetHeight()
        {
            return this.height;
        }

        public void SetHeight(double height)
        {
            if (height > 50)
            {
                Console.WriteLine("Bow will be too high");
            }
            else
            {
                this.height = height;
                Omkrets();
            }
        }

        private void Omkrets()
        {
            omkrets = width * 2 + height * 2;
        }
    }
}
