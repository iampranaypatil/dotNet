using Banking;
using TaxHandlers;

Account acct = new Account();
TaxManager manager = new TaxManager();

//Attach event handler with event
acct.overBalance += manager.PayIncomeTax;
acct.overBalance += manager.PayServiceTax;

acct.Balance = 78000;
//acct.Deposit(150000);
acct.Deposit(400000);
acct.overBalance -= manager.PayServiceTax;
acct.Deposit(400000);


double currentBalance =acct.Balance;
Console.WriteLine("Balance={0}", currentBalance);