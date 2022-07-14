using ProjetoZenvia.Domain.Entity;
using ProjetoZenviaDominio.Interfaces.IRepository;
using ProjetoZenviaDominio.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoZenviaDominio.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository) 
        {
            _clienteRepository = clienteRepository;
        }

        public Cliente Obter(int id)
        {
            return _clienteRepository.Obter(id);
        }

        public List<Cliente> ListarCliente()
        {
           return _clienteRepository.ListarCliente();
        }

        public  bool Cadastro (Cliente cliente)
        {
            try
            {         
                _clienteRepository.SalvarCliente(cliente);

                return true;

            }
            catch (Exception ex)
            {
                return false;
                throw new InvalidOperationException(ex.Message);
            }
        }

    }
}
