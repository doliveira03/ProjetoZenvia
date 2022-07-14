using Ninject.Modules;
using ProjetoZenviaDominio.Interfaces.IServices;
using ProjetoZenviaDominio.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoZenvia
{
    public class DependencyMapper : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IClienteService>().To<ClienteService>();

        }
    }
}