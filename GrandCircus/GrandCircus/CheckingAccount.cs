using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircus
{
    public class CheckingAccount : BankAccount
    {
        public decimal OverdraftFee { get; set; }
    }
}
