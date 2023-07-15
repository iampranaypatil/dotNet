using CorporatePolicy;
namespace Banking
{
    public class Account
    {
        public double Balance { get;set; }
        public event TaxHandler overBalance;

        public void Withdraw(double amount)
        {
            this.Balance = this.Balance-amount;
        }

        public void Deposit(double amount)
        {
            this.Balance = this.Balance + amount;
            if(this.Balance >= 250000) {
                //trigger an event
                this.Balance=overBalance(this.Balance);

            }
        }

    }
}