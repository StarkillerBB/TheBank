using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank1
{
    class Bank
    {
        Account account;

        public string bankName {get;}

        public Bank(string bankName)
        {
            this.bankName = bankName;
        }

        

        /// <summary>
        /// Creating account with inserted name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Account CreateAccount(string name)
        {

            account = new Account(name);

            return account;
        }

        /// <summary>
        /// Deposit money into an existing account
        /// </summary>
        /// <param name="balance"></param>
        /// <returns></returns>
        public string Deposit(decimal balance)
        {

            account.balance = account.balance + balance;

            return $"You deposited {balance}kr. Your new balance is {account.balance}kr.";
        }

        /// <summary>
        /// Withdraw money from an exisiting account
        /// </summary>
        /// <param name="balance"></param>
        /// <returns></returns>
        public string Withdrawl(decimal balance)
        {

            account.balance = account.balance - balance;

            return $"You withdrawed {balance}kr. Your new balance is {account.balance}kr.";
        }

        /// <summary>
        /// Return current amount of money in existing account.
        /// </summary>
        /// <returns></returns>
        public string Balance()
        {
            return $"Your balance is {account.balance}kr.";
        }

    }
}
