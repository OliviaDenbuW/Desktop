using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tentaUppg7
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> talLista = new List<int> { 3, 7, 5, 8, 9, 1, 4, 11, 10, 12, 16, 13, 40, 28 };
            List<int> ojämnaTalLista = new List<int>();

            var nummerOjämna = talLista.FindAll(tal => tal % 2 != 0);

            foreach (var tal in nummerOjämna)
            {
                if (tal >= 2 && tal <= 12 )
                {
                    ojämnaTalLista.Add(tal);
                }
            }

            ojämnaTalLista.Sort();

            foreach (var nr in ojämnaTalLista)
            {
                Console.WriteLine(nr);
            }
            Console.ReadLine();
        }
    }
}
