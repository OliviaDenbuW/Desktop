using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repetionUppg5
{
    class Program
    {
        static void Main(string[] args)
        {
            HangMan game = new HangMan();

            game.PlayGame();
            Console.ReadKey();
        }

        
    }
}
