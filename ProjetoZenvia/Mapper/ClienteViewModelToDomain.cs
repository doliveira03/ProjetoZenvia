using ProjetoZenvia.Domain.Entity;
using ProjetoZenvia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoZenvia.Mapper
{
    public static class ClienteViewModelToDomain
    {

        public static Cliente MapCliente(ClienteVM clienteVM, int[] idTipoContato, string[] idTelefone, string[] idLogradouro, string[] idComplemento, string[] idNumeroEnd)
        {
            var cliente = new Cliente();

            cliente.ClienteID = clienteVM.ClienteID;
            cliente.Nome = clienteVM.Nome;
            cliente.DataNascimento = clienteVM.DataNascimento;
            cliente.CPF = clienteVM.CPF;
            cliente.RG = clienteVM.RG;
            cliente.Facebook = clienteVM.Facebook;
            cliente.Instagram = clienteVM.Instagram;
            cliente.Twitter = clienteVM.Twitter;
            cliente.Linkedin = clienteVM.Linkedin;

            if (idTipoContato != null)
            {
                cliente.ClienteContatos = new List<ClienteContato>();

                for (var i = 0; i <= idTipoContato.Length - 1; i++)
                {
                    var contato = new ClienteContato
                    {
                        ClienteID = cliente.ClienteID,
                        TipoContatoID = idTipoContato[i],
                        Numero = idTelefone[i]
                    };

                    cliente.ClienteContatos.Add(contato);
                }

            }

            if (idLogradouro != null)
            {
                cliente.ClienteEnderecos = new List<ClienteEndereco>();

                for (var i = 0; i <= idLogradouro.Length - 1; i++)
                {
                    var endereco = new ClienteEndereco
                    {
                        ClienteID = cliente.ClienteID,
                        Logradouro = idLogradouro[i],
                        Complemento = idComplemento[i],
                        Numero = idNumeroEnd[i]

                    };

                    cliente.ClienteEnderecos.Add(endereco);
                }
            }

            return cliente;
        }
    }
}