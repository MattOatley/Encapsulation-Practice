using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            Console.WriteLine("Please enter the amount of $ you would like to deposit");
            double depositAmount = double.Parse(Console.ReadLine());

            account.Deposit(depositAmount);
            double accountBalance = account.GetBalance();

            Console.WriteLine($"Your balance is now {accountBalance, 0:C}");

        }
    }
   
}
