using System.Collections.Generic;

namespace PoliciesApp.Entities.Entities
{
    public class CoverageType
    {
        public int CoverageTypeId { get; set; }
        public string Description { get; set; }

        public virtual List<Policy> Policy { get; set; }
    }
}
