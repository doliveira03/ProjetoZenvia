using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoZenvia.Models
{
    public class ClienteVM
    {

        public int ClienteID { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Facebook { get; set; }
        public string Linkedin { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }

        public virtual ICollection<ClienteContatoVM> ClienteContatos { get; set; }
        public virtual ICollection<ClienteEnderecoVM> ClienteEnderecos { get; set; }
    }
}