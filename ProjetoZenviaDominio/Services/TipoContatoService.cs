using ProjetoZenvia.Domain.Entity;
using ProjetoZenviaDominio.Interfaces.IRepository;
using ProjetoZenviaDominio.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoZenviaDominio.Services
{
    public class TipoContatoService : ITipoContatoService
    {
        private readonly ITipoContatoRepository _tipoContatoRepository;

        public TipoContatoService(ITipoContatoRepository tipoContatoRepository)
        {
            _tipoContatoRepository = tipoContatoRepository;
        }

        public IEnumerable<TipoContato> ListarTipoContato()
        {
            return _tipoContatoRepository.ListarTipoContato();
        }
    }
}
