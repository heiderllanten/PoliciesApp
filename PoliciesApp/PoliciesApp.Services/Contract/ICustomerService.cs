

using PoliciesApp.Entities.Entities;
using System.Collections.Generic;

namespace PoliciesApp.Services.Contract
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        Customer GetCustomer(int customerId);
        void AddPolicies(int customerId, List<Policy> policies);
        void RemovePolicies(int customerId, List<Policy> policies);
    }
}
