using ProjetoZenvia.Domain.Entity;
using ProjetoZenvia.Infra.Context;
using ProjetoZenviaDominio.Interfaces.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoZenvia.Infra.Repository
{

    public class TipoContatoRepository : ITipoContatoRepository
    {
        private readonly EFContext _context = new EFContext();

        public TipoContatoRepository(EFContext context)
        {
            _context = context;
        }

        public IEnumerable<TipoContato> ListarTipoContato()
        {
            return _context.TiposContato;
        }
    }
}
