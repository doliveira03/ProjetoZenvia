using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoZenvia.Domain.Entity
{
    public class ClienteContato
    {
        [Key]
        public int ContatoID { get; set; }

        public int ClienteID { get; set; }
        public int TipoContatoID { get; set; }
        public string Numero { get; set; }

        [ForeignKey("ClienteID")]
        public virtual Cliente Cliente { get; set; }

        [ForeignKey("TipoContatoID")]
        public virtual TipoContato TipoContato { get; set; }
    }
}
