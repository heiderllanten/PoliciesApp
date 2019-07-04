using PoliciesApp.Entities.Entities;
using PoliciesApp.Repositories.Repositories;
using PoliciesApp.Services.Contract;
using System.Linq;
using System.Collections.Generic;

namespace PoliciesApp.Services.Implementation
{
    public class CoverageTypeService : ICoverageTypeService
    {
        private ICoverageTypeRepository coverageTypeRepository;

        public CoverageTypeService(ICoverageTypeRepository coverageTypeRepository)
        {
            this.coverageTypeRepository = coverageTypeRepository;
        }

        public List<CoverageType> GetAll()
        {
            return this.coverageTypeRepository.GetAll().ToList();
        }
    }
}
