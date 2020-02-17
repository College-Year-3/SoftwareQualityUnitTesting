using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class BankAccount
    {
        private static int accountNumber = 0;
        public string AccountCode { get; private set; }
        public decimal Balance { get; protected set; }

        public BankAccount()
        {
            AccountCode = "AC" + accountNumber.ToString();
            accountNumber++;
            Balance = 0;
        }

        public decimal LodgeFunds(decimal amount)
        {
            Balance += amount;
            return Balance;
        }

        public virtual decimal WithdrawFunds(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                return amount;
            }
            return 0;
        }
        public override string ToString()
        {
            return "Account Code = " + AccountCode + "  Balance = " + Balance.ToString();
        }

    }

}
