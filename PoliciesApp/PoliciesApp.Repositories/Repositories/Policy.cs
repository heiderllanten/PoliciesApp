using PoliciesApp.Entities.Entities;
using PoliciesApp.Repositories.Infraestructure;

namespace PoliciesApp.Repositories.Repositories
{
    public interface IPolicyRepository : IGenericRepository<Policy>
    { }

    public class PolicyRepository : GenericRepository<Policy>, IPolicyRepository
    { }
}
