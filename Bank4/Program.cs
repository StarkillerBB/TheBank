using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank2
{
    class Program
    {

        static Bank bank = new Bank("EUC Banken");
        static int accountNumber;
        //TODO: Finish calling of methods.
        static void Main(string[] args)
        {

            Menu();

            do
            {
                switch (Console.ReadKey(true).KeyChar)
                {

                    case '1':
                        Console.Clear();
                        Console.WriteLine("Insert your name.");
                        bank.CreateAccount(Console.ReadLine());

                        break;

                        //TODO : Fix crash by checking if user is created case 2,3,4.
                    case '2':
                        Console.Clear();
                        Console.WriteLine("Please insert the ID number of your account.");
                        int.TryParse(Console.ReadLine(), out accountNumber);
                        Console.WriteLine("Insert the amount of money you wish to deposit into your account.");
                        bank.Deposit(Convert.ToDecimal(Console.ReadLine()), accountNumber);
                        Console.WriteLine(bank.returnValues);

                        break;

                    case '3':
                        Console.Clear();
                        Console.WriteLine("Please insert the ID number of your account.");
                        int.TryParse(Console.ReadLine(), out accountNumber);
                        Console.WriteLine("Insert the amount of money you wish to withdraw from your account.");
                        bank.Withdrawl(Convert.ToDecimal(Console.ReadLine()), accountNumber);
                        Console.WriteLine(bank.returnValues);

                        break;

                    case '4':
                        Console.Clear();
                        Console.WriteLine("Please insert the ID number of your account.");
                        int.TryParse(Console.ReadLine(), out accountNumber);
                        Console.WriteLine($"Your balance is: {bank.Balance(accountNumber)}");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();

                        break;

                    case '5':
                        Environment.Exit(0);
                        break;

                    default:
                        break;
                }
                Menu();

            } while (true);
            

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
