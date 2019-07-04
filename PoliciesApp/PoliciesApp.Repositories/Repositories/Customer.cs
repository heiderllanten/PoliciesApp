using PoliciesApp.Entities.Entities;
using PoliciesApp.Repositories.Infraestructure;

namespace PoliciesApp.Repositories.Repositories
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    { }

    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    { }
}
