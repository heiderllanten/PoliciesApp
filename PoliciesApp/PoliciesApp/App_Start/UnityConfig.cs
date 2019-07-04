using PoliciesApp.Repositories.Repositories;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace PoliciesApp
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();
            container.RegisterType<ICustomerRepository, CustomerRepository>();
            container.RegisterType<IPolicyRepository, PolicyRepository>();
            container.RegisterType<ICoverageTypeRepository, CoverageTypeRepository>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}