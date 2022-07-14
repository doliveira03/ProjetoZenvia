using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoZenvia.Models
{
    public class ClienteContatoVM
    {
        public int ContatoID { get; set; }
        public int ClienteID { get; set; }
        public int TipoContatoID { get; set; }
        public string Numero { get; set; }

        public virtual ClienteVM Cliente { get; set; }
        public virtual TipoContatoVM TipoContato { get; set; }
    }
}