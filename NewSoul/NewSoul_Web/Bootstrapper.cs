using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewSoul_Web
{
    internal static class Bootstrapper
    {
        internal static  void Configure()
        {
            Services.Mappings.AutomapperConfiguration.Configure();
        }
    }
}