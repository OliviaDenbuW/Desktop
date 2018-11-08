using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace bankOptimerad
{
    public class Bank
    {
        decimal totalBalanceOfBank = 0.0m;
        string inputAccountTransferFrom;
        string inputAccountTransferTo;
        string amountToTransfer;
        bool wantToExitApp;

        List<Customer> customerList = new List<Customer>();
        List<Account> accountList = new List<Account>();

        public void StartBankApp()
        {
            Console.WriteLine("================================================");
            Console.WriteLine("          WELCOME TO BANK APP 1.0");
            Console.WriteLine("================================================");
            Console.WriteLine();
            ReadTextFile(GetPathToTextFile());
        }

        public string GetPathToTextFile()
        {
            string pathToFile = "C:\\Users\\Olivia\\Desktop\\bankdata.txt";
            //string pathToFile = "C:\\Users\\Olivia\\Desktop\\Inlämning 3 - BANK\\bankdata.txt";
            return pathToFile;
        }

        public void ReadTextFile(string pathToTextFile)
        {
            using (StreamReader textFile = new StreamReader(pathToTextFile))
            {
                ReadCustomersFromTextFile(textFile);
                ReadAccountsFromTextFile(textFile);
                PrintCurrentBankStatus();
            }
        }

        public void ReadCustomersFromTextFile(StreamReader textFile)
        {
            int nrOfCustomers = int.Parse(textFile.ReadLine());


            for (int i = 0; i < nrOfCustomers; i++)
            {
                string fullInfoAboutCustomer = textFile.ReadLine();
                string[] partOfCustomerInfo = fullInfoAboutCustomer.Split(';');

                Customer customer = new Customer();
                customer.CustomerNumber = int.Parse(partOfCustomerInfo[0]);
                customer.OrgNumber = partOfCustomerInfo[1];
                customer.CompanyName = partOfCustomerInfo[2];
                customer.Address = partOfCustomerInfo[3];
                customer.City = partOfCustomerInfo[4];
                customer.Region = partOfCustomerInfo[5];
                customer.PostalNumber = partOfCustomerInfo[6];
                customer.Country = partOfCustomerInfo[7];
                customer.Telephone = partOfCustomerInfo[8];

                customerList.Add(customer);
            }
        }

        public void ReadAccountsFromTextFile(StreamReader textFile)
        {
            int nrOfAccounts = int.Parse(textFile.ReadLine());

            for (int i = 0; i < nrOfAccounts; i++)
            {
                string fullInfoAboutAccount = textFile.ReadLine();
                string[] partOfAccountInfo = fullInfoAboutAccount.Split(';');

                Account account = new Account();
                account.AccountNumber = int.Parse(partOfAccountInfo[0]);
                account.CustomerNumberOfAccount = int.Parse(partOfAccountInfo[1]);
                account.BalanceOfAccount = decimal.Parse(partOfAccountInfo[2], CultureInfo.InvariantCulture);

                accountList.Add(account);

                totalBalanceOfBank += account.BalanceOfAccount;
            }
        }

        public void PrintCurrentBankStatus()
        {
            Console.WriteLine("Number of customers:       {0}", customerList.Count());
            Console.WriteLine("Number of accounts:        {0}", accountList.Count());
            Console.WriteLine("Total balance of the bank: {0} SEK", totalBalanceOfBank);
            Console.WriteLine();
        }

        public void ShowMainMenu()
        {
            do
            {
                Console.WriteLine("MAIN MENU");
                Console.WriteLine("0) Save changes in program");
                Console.WriteLine("1) Search for customer");
                Console.WriteLine("2) Show customer");
                Console.WriteLine("3) Create new customer");
                Console.WriteLine("4) Delete customer");
                Console.WriteLine("5) Create new account");
                Console.WriteLine("6) Delete account");
                Console.WriteLine("7) Deposit");
                Console.WriteLine("8) Withdrawal");
                Console.WriteLine("9) Transfer");
                Console.WriteLine();

                Console.Write("Enter number of choice: ");
                string inputOperationChoise = Console.ReadLine();

                Console.WriteLine();
                PerformOperationOfChoice(inputOperationChoise);

            } while (wantToExitApp == false);
        }

        public void PerformOperationOfChoice(string inputOperationAsString)
        {
            int inputOperation;
            bool inputIsNr = int.TryParse(inputOperationAsString, out inputOperation);

            if (inputIsNr && (inputOperation >= 0) && (inputOperation <= 9))
            {
                switch (inputOperation)
                {
                    case 0:
                        Console.WriteLine("Saving file...");
                        CreateFileWithCurrentBankInfo();
                        break;

                    case 1:
                        Console.WriteLine("> 1");
                        Console.WriteLine("*Search for customer*");
                        SearchForCustomer();
                        break;

                    case 2:
                        Console.WriteLine("> 2");
                        Console.WriteLine("*Show customer*");
                        ShowCustomer();
                        break;

                    case 3:
                        Console.WriteLine("> 3");
                        Console.WriteLine("*Create new customer*");
                        Console.WriteLine();
                        CreateNewCustomer();
                        break;

                    case 4:
                        Console.WriteLine("> 4");
                        Console.WriteLine("*Delete customer*");
                        Console.WriteLine();
                        DeleteCustomer();
                        break;

                    case 5:
                        Console.WriteLine("> 5");
                        Console.WriteLine("*Create new account*");
                        Console.WriteLine();
                        Console.Write("Customer number:            ");
                        int customerNumber = int.Parse(Console.ReadLine());
                        CreateNewAccount(customerNumber);
                        break;

                    case 6:
                        Console.WriteLine("> 6");
                        Console.WriteLine("*Delete account*");
                        Console.WriteLine();
                        DeleteAccount();
                        break;

                    case 7:
                        Console.WriteLine("> 7");
                        Console.WriteLine("*Deposit*");
                        Console.WriteLine();
                        Deposit();
                        break;

                    case 8:
                        Console.WriteLine("> 8");
                        Console.WriteLine("*Withdrawl*");
                        Console.WriteLine();
                        Withdrawl();
                        break;

                    case 9:
                        Console.WriteLine("> 9");
                        Console.WriteLine("*Transfer*");
                        Console.WriteLine();
                        Transfer();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
            Console.WriteLine();
            Console.Write("Would you like to get back to the main menu? (yes/no) ");
            string answer = Console.ReadLine();

            if (answer == "no".ToLower())
            {
                CreateFileWithCurrentBankInfo();
                wantToExitApp = true;
                Console.WriteLine("Your changes have been saved");
                Console.Write("Press enter to exit");
            }
            else if (answer == "yes".ToLower())
            {
                Console.WriteLine();
                Console.WriteLine();
                wantToExitApp = false;
                ShowMainMenu();
            }
        }

        public void SearchForCustomer()
        {
            Console.Write("Name or area name of customer: ");
            string userInput = Console.ReadLine();

            Console.WriteLine();
            var searchResult = customerList.FindAll(customer => (customer.CompanyName.ToLower().Contains(userInput.ToLower()) || customer.Region.ToLower().Contains(userInput.ToLower())));

            foreach (var customer in searchResult)
            {
                Console.WriteLine("{0}: {1}", customer.CustomerNumber, customer.CompanyName);
            }
        }

        public void ShowCustomer()
        {
            Console.Write("Customer number: ");
            string str = Console.ReadLine();

            Console.WriteLine();
            var searchResultCustomer = customerList.FindAll(customer => customer.CustomerNumber.ToString().Contains(str));

            foreach (var customer in searchResultCustomer)
            {
                Console.WriteLine("Customer number: {0}", customer.CustomerNumber);
                Console.WriteLine("Orgnr:           {0}", customer.OrgNumber);
                Console.WriteLine("Name:            {0}", customer.CompanyName);
                Console.WriteLine("Address:         {0}, {1}, {2}", customer.Address, customer.PostalNumber, customer.Region);

                var searchResultAccount = accountList.FindAll(account => account.CustomerNumberOfAccount.ToString().Contains(customer.CustomerNumber.ToString()));
                Console.WriteLine();
                foreach (var account in searchResultAccount)
                {
                    Console.WriteLine("{0}: {1} SEK", account.AccountNumber.ToString(), account.BalanceOfAccount);
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        public void CreateNewCustomer()
        {
            Customer customer = new Customer();

            CollectCustomerData(customer);
            Console.WriteLine();

            Console.Write("Is this correct? ");
            Console.WriteLine();
            PrintEnteredCustomerData(customer);

            Console.WriteLine();
            Console.Write("(yes/no): ");
            string answer = Console.ReadLine();

            Console.WriteLine();

            if (answer == "yes".ToLower())
            {
                customerList.Add(customer);

                Console.WriteLine("These are your new account details: ");
                Console.WriteLine();
                CreateNewAccount(customer.CustomerNumber);
                Console.WriteLine();

                Console.WriteLine("Customer number: {0}", customer.CustomerNumber);
                PrintEnteredCustomerData(customer);
                Console.WriteLine();
                Console.WriteLine("The new account is now added to the system");
            }
            else
            {
                CreateNewCustomer();
            }
        }

        public void CollectCustomerData(Customer customer)
        {
            customer.CustomerNumber = CreateNewCustomerNumber();

            Console.Write("Org. number:         ");
            customer.OrgNumber = Console.ReadLine();

            Console.Write("Company name:        ");
            customer.CompanyName = Console.ReadLine();

            Console.Write("Address:             ");
            customer.Address = Console.ReadLine();

            Console.Write("City:                ");
            customer.City = Console.ReadLine();

            Console.Write("Region:              ");
            customer.Region = Console.ReadLine();

            Console.Write("Postal number:       ");
            customer.PostalNumber = Console.ReadLine();

            Console.Write("Country:             ");
            customer.Country = Console.ReadLine();

            Console.Write("Telephone:           ");
            customer.Telephone = Console.ReadLine();
        }

        public void PrintEnteredCustomerData(Customer customer)
        {
            Console.WriteLine("Orgnumber:     {0}", customer.OrgNumber);
            Console.WriteLine("Company name:  {0}", customer.CompanyName);
            Console.WriteLine("Address:       {0}", customer.Address);
            Console.WriteLine("City:          {0}", customer.City);
            Console.WriteLine("Region:        {0}", customer.Region);
            Console.WriteLine("Postal number: {0}", customer.PostalNumber);
            Console.WriteLine("Country:       {0}", customer.Country);
            Console.WriteLine("Telephone:     {0}", customer.Telephone);
        }

        public int CreateNewCustomerNumber()
        {
            int currentBiggestCustomerNumbers = 0;
            foreach (var customer in customerList)
            {
                if (customer.CustomerNumber > currentBiggestCustomerNumbers)
                {
                    currentBiggestCustomerNumbers = customer.CustomerNumber;
                }
            }
            return currentBiggestCustomerNumbers + 1;
        }

        public void DeleteCustomer()
        {
            Console.Write("Customer number you would like to delete: ");
            string customerNumberToDelete = Console.ReadLine();

            var searchResultAccount = accountList.FindAll(account => account.CustomerNumberOfAccount.ToString().Contains(customerNumberToDelete));
            foreach (var account in searchResultAccount)
            {
                if (account.BalanceOfAccount != 0)
                {
                    Console.WriteLine("Account {0} has {1} SEK - Only empty accounts can be deleted", account.AccountNumber, account.BalanceOfAccount);
                }
                else if (account.BalanceOfAccount == 0)
                {
                    Console.WriteLine("Account: {0} will be deleted", account.AccountNumber);
                    Console.Write("Are you sure? (yes/no) ");
                    string answerToDeleteAccountOrNot = Console.ReadLine();

                    if (answerToDeleteAccountOrNot == "yes".ToLower())
                    {
                        accountList.Remove(account);
                        Console.WriteLine();
                        Console.WriteLine("Account deleted");
                        Console.WriteLine();

                        //Bara ett - Räcker med Find
                        var searchResultCustomer = customerList.FindAll(customer => customer.CustomerNumber.ToString().Contains(customerNumberToDelete));
                        foreach (var customer in searchResultCustomer)
                        {
                            Console.WriteLine("Customer: {0} will be deleted", customer.CustomerNumber);
                            Console.Write("Are you sure? (yes/no) ");
                            string answerToDeleteCustomerOrNot = Console.ReadLine();

                            if (answerToDeleteCustomerOrNot == "yes".ToLower())
                            {
                                customerList.Remove(customer);
                                Console.WriteLine();
                                Console.WriteLine("Customer deleted");
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Customer not deleted");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Account has not been deleted");
                    }
                }
            }
        }

        public void CreateNewAccount(int customerNumber)
        {
            Account account = new Account();
            account.AccountNumber = CreateNewAccountNumber();
            account.CustomerNumberOfAccount = customerNumber;
            account.BalanceOfAccount = 0.0m;

            PrintAccountInfo(account);
            accountList.Add(account);
        }

        public int CreateNewAccountNumber()
        {
            int currentBiggestValueOfAccountNumbers = 0;

            foreach (var account in accountList)
            {
                if (account.AccountNumber > currentBiggestValueOfAccountNumbers)
                {
                    currentBiggestValueOfAccountNumbers = account.AccountNumber;
                }
            }
            return currentBiggestValueOfAccountNumbers + 1;
        }

        public void PrintAccountInfo(Account account)
        {
            Console.WriteLine("Account number:             {0}", account.AccountNumber);
            Console.WriteLine("Customer number of account: {0}", account.CustomerNumberOfAccount);
            Console.WriteLine("Balance of account:         {0} SEK", account.BalanceOfAccount);
        }

        public void DeleteAccount()
        {
            Console.Write("Account number you would like to delete: ");
            string accountNumberToDelete = Console.ReadLine();

            var searchResultAccount = accountList.FindAll(account => account.AccountNumber.ToString().Contains(accountNumberToDelete));
            foreach (var account in searchResultAccount)
            {
                if (account.BalanceOfAccount != 0)
                {
                    Console.WriteLine("Only empty account can be deleted");
                }
                else
                {
                    Console.Write("Account: {0} will be deleted", account.AccountNumber);
                    Console.Write("Are you sure? (yes/no) ");
                    string answerToDeleteOrNot = Console.ReadLine();

                    if (answerToDeleteOrNot == "yes".ToLower())
                    {
                        accountList.Remove(account);
                        Console.WriteLine("Account deleted");
                    }
                    else
                    {
                        Console.WriteLine("Account has not been deleted");
                    }
                }
            }
        }

        public void Deposit()
        {
            Console.Write("Account you would like to add money to: ");
            string inputAccount = Console.ReadLine();

            Account searchResultAccount = accountList.Find(account => account.AccountNumber.ToString().Contains(inputAccount));

            Console.Write("Amount you would like to add: ");
            string inputAmount = Console.ReadLine();
            decimal amountToDeposit = decimal.Parse(inputAmount);

            if (amountToDeposit > totalBalanceOfBank)
            {
                Console.WriteLine();
                Console.WriteLine("The amount you are trying to deposit is too big");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Balance before deposit: {0} SEK", searchResultAccount.BalanceOfAccount);
                searchResultAccount.BalanceOfAccount += amountToDeposit;
                Console.WriteLine("Balance is now {0} SEK", searchResultAccount.BalanceOfAccount);
            }
        }

        public void Withdrawl()
        {
            Console.Write("Account you would like to take out money from: ");
            string accountFrom = Console.ReadLine();

            var searchResultAccount = accountList.FindAll(account => account.AccountNumber.ToString().Contains(accountFrom));

            bool acceptedAmountToDeposit = false;

            while (!acceptedAmountToDeposit)
            {
                Console.Write("Amount you would like to withdraw: ");
                string str = Console.ReadLine();
                decimal amountToWithdraw;
                bool inputIsNr = decimal.TryParse(str, out amountToWithdraw);

                if (inputIsNr)
                {
                    foreach (var account in searchResultAccount)
                    {
                        if (account.BalanceOfAccount < amountToWithdraw)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Your balance is lower than the amount you are trying to deposit");
                            Console.WriteLine("You have {0} SEK", account.BalanceOfAccount);
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Balance before withdrawl: {0} SEK", account.BalanceOfAccount);
                            account.BalanceOfAccount -= amountToWithdraw;
                            Console.WriteLine("Balance after withdrawl:  {0} SEK", account.BalanceOfAccount);
                            acceptedAmountToDeposit = true;
                        }
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Incorrect input");
                    Console.WriteLine();
                }
            }
        }

        public void Transfer()
        {
            CollectingInfoToTransfer();

            var searchResultAccountTakesFrom = accountList.FindAll(accountTakeFrom => accountTakeFrom.AccountNumber.ToString().Contains(inputAccountTransferFrom));
            var searchResultAccountTransferTo = accountList.FindAll(accountGiveTo => accountGiveTo.AccountNumber.ToString().Contains(inputAccountTransferTo));

            foreach (var account in searchResultAccountTakesFrom)
            {
                if (account.BalanceOfAccount < decimal.Parse(amountToTransfer))
                {
                    Console.WriteLine();
                    Console.WriteLine("The amount you are trying to transfer is too high");
                    Console.Write("Would you like to try a lower amount? (yes/no) ");
                    Console.WriteLine();
                    string answer = Console.ReadLine();

                    if (answer == "no".ToLower())
                    {
                        Console.WriteLine();
                        Console.WriteLine("No money will be transferred");
                        break;
                    }
                    else
                    {
                        Transfer();
                    }
                }
                else if (account.BalanceOfAccount == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Account you are trying to transfer from is empty!");
                    break;
                }
                else
                {
                    foreach (var accountFrom in searchResultAccountTakesFrom)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Account {0} before transfer: {1} SEK", accountFrom.AccountNumber, accountFrom.BalanceOfAccount);
                        accountFrom.BalanceOfAccount -= decimal.Parse(amountToTransfer);
                        Console.WriteLine("Account {0} now has:         {1} SEK", accountFrom.AccountNumber, accountFrom.BalanceOfAccount);
                    }

                    foreach (var accountTo in searchResultAccountTransferTo)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Account {0} before transfer: {1} SEK", accountTo.AccountNumber, accountTo.BalanceOfAccount);
                        accountTo.BalanceOfAccount += decimal.Parse(amountToTransfer);
                        Console.WriteLine("Account {0} now has:         {1} SEK", accountTo.AccountNumber, accountTo.BalanceOfAccount);
                    }
                }
            }
        }

        public void CollectingInfoToTransfer()
        {
            Console.Write("Account you would like to transfer money from: ");
            inputAccountTransferFrom = Console.ReadLine();

            Console.Write("Account you would like to transfer to:         ");
            inputAccountTransferTo = Console.ReadLine();

            Console.Write("Amount you would like to transfer:             ");
            amountToTransfer = Console.ReadLine();
        }

        public void CreateFileWithCurrentBankInfo()
        {
            var fileName = "C:\\Users\\Olivia\\Desktop\\Inlämning 3 - BANK\\" + DateTime.Now.ToString("yyyyMMdd-HHmm") + ".txt";

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(customerList.Count());
                foreach (var customer in customerList)
                {
                    writer.Write("{0};", customer.CustomerNumber);
                    writer.Write("{0};", customer.OrgNumber);
                    writer.Write("{0};", customer.CompanyName);
                    writer.Write("{0};", customer.Address);
                    writer.Write("{0};", customer.City);
                    writer.Write("{0};", customer.Region);
                    writer.Write("{0};", customer.PostalNumber);
                    writer.Write("{0};", customer.Country);
                    writer.WriteLine("{0};", customer.Telephone);
                }
                writer.WriteLine(accountList.Count());
                foreach (var account in accountList)
                {
                    writer.Write("{0};", account.AccountNumber);
                    writer.Write("{0};", account.CustomerNumberOfAccount);
                    writer.WriteLine("{0};", account.BalanceOfAccount.ToString(CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
