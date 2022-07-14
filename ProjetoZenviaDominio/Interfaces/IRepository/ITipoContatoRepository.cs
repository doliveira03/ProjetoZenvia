using ProjetoZenvia.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoZenviaDominio.Interfaces.IRepository
{
    public interface ITipoContatoRepository
    {
        IEnumerable<TipoContato> ListarTipoContato();
    }
}
