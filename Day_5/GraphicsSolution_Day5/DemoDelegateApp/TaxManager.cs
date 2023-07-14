using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegateApp
{
    public class TaxManager
    {
        public void PayIncomeTax()
        {
            Console.WriteLine("15% Income tax is deducted from your salary");

        }
        public void PayServiceTax()
        {
            Console.WriteLine("20% Service tax is deducted from Service Charges");
        }

        public void ProfessionalTax()
        {
            Console.WriteLine("10% Service tax is deducted from Service Charges");
        }

        public void PaySalesTax() {

            Console.WriteLine("3% Service tax is deducted from Service Charges");
        }
    }
    }
}
