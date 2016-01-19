using System.Collections.Generic;
using UnityInterception.Model;

namespace UnityInterception.Services
{
    public class CustomerService : ICustomerService
    {
        public IEnumerable<Customer> GetAll()
        {
            return new List<Customer>()
            {
                new Customer(),
                new Customer(),
                new Customer(),
                new Customer(),
                new Customer(),
                new Customer(),
                new Customer(),
            };
        }
    }
}
