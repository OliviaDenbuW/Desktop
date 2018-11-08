using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace tenta_sorteraSträng
{
    class Program
    {
        static void Main(string[] args)
        {
            string osorterad = "231596874";
            char[] array = osorterad.ToArray();

            for (int i = array.Length-1; i > -1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        char temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            string sorterad = "";
            foreach (var nr in array)
            {
                sorterad += nr;
            }

            string path = @"C:\Users\Olivia\Desktop\C#\sorteradSträng.txt";

            if (!File.Exists(path))
            {
                using (File.Create(path));
            }

            File.WriteAllText(path, sorterad + Environment.NewLine);
        }
    }
}
