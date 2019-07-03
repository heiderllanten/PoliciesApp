using PoliciesApp.Entities.Entities;
using System.Data.Entity;

namespace PoliciesApp.Entities.Context
{
    public class PoliciesContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Policy> Policies { get; set; }
        public DbSet<CoverageType> Coverages { get; set; }
    }
}
