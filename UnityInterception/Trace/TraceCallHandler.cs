using System;
using Microsoft.Practices.Unity.InterceptionExtension;

namespace UnityInterception.Trace
{
    public class TraceCallHandler : ICallHandler
    {
        public IMethodReturn Invoke(IMethodInvocation input, GetNextHandlerDelegate getNext)
        {
            Console.WriteLine($"Called: {input.Target.GetType()}.{input.MethodBase.Name}");

            if (input.Arguments.Count > 0)
            {
                Console.WriteLine("\tWith Arguments");

                for (var i = 0; i < input.Arguments.Count; i++)
                {
                    Console.WriteLine($"\tName: {input.Arguments.GetParameterInfo(i)}");
                }
            }

            var handlerDelegate = getNext();

            Console.WriteLine("Execute...");

            var methodReturn = handlerDelegate(input, getNext);

            var result = methodReturn.ReturnValue?.ToString() ?? "(void)";

            if (methodReturn.Exception != null)
            {
                Console.WriteLine($"Exception: {methodReturn.Exception}");
            }

            Console.WriteLine($"Result: {result}");

            return methodReturn;
        }

        public int Order { get; set; }
    }
}