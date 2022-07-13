using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoZenviaDominio.Entidades
{
    public class TipoContato
    {
        [Key]
        public int TipoContatoID { get; set; }

        public string Descricao { get; set; }
    }
}
