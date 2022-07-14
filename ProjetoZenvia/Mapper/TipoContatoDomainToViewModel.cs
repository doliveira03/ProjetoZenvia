using ProjetoZenvia.Domain.Entity;
using ProjetoZenvia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoZenvia.Mapper
{
    public static class TipoContatoDomainToViewModel
    {
        public static List<TipoContatoVM> MapListTipoContato(List<TipoContato> tipoContatos)
        {
            var tipoContatoVM = new List<TipoContatoVM>();

            tipoContatos.ForEach(c =>
            {
                tipoContatoVM.Add(new TipoContatoVM()
                {
                    TipoContatoID = c.TipoContatoID,
                    Descricao = c.Descricao

                });

            });

            return tipoContatoVM;
        }
    }
}