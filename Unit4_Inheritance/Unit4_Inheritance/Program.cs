using Unit4_Inheritance;

CheckingAccount cAccount = new CheckingAccount();
cAccount.Balance = 100m;
cAccount.OverDraftFee = 35;
cAccount.WithdrawMoney(2.5m);

SavingsAccount sAccount = new SavingsAccount();
sAccount.Balance = 200;
sAccount.InterestRate = 3.5m;
sAccount.WithdrawMoney(10m);
