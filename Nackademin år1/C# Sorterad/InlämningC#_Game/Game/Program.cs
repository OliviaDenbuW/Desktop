using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            ///<summary>
            /// Hanterar input
            ///</summary>
            ///<remarks>
            ///InputController Contoller  hanterar alla inputs från spelaren och ser om den kan göra action eller movment
            ///</remarks>
            InputController Contoller = new InputController();
            Contoller.StartGame();
            while (true)
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("UPP: W ");
                Console.WriteLine("NER: S");
                Console.WriteLine("VÄNSTER: A");
                Console.WriteLine("HÖGER: D");
                Console.WriteLine("use itemname för ta upp item");

                Console.Write("Var vill du gå?");
                string input = Console.ReadLine().ToLower();
                Contoller.inputCheck(input);
            }
        }
    }
}
