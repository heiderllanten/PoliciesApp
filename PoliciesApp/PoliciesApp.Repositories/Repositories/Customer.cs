using PoliciesApp.Entities.Entities;
using PoliciesApp.Repositories.Infraestructure;
using System.Data.Entity;

namespace PoliciesApp.Repositories.Repositories
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    { }

    public class CustomerRepository : GenericRepository<Customer>
    {
        public CustomerRepository(DbContext context) : base(context)
        {
        }
    }
}
