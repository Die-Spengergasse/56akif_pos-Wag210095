using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * Description (PK)
    /// * Ean13;
    /// * Stock;
    /// * ExpiryDate;
    /// * DeliveryDate;
    /// * Price;
    /// * ShopNavigation
    /// (4P)
    /// </summary>
    public class Product : EntityBase
    {
        // TODO: Implementation


        public string Description { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public string Ean13 { get; set; } = string.Empty;
        public int Stock { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public Price price { get; set; }
        public int ShopNavigationId { get; set; }
        public Shop ShopNavigation { get; set; } = default!;
        public List<User> user = new();
        public List<Supplier> supplier = new();
        public List<Price> priceList = new();

        public Product()
        {

        }
        public Product( string productName, string ean13, int stock, DateTime? expiryDate, DateTime? deliveryDate, Shop shopNavigation)
        {
            
            ProductName = productName;
            Ean13 = ean13;
            Stock = stock;
            ExpiryDate = expiryDate;
            DeliveryDate = deliveryDate;
            ShopNavigation = shopNavigation;


        }
    }
}
