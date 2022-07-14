using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoZenvia.Domain.Entity
{
    public class ClienteEndereco
    {
        [Key]
        public int EnderecoID { get; set; }

        public int ClienteID { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Numero { get; set; }


        [ForeignKey("ClienteID")]
        public virtual Cliente Cliente { get; set; }
    }
}
