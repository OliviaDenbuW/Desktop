using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charbel_Frågesport_ReturnMultipleValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string tal = "8";
            int kontrolleratTal;

            bool kontrolleraTal = OliviasTryParse(tal, out kontrolleratTal);

            Console.WriteLine(kontrolleraTal);
            Console.WriteLine(kontrolleratTal);
            Console.ReadLine();
        }

        static bool OliviasTryParse(string tal1, out int tal2)
        {
            int kontrolleratTal;
            bool kontrollera = int.TryParse(tal1, out kontrolleratTal);

            tal2 = kontrolleratTal;
            return kontrollera;
        }


    }
}
