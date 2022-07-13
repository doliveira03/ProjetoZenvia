using ProjetoZenviaDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoZenvia.Models
{
    public class HomeModel
    {
        public Cliente Cliente { get; set; }
        public ClienteContato ClienteContato { get; set; }
        public ClienteEndereco ClienteEndereco { get; set; }
        public IEnumerable<TipoContato> TipoContato { get; set; }
        public List<Cliente> Cadastros { get; set; }
        public List<ClienteContato> ListaContatos { get; set; }
        public List<ClienteEndereco> ListaEnderecos { get; set; }
    }
}