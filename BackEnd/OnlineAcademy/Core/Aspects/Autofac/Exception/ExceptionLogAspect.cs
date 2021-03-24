using System;
using System.Collections.Generic;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Messages;

namespace Core.Aspects.Autofac.Exception
{
    public class ExceptionLogAspect : MethodInterception
    {
        public ExceptionLogAspect()
        {

        }
        protected override void OnException(IInvocation invocation, System.Exception e)
        {
            //throw new System.Exception();
        }
    }
}
