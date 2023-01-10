using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * PriceGross (wird durch PriceNet und Tax ermittelt)
    /// * PriceNett
    /// * Tax
    /// * Created
    /// * Guid
    /// (4P)
    /// </summary>
    public class Price : EntityBase
    {
        // TODO: Implementation
        private decimal _priceGross;
        public decimal PriceGross { get => _priceGross;
            set {

                _priceGross = PriceNett * Tax;
            } }
        public decimal PriceNett { get; set; }
        public int Tax { get; set; }
        public DateTime Created { get; set; }
        public Guid Guid { get; set; }

        public int ProductNavigationId { get; set; }
        public Product ProductNavigation { get; set; } = default!;
        public DateTime? LastChangeDate { get;  set; }

        public Price()
        { }

        public Price(decimal priceGross, int tax, DateTime created, Guid guid, Product productNavigation)
        {
            PriceGross = priceGross;
            Tax = tax;
            Created= created;
            Guid = guid;
            ProductNavigation = productNavigation;
        }


    }
}
