﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank2
{
    class Bank
    {

        List<Account> accountList = new List<Account>();

        int accountNumberCounter;
        public string returnValues { get; set; }
        public string bankName { get; }
        public decimal bankBalance { get; set; }

        public Bank(string bankName)
        {
            
            this.bankName = bankName;
            accountNumberCounter = 1;
        }



        /// <summary>
        /// Creating account with inserted name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public void CreateAccount(string name)
        {
            
            accountList.Add(new Account(name, accountNumberCounter));

            accountNumberCounter++;
        }

        /// <summary>
        /// Deposit money into an existing account
        /// </summary>
        /// <param name="balance"></param>
        /// <returns></returns>
        public string Deposit(decimal balance, int accountNumber)
        {

            Account account = FindAccount(accountNumber);

            if (account == null)
            {
                return "Account number does not exist.";
            }
            else
            {

                bankBalance = bankBalance + balance;
                account.balance = account.balance + balance;

                returnValues = $"You deposited {balance}kr. Your new balance is {account.balance}kr.";

                return returnValues;
            }

            
        }

        /// <summary>
        /// Withdraw money from an exisiting account
        /// </summary>
        /// <param name="balance"></param>
        /// <returns></returns>
        public string Withdrawl(decimal balance, int accountNumber)
        {

            Account account = FindAccount(accountNumber);

            if (account == null)
            {
                return "Account number does not exist.";
            }
            else
            {
                bankBalance = bankBalance - balance;
                account.balance = account.balance - balance;

                returnValues = $"You withdrawed {balance}kr. Your new balance is {account.balance}kr.";

                return returnValues;
            }

            
        }

        /// <summary>
        /// Return current amount of money in existing account.
        /// </summary>
        /// <returns></returns>
        public string Balance(int accountNumber)
        {

            Account account = FindAccount(accountNumber);

            if (account == null)
            {
                return "Account number does not exist.";
            }
            else
            {
                return $"Your balance is {account.balance}kr.";
            }

            
        }


        public Account FindAccount(int accountNumber)
        {
            Account accounts = accountList.Find(a => a.AccountNumber == accountNumber);

            return accounts;
        }

        //TODO : Pull balance from all users and add it to bankBalance.
        //public string BankBalance()
        //{
        //    return returnValues;
        //}
    }
}
