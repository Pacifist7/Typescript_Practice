using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit4_Inheritance
{
    public class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; set; }

        public override bool WithdrawMoney(decimal amount)
        {


            //do special logic for checking account here
            return base.WithdrawMoney(amount); //default
        }
    }
}
