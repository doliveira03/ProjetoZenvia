using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;

namespace ProjetoZenvia
{
    public static class ServiceResolverExtensions
    {
        public static IDependencyResolver ToServiceResolver(
            this System.Web.Mvc.IDependencyResolver dependencyResolver)
        {
            return new ServiceResolverAdapter(dependencyResolver);
        }
    }
}