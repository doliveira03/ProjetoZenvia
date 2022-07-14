using System;
using System.Collections.Generic;
using System.Linq;
using ProjetoZenvia.Domain.Entity;
using ProjetoZenvia.Infra.Context;
using ProjetoZenviaDominio.Interfaces.IRepository;

namespace ProjetoZenvia.Infra.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly EFContext _context = new EFContext();

        public ClienteRepository(EFContext context) 
        {
            _context = context;
        }

        public Cliente Obter(int id)
        {
            return _context.Clientes.Find(id);
        }

        public List<Cliente> ListarCliente()
        {
            return  _context.Clientes.ToList();
        }

        public void SalvarCliente(Cliente cliente)
        {
            using (var dbTransacao = _context.Database.BeginTransaction())
            {
                try
                {
                    if (cliente.ClienteID == 0)
                    {
                        _context.Clientes.Add(cliente);
                    }
                    else
                    {
                        var c = _context.Clientes.Find(cliente.ClienteID);

                        if (c != null)
                        {
                            c.Nome = cliente.Nome;
                            c.DataNascimento = cliente.DataNascimento;
                            c.CPF = cliente.CPF;
                            c.RG = cliente.RG;
                            c.Facebook = cliente.Facebook;
                            c.Twitter = cliente.Twitter;
                            c.Linkedin = cliente.Linkedin;
                            c.Instagram = cliente.Instagram;
                            c.ClienteContatos = cliente.ClienteContatos;
                            c.ClienteEnderecos = cliente.ClienteEnderecos;
                        }
                    }

                    _context.SaveChanges();
                    dbTransacao.Commit();

                }
                catch (Exception)
                {
                    dbTransacao.Rollback();
                }
            }
        }

  
    }
}