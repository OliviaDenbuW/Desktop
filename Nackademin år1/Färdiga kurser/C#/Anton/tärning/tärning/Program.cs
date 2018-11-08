using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tärning
{
    class Program
    {
        bool cheating;

        public Program(bool cheating)
        {
            this.cheating = cheating;
        }
        
        public void setCheating(bool value)
        {
            cheating = value;
        }

        public int rollDie()
        {
            if (cheating)
            {
                return 6;
            }
            else
            {
                Random random = new Random();
                return random.Next(1, 7);
                //return random.Next(6) + 1;
                //(1,7)
                //returnerar ngt mellan 0 och siffran man ger
                //1+0, 1+2...
            }
        }
        static void Main(string[] args)
        {
            Program obj = new Program(false);
            Console.WriteLine(obj.rollDie());
            Console.ReadLine();
        }
    }
}
