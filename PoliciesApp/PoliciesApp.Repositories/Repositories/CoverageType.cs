using PoliciesApp.Entities.Entities;
using PoliciesApp.Repositories.Infraestructure;

namespace PoliciesApp.Repositories.Repositories
{
    public interface ICoverageTypeRepository : IGenericRepository<CoverageType>
    { }

    public class CoverageTypeRepository : GenericRepository<CoverageType>, ICoverageTypeRepository
    { }
}
