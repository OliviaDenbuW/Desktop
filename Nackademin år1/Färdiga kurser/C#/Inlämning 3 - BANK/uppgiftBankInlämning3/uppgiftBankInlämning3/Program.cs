using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //Ta bort sen


namespace uppgiftBankInlämning3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customerList = new List<Customer>();
            List<Account> accountList = new List<Account>();

            //AuthorList.Add(new Author("Mahesh Chand", 35, "A Prorammer's Guide to ADO.NET", true, new DateTime(2003, 7, 10)));

            Bank.GetFile();
            //Customer.AddCustomerToList(customerList);

            Console.ReadLine();
        }
    }
}
