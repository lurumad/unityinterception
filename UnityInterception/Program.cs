using System;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.InterceptionExtension;
using UnityInterception.Services;

namespace UnityInterception
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer();
            container.AddNewExtension<Interception>();
            container
                .Configure<Interception>()
                .SetInterceptorFor<ICustomerService>(new InterfaceInterceptor());
            container.RegisterType<ICustomerService, CustomerService>();

            var service = container.Resolve<ICustomerService>();
            var customers = service.GetAll();

            Console.Read();
        }
    }
}
