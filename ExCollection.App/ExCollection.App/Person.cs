using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExCollection.App
{
    public abstract class Person
    {
        public abstract string GetArrivalType();
        public string  FirstName { get; set; }
        public string?  LastName { get; set; }
        public string FullName
        {

            get
            {
                return $"Full Name: {LastName} {FirstName}";
            }

        }       
    }
}
