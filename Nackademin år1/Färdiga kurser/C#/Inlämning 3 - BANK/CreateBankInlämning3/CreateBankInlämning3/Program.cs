using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CreateBankInlämning3
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.Textfil();
            while (bank.HuvudMeny())
            {
                //Loopar menyn så länge den är sann.
            }
        }
    }
}
