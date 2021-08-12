using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank1
{
    class Program
    {

        static Bank bank = new Bank("EUC Banken");

        //TODO: Finish calling of methods.
        static void Main(string[] args)
        {
            
            
            

            Console.WriteLine("Insert your name.");
            bank.CreateAccount(Console.ReadLine());

            Console.WriteLine("Insert the amount of money you wish to deposit into your account.");
            bank.Deposit(Convert.ToDecimal(Console.ReadLine()));

            Console.WriteLine("Insert the amount of money you wish to withdraw from your account.");
            bank.Withdrawl(Convert.ToDecimal(Console.ReadLine()));


            bank.Balance();
            Console.WriteLine("Temp");

        }

        //TODO : Make people able to use 2,3,4 without having an account. Give them prompt to create account.
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine($"*** Velkommen til {bank.bankName} ***");
            Console.WriteLine("Please choose one of the following:");
            Console.WriteLine("1. Create Account.");
            Console.WriteLine("2. Desposit money into your account.");
            Console.WriteLine("3. Withdraw money from your account.");
            Console.WriteLine("4. Display balance on your account.");
            Console.WriteLine("5. Exit bank.");

        }
    }
}
