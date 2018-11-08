using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankOptimerad
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            bank.StartBankApp();
            bank.ShowMainMenu();
            bank.CreateFileWithCurrentBankInfo();

            Console.ReadLine();
        }
    }
}
