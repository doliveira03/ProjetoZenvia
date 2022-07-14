using ProjetoZenvia.Domain.Entity;
using System.Collections.Generic;

namespace ProjetoZenviaDominio.Interfaces.IServices
{
    public interface IClienteService 
    {
        Cliente Obter(int id);
        List<Cliente> ListarCliente();      
        bool Cadastro(Cliente cliente);
    }
}
