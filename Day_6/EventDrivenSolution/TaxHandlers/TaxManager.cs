namespace TaxHandlers
{
    public class TaxManager
    {

        public double  PayIncomeTax(double amount)
        {
            Console.WriteLine("Income tax is getting deducted....");
            //20% deduction from existing amount;
            //return 56000;
            double factor = 0.8;
            return (amount * factor);
        }

        public double PayServiceTax(double amount)
        {
            Console.WriteLine("Service tax is getting deducted....");
            //18% deduction from existing amount;
            double factor = .82;
            return (amount * factor);
        }


    }
}