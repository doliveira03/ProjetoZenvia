using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;

namespace ProjetoZenvia
{
    public class ServiceResolverAdapter : IDependencyResolver
    {
        private readonly System.Web.Mvc.IDependencyResolver dependencyResolver;

        public ServiceResolverAdapter(System.Web.Mvc.IDependencyResolver dependencyResolver)
        {
            if (dependencyResolver == null)
            {
                throw new ArgumentNullException("dependencyResolver");
            }

            this.dependencyResolver = dependencyResolver;
        }

        public IDependencyScope BeginScope()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public object GetService(Type serviceType)
        {
            return dependencyResolver.GetService(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return dependencyResolver.GetServices(serviceType);
        }
    }
}