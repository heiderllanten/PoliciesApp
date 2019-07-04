using PoliciesApp.Entities.Entities;
using PoliciesApp.Repositories.Infraestructure;
using System.Data.Entity;

namespace PoliciesApp.Repositories.Repositories
{
    public interface IPolicyRepository : IGenericRepository<Policy>
    { }

    public class PolicyRepository : GenericRepository<Policy>
    {
        public PolicyRepository(DbContext context) : base(context)
        {
        }
    }
}
