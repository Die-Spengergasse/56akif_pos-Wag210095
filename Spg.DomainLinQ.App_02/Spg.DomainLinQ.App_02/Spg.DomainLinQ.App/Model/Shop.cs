using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * Name
    /// * Department [Die ersten 3 Zeichen von Name]
    /// * Guid
    /// (4P)
    /// </summary>
    public class Shop : EntityBase
    {
        //TODO: Implementation
        public string Name { get; set; } = string.Empty;
        public string Department => Name.Substring(0, 3);
        public Guid Guid { get; set; }

        private List<User> _users { get; set; } = new();
        public virtual IReadOnlyList<User> Users => _users;

        private List<Product> _products { get; set;} = new();
        public virtual IReadOnlyList<Product> Products => _products;

        public DateTime? LastChangeDate { get;  set; }

        public Shop() { }
        public Shop(string name,  Guid guid)
        {
            Name = name;
            Guid = guid;
        }

    }
}
