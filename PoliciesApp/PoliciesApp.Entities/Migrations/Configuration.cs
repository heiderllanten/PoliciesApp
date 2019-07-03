namespace PoliciesApp.Entities.Migrations
{
    using PoliciesApp.Entities.Entities;
    using PoliciesApp.Entities.Entities.Enum;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<PoliciesApp.Entities.Context.PoliciesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "PoliciesApp.Entities.Context.PoliciesContext";
        }

        protected override void Seed(PoliciesApp.Entities.Context.PoliciesContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            var customers = new List<Customer>
            {
                new Customer { Name = "Heider", Policies = new List<Policy> { } },
                new Customer { Name = "Daniel", Policies = new List<Policy> { } },
                new Customer { Name = "Brian", Policies = new List<Policy> { } },
            };

            var coverageTypes = new List<CoverageType>
            {
                new CoverageType { Description = "Terremoto" },
                new CoverageType { Description = "Incendio" },
                new CoverageType { Description = "Robo" },
                new CoverageType { Description = "Perdida" }
            };

            var policies = new List<Policy>
            {
                new Policy
                {
                    Name = "Todo Riesgo",
                    Description = "Cubre cualquier tipo de daño",
                    ValidityBeginning = DateTime.Today,
                    CoveragePeriod = 12,
                    Coverage = 100,
                    Price = 600000,
                    RiskType = RiskType.Bajo,
                    CoverageTypes = new List<CoverageType> { }
                },
                new Policy
                {
                    Name = "Media Cobertura",
                    Description = "Cubre 50 porciento",
                    ValidityBeginning = DateTime.Today,
                    CoveragePeriod = 12,
                    Coverage = 50,
                    Price = 400000,
                    RiskType = RiskType.Medio,
                    CoverageTypes = new List<CoverageType> { }
                },
                new Policy
                {
                    Name = "Baja Cobertura",
                    Description = "Cubre 20 porciento",
                    ValidityBeginning = DateTime.Today,
                    CoveragePeriod = 10,
                    Coverage = 20,
                    Price = 250000,
                    RiskType = RiskType.Medio_Alto,
                    CoverageTypes = new List<CoverageType> { }
                }
            };

            customers.Find(c => c.Name == "Heider").Policies.AddRange(new List<Policy>
            {
                policies.Find(p => p.Coverage == 100)
            });

            customers.Find(c => c.Name == "Brian").Policies.AddRange(new List<Policy>
            {
                policies.Find(p => p.Coverage == 50),
                policies.Find(p => p.Coverage == 20)
            });

            policies.Find(p => p.Coverage == 100).CoverageTypes.AddRange(new List<CoverageType>
            {
                coverageTypes.Find(cT => cT.Description == "Terremoto"),
                coverageTypes.Find(cT => cT.Description == "Incendio"),
                coverageTypes.Find(cT => cT.Description == "Robo"),
                coverageTypes.Find(cT => cT.Description == "Perdida")
            });

            policies.Find(p => p.Coverage == 50).CoverageTypes.AddRange(new List<CoverageType>
            {
                coverageTypes.Find(cT => cT.Description == "Terremoto"),
                coverageTypes.Find(cT => cT.Description == "Incendio")
            });

            policies.Find(p => p.Coverage == 20).CoverageTypes.AddRange(new List<CoverageType>
            {
                coverageTypes.Find(cT => cT.Description == "Robo")
            });

            context.Customers.AddOrUpdate(c => c.Name,
                customers.ToArray()
            );
            
        }
    }
}
