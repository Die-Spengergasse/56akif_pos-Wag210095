using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * RegistrationNumber (PK)
    /// * FirstName
    /// * LastName
    /// * EMail
    /// * BillingAddress
    /// * BusinessAddress
    /// * AccountName = [Die ersten 5 Stellen des LastName + RegistrationNumber]
    /// * Gender
    /// * Guid
    /// (4P)s
    /// </summary>
    public class User : EntityBase
    {
        // TODO: Implementation
        public int RegistrationNumber { get; set; }
        public Guid Guid { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string EMail { get; set; } = string.Empty;
        public Genders Gender { get; set; }
        public Address BillingAddress { get; set; } = default!;
        public Address BusinessAddress { get; set; } = default!;
        public string AccountName => $"{LastName.Substring(0, 5)}{RegistrationNumber}";
        public int ShopNavigationId { get; set; }
        public Shop ShopNavigation { get; set; } = default!;

        private List<Product> _products = new();
        public virtual IReadOnlyList<Product> Products => _products;

        public User()
        {

        }
        public User(int registrationNumber, Guid guid, string firstname, string lastname, string email, Genders gender,Shop shopNavigation, Address billingaddress, Address businessAddress)
        {
            RegistrationNumber = registrationNumber;
            Guid = guid;
            FirstName = firstname;
            LastName = lastname;
            EMail= email;
            Gender = gender;
            BillingAddress = billingaddress;
            BusinessAddress = businessAddress;

        }

        public void AddProduct(List<Product> product)
        {
            _products.AddRange(product);
        }
    }
}
