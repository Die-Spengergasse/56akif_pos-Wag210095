using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Spengershop.Domain.Model
{
    public class ShoppingCart
    {
        public int Id { get; set; } //muss PK
        public int ItemsCount { get; }
     
        public Customer CustomerNavigation { get; set; } = default!; //Shoppingcart gehört einem Customer, Customer kann mehrere Shoppingcarts haben für Status (Historisierung)
        public List<ShoppingCartItem> ShoppingCartItems { get; set; } = new List<ShoppingCartItem>();
    }
}
