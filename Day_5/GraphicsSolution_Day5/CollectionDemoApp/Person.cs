using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemoApp
{
    public class Person:IComparable
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get;set; } = string.Empty;
        public int Age { get;set;} = 0;
        public int Wealth { get;set;} = 0;

        public int CompareTo(object? obj)
        {
            Person secondPerson= obj as Person ;
            if (this.Age < secondPerson.Age)
            {
                return 1;
            }
            else
                return -1;
            
            
           
        }
    }
}
