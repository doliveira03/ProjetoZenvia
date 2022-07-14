using ProjetoZenvia.Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoZenviaDominio.Interfaces.IRepository
{
    public interface IClienteRepository 
    {
        Cliente Obter(int id);
        List<Cliente> ListarCliente();
        void SalvarCliente(Cliente cliente);
    }
}
