using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Spengershop.Domain.Model
{   public enum Genders { Male = 0, Female = 1, Other = 2 }

    public class Customer{
        

        public string CustomerNumber { get; set; } = string.Empty; //muss PK
        public Genders Gender { get; set; }
        public string Firstname { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public string EMail     { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; } = DateTime.MinValue;
        public DateTime RegistrationDateTime { get; set; }
        public List<ShoppingCart> ShoppingCarts { get; set; } = new();
    }
}
