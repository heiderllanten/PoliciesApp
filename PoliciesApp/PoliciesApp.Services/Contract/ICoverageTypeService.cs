using PoliciesApp.Entities.Entities;
using System.Collections.Generic;

namespace PoliciesApp.Services.Contract
{
    public interface ICoverageTypeService
    {
        List<CoverageType> GetAll();
    }
}
