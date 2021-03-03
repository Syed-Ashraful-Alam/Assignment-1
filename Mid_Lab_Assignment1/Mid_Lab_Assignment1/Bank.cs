using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Lab_Assignment1
{
    class Bank
    {
        private string bankName;
        private Account[] myBank = new Account[5];

        public string BankName
        {
            get { return this.bankName; }
            set { this.bankName = value; }
        }

        public void AddAccount(Account account)
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    myBank[i] = account;
                    myBank[i].SystemGenerationOfAccountNumber();
              
                    Console.WriteLine("Enter New Account holder's address ::");
                    Console.Write("Road No : ");
                    myBank[i].Address.RoadNo = Console.ReadLine();
                    Console.Write("House No : ");
                    myBank[i].Address.HouseNo = Console.ReadLine();
                    Console.Write("City : ");
                    myBank[i].Address.City = Console.ReadLine();
                    Console.Write("Country : ");
                    myBank[i].Address.Country = Console.ReadLine();
                    Console.WriteLine("\nNew Account has been Created Successfully...\n");
                    break;
                }
            }
        }

        public void DeleteAccount(int accountNumber)
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i].AccountNumber == accountNumber)
                {
                    myBank[i] = null;

                    Console.WriteLine("\n The Account is Deleted.\n");

                    break;
                }
            }

        }
        public void Transaction(int choice, int tAccountNumber, double amount)
        {
            switch (choice)
            {
                case 1:

                    for (int i = 0; i < myBank.Length; i++)
                    {
                        if (myBank[i].AccountNumber == tAccountNumber)
                        {
                            myBank[i].Deposit(amount);
                            break;
                        }
                    }
                    break;

                case 2:

                    for (int i = 0; i < myBank.Length; i++)
                    {
                        if (myBank[i].AccountNumber == tAccountNumber)
                        {
                            myBank[i].Withdraw(amount);
                            break;
                        }
                    }
                    break;

                case 3:

                    Console.Write("Receiver Account Number : ");
                    int receiverAccountNumber = Convert.ToInt32(Console.ReadLine());
                    int index = 0;

                    for (int i = 0; i < myBank.Length; i++)
                    {
                        if (myBank[i].AccountNumber == receiverAccountNumber)
                        {
                            index = i;
                            break;
                        }

                    }

                    for (int i = 0; i < myBank.Length; i++)
                    {
                        if (myBank[i].AccountNumber == tAccountNumber)
                        {
                            myBank[i].Transfer(amount, myBank[index]);
                            break;
                        }
                    }

                    break;

                default:
                    Console.WriteLine("::: Invalid Choice :::");
                    break;
            }
        }

        public void PrintAccountDetails()
        {
            for (int i = 0; myBank[i] != null; i++)
            {
                myBank[i].ShowAccountInformation();
            } 
        }
    }
}
