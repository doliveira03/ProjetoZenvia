using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoZenvia.Models
{
    public class ClienteEnderecoVM
    {
        public int EnderecoID { get; set; }

        public int ClienteID { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Numero { get; set; }

        public virtual ClienteVM Cliente { get; set; }
    }
}