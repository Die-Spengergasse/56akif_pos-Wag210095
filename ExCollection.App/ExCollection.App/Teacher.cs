using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExCollection.App
{
    public class Teacher : Person
    {
        public override string GetArrivalType()
        {
            return "reist mit dem Auto an";
        }
        public string FullName
        {
            get
            {
                return $"Full Name: {FirstName} - {LastName} (Teacher)";
            }
        }

    }
}
