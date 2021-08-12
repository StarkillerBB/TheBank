using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank1
{
    class Account
    {

        public string Name {get;}
        public decimal balance { get; set; }


        public Account(string name)
        {
            Name = name;
            balance = 0;
        }

    }
}
