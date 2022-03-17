using System;
using Castle.DynamicProxy;
using ECommerce.Core.CrossCuttingConcerns.Logging;
using ECommerce.Core.CrossCuttingConcerns.Logging.Log4Net;
using ECommerce.Core.Utilities.CrossCuttingConcerns.Logging;
using ECommerce.Core.Utilities.Interceptors;
using ECommerce.Core.Utilities.Messages;

namespace ECommerce.Core.Aspects.Autofac.Logging
{
    public class LogAspect : MethodInterception
    {
        private readonly LoggerServiceBase _loggerServiceBase;

        public LogAspect(Type loggerService)
        {
            if (loggerService.BaseType != typeof(LoggerServiceBase))
            {
                throw new System.Exception(AspectMessages.WrongLoggerType);
            }

            _loggerServiceBase = (LoggerServiceBase)Activator.CreateInstance(loggerService);
        }

        protected override void OnBefore(IInvocation invocation)
        {
            _loggerServiceBase.Info(LogHelper.GetLogDetail<LogDetail>(invocation));
        }
    }
}
