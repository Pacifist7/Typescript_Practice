using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircus
{
    public class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; set; }

        public SavingsAccount (string accountNum, decimal balance, string customerName, string customerAddress, decimal interestRate) : base(accountNum, balance, customerName, customerAddress)
        {
            this.InterestRate = interestRate;
        }
    }
}
