using PoliciesApp.Entities.Entities;
using PoliciesApp.Repositories.Repositories;
using PoliciesApp.Services.Contract;
using System.Collections.Generic;
using System.Linq;

namespace PoliciesApp.Services.Implementation
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public void AddPolicies(int customerId, List<Policy> policies)
        {
            Customer customer = this.customerRepository.Find(c => c.CustomerId == customerId).FirstOrDefault();
            foreach (Policy p in policies)
            {
                customer.Policies.Add(p);
            }
            this.customerRepository.Edit(customer);
        }

        public List<Customer> GetAll()
        {
            return this.customerRepository.GetAll().ToList();
        }

        public Customer GetCustomer(int customerId)
        {
            return this.customerRepository.Find(c => c.CustomerId == customerId).FirstOrDefault();
        }

        public void RemovePolicies(int customerId, List<Policy> policies)
        {
            Customer customer = this.customerRepository.Find(c => c.CustomerId == customerId).FirstOrDefault();
            foreach (Policy p in customer.Policies)
            {
                if (policies.Find(policy => policy.PolicyId == p.PolicyId) != null)
                {
                    customer.Policies.Remove(p);
                }
            }
            this.customerRepository.Edit(customer);
        }
    }
}
