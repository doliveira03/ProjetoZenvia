using Ninject.Modules;
using ProjetoZenvia.Infra.Repository;
using ProjetoZenviaDominio.Interfaces.IRepository;
using ProjetoZenviaDominio.Interfaces.IServices;
using ProjetoZenviaDominio.Services;

namespace ProjetoZenvia.App_Start
{
    public class ModuloDomainCommon : NinjectModule
    {
        public override void Load()
        {
            Bind<IClienteService>().To<ClienteService>();
            Bind<ITipoContatoService>().To<TipoContatoService>();
            Bind<IClienteRepository>().To<ClienteRepository>();
            Bind<ITipoContatoRepository>().To<TipoContatoRepository>();

        }
    }
}