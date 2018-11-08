using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoArray
{
    class Program
    {
        static void Main(string[] args)
        {

            SkapaEnJaggedArray();

            int[] enMassaTal;
            int[] andraTal;

            enMassaTal = new int[200_000_000];

            enMassaTal[0] = 1234;

            andraTal =  SkickaMedEnArray(ref enMassaTal);
        }

        private static void SkapaEnJaggedArray()
        {
            int[][] jagged;

            jagged = new int[3][];

            jagged[0] = new int[4];
            jagged[1] = new int[2];
            jagged[2] = new int[6];

            jagged[1][1] = 5;
        }

        private static int[] SkickaMedEnArray(ref int[] talen)
        {
            talen = new int[5];
            talen[0] = 4567;

            return talen;
        }
    }
}
