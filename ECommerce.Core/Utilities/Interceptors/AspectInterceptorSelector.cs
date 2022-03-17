using System;
using System.Linq;
using System.Reflection;
using Castle.DynamicProxy;
using ECommerce.Core.Aspects.Autofac.Logging;
using ECommerce.Core.Aspects.Autofac.Performance;
using ECommerce.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;

namespace ECommerce.Core.Utilities.Interceptors
{
    public class AspectInterceptorSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            var classAttributes = type.GetCustomAttributes<MethodInterceptionBaseAttribute>
                (true).ToList();
            var methodAttributes = type.GetMethod(method.Name)
                .GetCustomAttributes<MethodInterceptionBaseAttribute>(true);
            classAttributes.AddRange(methodAttributes);

            classAttributes.Add(new PerformanceAspect(0)); // Reports the running time of all methods to the Debug screen
            classAttributes.Add(new LogAspect(typeof(FileLogger))); // Logs all methods to the file before the methods run.

            return classAttributes.OrderBy(x => x.Priority).ToArray();
        }
    }
}