using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exempeltenta1_SparaSträngITextfil
{
    class Program
    {
        static void Main(string[] args)
        {
            string sträng = "Hejhejehejeh";
            string path = @"C:\Users\Olivia\Desktop\C#\sorteradSträng.txt";

            File.WriteAllText(path, sträng);
            Console.ReadLine();
        }
    }
}
