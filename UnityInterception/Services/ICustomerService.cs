using System.Collections.Generic;
using UnityInterception.Model;
using UnityInterception.Trace;

namespace UnityInterception.Services
{
    [Trace]
    public interface ICustomerService
    {
        IEnumerable<Customer> GetAll();
    }
}