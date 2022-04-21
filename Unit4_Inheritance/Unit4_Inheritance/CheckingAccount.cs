using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit4_Inheritance
{
    public class CheckingAccount : BankAccount
    {
        public decimal OverDraftFee { get; set; }

        public override bool WithdrawMoney(decimal amount)
        {
            if (OverDraftFee > 0)
            {
                Console.WriteLine("Sorry you have an overdraft fee");
                return false;
            }
            else
            {
                Balance -= amount;
                Console.WriteLine("Successful");
                return true;
            }
        }
    }
}
