﻿using System;
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

    }
}
