using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank4
{
    class Bank
    {
        

        List<Account> accountList = new List<Account>();

        int accountNumberCounter;
        public string returnValues { get; set; }
        public string bankName { get; }
        public decimal bankBalance { get; set; }
        public Account account { get; set; }

        public Bank(string bankName)
        {
            
            this.bankName = bankName;
            accountNumberCounter = 1;
        }


        //TODO : Add Enumerations
        /// <summary>
        /// Creating account with inserted name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string CreateAccount(string name, AccountType accType)
        {

            switch (accType)
            {
                case AccountType.CheckingAccount:
                    accountList.Add(new CheckingAccount(name, accountNumberCounter));
                    break;

                case AccountType.SavingsAccount:
                    accountList.Add(new SavingsAccount(name, accountNumberCounter));
                    break;

                case AccountType.MasterCardAccount:
                    accountList.Add(new SavingsAccount(name, accountNumberCounter));
                    break;
                default:
                    break;
            }

            account = FindAccount(accountNumberCounter);

            accountNumberCounter++;

            returnValues = $"Created account successfully. \n Account Name: {account.name} \n Account ID: {account.AccountNumber} (Make sure to write this down.) \n Account Type: {account.AccountType} \n Account Balance: {account.balance}";

            return returnValues;
        }

        /// <summary>
        /// Deposit money into an existing account
        /// </summary>
        /// <param name="balance"></param>
        /// <returns></returns>
        public string Deposit(decimal balance, int accountNumber)
        {

            account = FindAccount(accountNumber);

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

            account = FindAccount(accountNumber);

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

            account = FindAccount(accountNumber);

            if (account == null)
            {
                return "Account number does not exist.";
            }
            else
            {
                return $"Your balance is {account.balance}kr.";
            }

            
        }

        /// <summary>
        /// Running through List with accounts to find correct user.
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <returns></returns>
        public Account FindAccount(int accountNumber)
        {
            account = accountList.Find(a => a.AccountNumber == accountNumber);

            return account;
        }

        /// <summary>
        /// Adds interest to ALL accounts in the bank.
        /// </summary>
        public void ChargeInterest()
        {
            foreach (Account accounts in accountList)
            {
                accounts.ChargeInterest();
            }
        }

        //TODO : Pull balance from all users and add it to bankBalance.
        //public string BankBalance()
        //{
        //    return returnValues;
        //}
    }
}
