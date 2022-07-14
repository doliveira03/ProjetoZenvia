using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoZenvia.Models
{
    public class BaseViewModel
    {
        public ClienteVM Cliente { get; set; }
        public ClienteContatoVM ClienteContato { get; set; }
        public ClienteEnderecoVM ClienteEndereco { get; set; }
        public List<TipoContatoVM> TipoContato { get; set; }
        public List<ClienteVM> Cadastros { get; set; }
    }
}