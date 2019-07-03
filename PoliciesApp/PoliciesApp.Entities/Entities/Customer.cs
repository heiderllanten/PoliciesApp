using System.Collections.Generic;

namespace PoliciesApp.Entities.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }

        public virtual List<Policy> Policies { get; set; }
    }
}
