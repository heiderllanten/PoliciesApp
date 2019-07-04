using PoliciesApp.Entities.Entities;
using System.Collections.Generic;

namespace PoliciesApp.Services.Contract
{
    public interface IPolicyService
    {
        List<Policy> GetAll();
        Policy GetPolicy(int policyId);
        void CreatePolicy(Policy policy);
        void UpdatePolicy(Policy policy);
        void RemovePolicy(int policyId);
    }
}
