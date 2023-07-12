using Specifications;
namespace CRM
{
     
    public class Service : ISellable
    {
        public string  name;
        public string provider;
        public bool isSubscribed;

        public Service()
        {
        }

        public Service(string name, string provider, bool status)
        {
            this.name=name;
            this.provider=provider;
            this.isSubscribed=status;
        }

        void ISellable.Sell(){
        Console.WriteLine("Service is subscribed by consumer");
        Console.WriteLine("Service is available to consumer");   
        }

        void ISellable.Promote(){   
            Console.WriteLine("Service is published");
        }

        void ISellable.Test(){
            Console.WriteLine("Service is verfied....");
        }

    }
}