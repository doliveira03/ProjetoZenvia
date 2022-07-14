using Microsoft.Ajax.Utilities;
using ProjetoZenvia.Domain.Entity;
using ProjetoZenvia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoZenvia.Mapper
{
    public static class ClienteDomainToViewModel
    {
        public static ClienteVM MapCliente(Cliente cliente)
        {
            var clienteVM = new ClienteVM();

            clienteVM.ClienteID = cliente.ClienteID;
            clienteVM.Nome = cliente.Nome;
            clienteVM.DataNascimento = cliente.DataNascimento;
            clienteVM.CPF = cliente.CPF;
            clienteVM.RG = cliente.RG;
            clienteVM.Facebook = cliente.Facebook;
            clienteVM.Instagram = cliente.Instagram;
            clienteVM.Twitter = cliente.Twitter;
            clienteVM.Linkedin = cliente.Linkedin;

            clienteVM.ClienteContatos = new List<ClienteContatoVM>();
            cliente.ClienteContatos.ForEach(contatos =>
            {
                clienteVM.ClienteContatos.Add(
                new ClienteContatoVM()
                {
                    ClienteID = contatos.ClienteID,
                    TipoContatoID = contatos.TipoContatoID,
                    Numero = contatos.Numero
                });
            });

            clienteVM.ClienteEnderecos = new List<ClienteEnderecoVM>();
            cliente.ClienteEnderecos.ForEach(enderecos =>
            {
                clienteVM.ClienteEnderecos.Add(
               new ClienteEnderecoVM()
               {
                   ClienteID = enderecos.ClienteID,
                   Logradouro = enderecos.Logradouro,
                   Complemento = enderecos.Complemento,
                   Numero = enderecos.Numero

               });
            });


            return clienteVM;
        }

        public static List<ClienteVM> MapListCliente(List<Cliente> clientes)
        {
            var clientesVM = new List<ClienteVM>();

            clientes.ForEach(c =>
            {
                clientesVM.Add(new ClienteVM()
                {
                    ClienteID = c.ClienteID,
                    Nome = c.Nome,
                    DataNascimento = c.DataNascimento,
                    CPF = c.CPF,
                    RG = c.RG,
                    Facebook = c.Facebook,
                    Instagram = c.Instagram,
                    Twitter = c.Twitter,
                    Linkedin = c.Linkedin,

                });

            });

            return clientesVM;
        }
      
    }
}