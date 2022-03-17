using Castle.DynamicProxy;
using ECommerce.Core.CrossCuttingConcerns.Caching;
using ECommerce.Core.Utilities.Interceptors;
using ECommerce.Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.Core.Aspects.Autofac.Caching
{
    public class CacheRemoveAspect : MethodInterception
    {
        private readonly string _pattern;
        private readonly ICacheManager _cacheManager;

        public CacheRemoveAspect(string pattern)
        {
            _pattern = pattern;
            _cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
        }

        protected override void OnSuccess(IInvocation invocation)
        {
            _cacheManager.RemoveByPattern(_pattern);
        }
    }
}