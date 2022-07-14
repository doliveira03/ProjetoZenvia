using CommonServiceLocator;
using Microsoft.Extensions.DependencyModel;
using Ninject;
using Ninject.Web.Common;
using ProjetoZenvia.Infra.Repository;
using ProjetoZenviaDominio.Interfaces.IRepository;
using ProjetoZenviaDominio.Interfaces.IServices;
using ProjetoZenviaDominio.Services;
using System;
using System.Web;
using System.Web.Http;
using Ninject.Web.Mvc;
using Ninject.Web.Common.WebHost;
using Microsoft.Web.Infrastructure.DynamicModuleHelper;

namespace ProjetoZenvia.App_Start
{


    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
                kernel.Bind<IClienteService>().To<ClienteService>();
                kernel.Bind<ITipoContatoService>().To<TipoContatoService>();
                kernel.Bind<IClienteRepository>().To<ClienteRepository>();
                kernel.Bind<ITipoContatoRepository>().To<TipoContatoRepository>();
                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }
        
        private static void RegisterServices(IKernel kernel)
        {
        }
    }
}
