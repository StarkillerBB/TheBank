using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank4
{
    class Program
    {

        static Bank bank = new Bank("EUC Banken");
        static int accountNumber;
        static string accountName;
        //TODO: Make the user able to go back.
        static void Main(string[] args)
        {

            Menu();

            do
            {
                switch (Console.ReadKey(true).KeyChar)
                {

                    case '1':
                        bool ShouldLoop = true;

                        Console.Clear();
                        Console.WriteLine("Insert your name.");
                        accountName = Console.ReadLine();
                        AccountTypeMenu();

                        do
                        {


                            switch (Console.ReadKey(true).KeyChar)
                            {
                                case '1':
                                    Console.Clear();
                                    bank.CreateAccount(accountName, AccountType.CheckingAccount);
                                    Console.WriteLine(bank.returnValues);
                                    Console.WriteLine("\n Press any key to continue");
                                    Console.ReadKey();

                                    ShouldLoop = false;
                                    break;
                                case '2':
                                    Console.Clear();
                                    bank.CreateAccount(accountName, AccountType.SavingsAccount);
                                    Console.WriteLine(bank.returnValues);
                                    Console.WriteLine("\n Press any key to continue");
                                    Console.ReadKey();
                                    ShouldLoop = false;
                                    break;
                                case '3':
                                    Console.Clear();
                                    bank.CreateAccount(accountName, AccountType.MasterCardAccount);
                                    Console.WriteLine(bank.returnValues);
                                    Console.WriteLine("\n Press any key to continue");
                                    Console.ReadKey();

                                    ShouldLoop = false;
                                    break;
                                case '4':
                                    Console.WriteLine("\n Checking account type:\n En lønkonto, der giver 0,5 % p.a. i rente uanset indestående");
                                    Console.WriteLine("\n Savings account type:\n en opsparingskonto, der giver: \n1 % for indestående under kr. 50 000 \n2 % for indestående under kr. 100 000 \n3 % for indestående over kr. 100 000");
                                    Console.WriteLine("\n MasterCard account: \n en forbrugskonto, der giver 0,1 % i rente, men koster 20 % hvis den bliver negativ");

                                    ShouldLoop = true;
                                    break;
                                default:
                                    ShouldLoop = true;
                                    break;
                            }
                        } while (ShouldLoop);


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

                        break;

                    case '6':
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
            Console.WriteLine($"*** Welcome too {bank.bankName} ***");
            Console.WriteLine("Please choose one of the following:");
            Console.WriteLine("1. Create Account.");
            Console.WriteLine("2. Desposit money into your account.");
            Console.WriteLine("3. Withdraw money from your account.");
            Console.WriteLine("4. Display balance on your account.");
            Console.WriteLine("5. Charge interest");
            Console.WriteLine("6. Exit bank.");
        }

        public static void AccountTypeMenu()
        {

            Console.Clear();
            Console.WriteLine("Please choose one of the following account types:");
            Console.WriteLine("1. Checking account");
            Console.WriteLine("2. Saving account");
            Console.WriteLine("3. MasterCard account");
            Console.WriteLine("4. Display description");

        }
    }
}
