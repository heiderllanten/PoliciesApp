using PoliciesApp.Entities.Entities.Enum;
using System;
using System.Collections.Generic;

namespace PoliciesApp.Entities.Entities
{
    public class Policy
    {
        public int PolicyId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ValidityBeginning { get; set; }
        public int CoveragePeriod { get; set; }
        public double Coverage { get; set; }
        public double Price { get; set; }
        public RiskType RiskType { get; set; }

        public virtual List<Customer> Customers { get; set; }
        public virtual List<CoverageType> CoverageTypes { get; set; }
    }
}
