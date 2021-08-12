using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank2
{
    class Account
    {

        public int AccountNumber { get; }
        public string name {get;}
        public decimal balance { get; set; }
        public int AccountNumberCounter { get; set; }


        public Account(string name, int acc)
        {
            this.name = name;
            this.AccountNumber = acc;
            balance = 0;

        }

    }
}
