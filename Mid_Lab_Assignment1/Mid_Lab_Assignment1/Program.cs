using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Lab_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bankObject1 = new Bank();
            bankObject1.BankName = "BENGAL BANK LIMITED";

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("         Welcome to BENGAL BANK LIMITED      ");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            bool value = true;

            while (value)
            {
                Console.WriteLine("***************** MAIN MENU *****************");
                Console.WriteLine("**         1. Add Account                  **");
                Console.WriteLine("**         2. Delete Account               **");
                Console.WriteLine("**         3. Transaction                  **");
                Console.WriteLine("**         4. Display Account information  **");
                Console.WriteLine("**         5. Exit                         **");
                Console.WriteLine("*********************************************");
                Console.Write("Your Option :: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Account account1 = new Account(new Address());
                        Console.Write("Enter New Account Name : ");
                        account1.AccountName = Console.ReadLine();
                        Console.Write("Enter Balance : ");
                        account1.Balance = Convert.ToDouble(Console.ReadLine());
                        bankObject1.AddAccount(account1);
                        break;

                    case 2:
                        Console.WriteLine("Enter Account number to Delete :");
                        int deleteAccountNumber = Convert.ToInt32(Console.ReadLine());
                        bankObject1.DeleteAccount(deleteAccountNumber);
                        break;

                    case 3:
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("                Transaction                  ");
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("                1. Deposit                   ");
                        Console.WriteLine("                2. Withdraw                  ");
                        Console.WriteLine("                3. Transfer                  ");
                        Console.WriteLine("---------------------------------------------");

                        Console.Write("Your Option :: ");
                        int choice2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Input Amount:");

                        double amount = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Input Account Number:");

                        int senderAccountNumber = Convert.ToInt32(Console.ReadLine());
                        bankObject1.Transaction(choice2, senderAccountNumber, amount);
                        break;

                    case 4:
                        Console.WriteLine("Displaying All the Bank Accounts Details...");
                        bankObject1.PrintAccountDetails();
                        break;

                    case 5:
                        value = false;
                        break;

                    default:
                        Console.WriteLine("--- Invalid Choice ---");
                        break;
                }
            }

        }
    }
}
