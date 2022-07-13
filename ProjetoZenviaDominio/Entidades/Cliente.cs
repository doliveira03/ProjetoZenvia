using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoZenviaDominio.Entidades
{
    public class Cliente
    {
        [Key]
        public int ClienteID { get; set; }

        [Required(ErrorMessage ="Nome é obrigatório!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Data de nascimento é obrigatória!")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "CPF é obrigatório!")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "RG é obrigatório!")]
        public string RG { get; set; }

        public string Facebook { get; set; }
        public string Linkedin { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }

        public virtual ICollection<ClienteContato> ClienteContatos { get; set; }
        public virtual ICollection<ClienteEndereco> ClienteEnderecos { get; set; }
    }
}
