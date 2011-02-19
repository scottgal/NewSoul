using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Attributes;
using StructureMap;
using StructureMap.Interceptors;

namespace Common
{
    public class ServiceSecurityInterceptor : InstanceInterceptor
    {
        public object Process(object target, IContext context)
        {
     
                return target;
        }




        public bool MatchesType(Type type)
        {
            return type.GetCustomAttributes(typeof(SecureAttribute),true).Length == 1;
        }
    }
}
 