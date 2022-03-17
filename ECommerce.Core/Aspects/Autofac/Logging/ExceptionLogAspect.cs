using System;
using Castle.DynamicProxy;
using ECommerce.Core.CrossCuttingConcerns.Logging.Log4Net;
using ECommerce.Core.Utilities.CrossCuttingConcerns.Logging;
using ECommerce.Core.Utilities.Interceptors;
using ECommerce.Core.Utilities.Messages;

namespace ECommerce.Core.Aspects.Autofac.Logging
{
    public class ExceptionLogAspect : MethodInterception
    {
        private readonly LoggerServiceBase _loggerServiceBase;

        public ExceptionLogAspect(Type loggerService)
        {
            if (loggerService.BaseType != typeof(LoggerServiceBase))
            {
                throw new System.Exception(AspectMessages.WrongLoggerType);
            }

            _loggerServiceBase = (LoggerServiceBase)Activator.CreateInstance(loggerService);
        }

        protected override void OnException(IInvocation invocation, System.Exception e)
        {
            LogDetailWithException logDetailWithException = LogHelper.GetLogDetail<LogDetailWithException>(invocation);
            logDetailWithException.ExceptionMessage = e.Message;
            _loggerServiceBase.Error(logDetailWithException);
        }
    }
}
