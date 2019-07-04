using PoliciesApp.Entities.Entities;
using PoliciesApp.Repositories.Repositories;
using PoliciesApp.Services.Contract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PoliciesApp.Services.Implementation
{
    public class PolicyService : IPolicyService
    {
        private IPolicyRepository policyRepository;

        public PolicyService(IPolicyRepository policyRepository)
        {
            this.policyRepository = policyRepository;
        }

        public void CreatePolicy(Policy policy)
        {
            this.policyRepository.Add(policy);
        }

        public List<Policy> GetAll()
        {
            return this.policyRepository.GetAll().ToList();
        }

        public Policy GetPolicy(int policyId)
        {
            return this.policyRepository.Find(p => p.PolicyId == policyId).FirstOrDefault();
        }

        public void RemovePolicy(int policyId)
        {
            Policy policy = this.policyRepository.Find(p => p.PolicyId == policyId).FirstOrDefault();
            this.policyRepository.Delete(policy);
        }

        public void UpdatePolicy(Policy policy)
        {
            this.policyRepository.Edit(policy);
        }
    }
}
