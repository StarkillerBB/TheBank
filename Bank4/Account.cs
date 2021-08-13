using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank4
{

    enum AccountType
    {
        CheckingAccount,
        SavingsAccount,
        MasterCardAccount
    }
    abstract class Account
    {

        public int AccountNumber { get; set; }
        public string name { get; set; }
        public decimal balance { get; set; }
        public int AccountNumberCounter { get; set; }
        public AccountType AccountType { get; set; }

        public abstract void ChargeInterest();

    }

    class CheckingAccount : Account
    {
        public CheckingAccount(string name, int AccountNumber)
        {
            this.name = name;
            this.AccountNumber = AccountNumber;
        }

        public override void ChargeInterest()
        {
            this.balance = this.balance * 1.05M;
        }
    }

    class SavingsAccount : Account
    {

        public SavingsAccount(string name, int AccountNumber)
        {
            this.name = name;
            this.AccountNumber = AccountNumber;
        }

        public override void ChargeInterest()
        {
            if (balance < 50000)
            {
                balance = balance * 1.01M;
            }
            else if (balance < 100000)
            {
                balance = balance * 1.02M;
            }
            else if (balance >= 100000)
            {
                balance = balance * 1.03M;
            }


        }

    }

    class MasterCardAccount : Account
    {
        public MasterCardAccount(string name, int AccountNumber)
        {
            this.name = name;
            this.AccountNumber = AccountNumber;
        }

        public override void ChargeInterest()
        {

            if (this.balance > 0)
            {
                this.balance = this.balance * 1.001M;
            }
            else if (this.balance < 0)
            {
                this.balance = this.balance * 1.20M;
            }

        }
    }
}
