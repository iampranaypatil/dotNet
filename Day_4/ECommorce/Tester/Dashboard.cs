using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    //Explicit Interface Inheritance
    //Multiple Interface Inheritance
    internal class Dashboard : ICustomerDetails, IOrderDetails,IDisposable
    {
        #region Data Members
        private int financialYear;
        private string department;
        private bool disposedValue;
        #endregion
        #region Property syntax
        public int FinancialYear
        {
            get
            {
                return this.financialYear;
            }
            set
            {
                this.financialYear = value;
            }
        }
        #endregion
        #region Member functions
        public Dashboard() { }
        public Dashboard(int year, string dept)
        {
            this.financialYear = year;
            this.department = dept;
        }
        #endregion

        void ICustomerDetails.ShowDetails() {
            Console.WriteLine(" Customer Details Presenting....");
        
        }

        void IOrderDetails.ShowDetails()
        {
            Console.WriteLine(" Order Details Presenting....");

        }



        ~Dashboard()
        {
            //auto clean up 

            //relase resources before object goes out memory
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~Dashboard()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
