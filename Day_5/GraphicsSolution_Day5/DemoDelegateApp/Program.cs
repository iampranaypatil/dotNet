
using DemoDelegateApp;

Console.WriteLine("Hello, World!");

TaxManager taxManager = new TaxManager();

//Static linking
taxManager.PayIncomeTax();
taxManager.PayServiceTax();

//Dynamic linking
TaxOperation operation1 = new TaxOperation(taxManager.PayIncomeTax);
operation1();
