using ProjetoZenvia.Models;
using ProjetoZenviaDominio.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoZenvia.Controllers
{
    public class BaseController : Controller
    {
        private readonly ITipoContatoService _tipoContatoService;


        public BaseController(ITipoContatoService tipoContatoService)
        {
            _tipoContatoService = tipoContatoService;
        }

        public BaseViewModel baseVM(ClienteVM cliente = null, List<ClienteVM> clientes = null)
        {
            var model = new BaseViewModel()
            {
                TipoContato = (IEnumerable<TipoContatoVM>)_tipoContatoService.ListarTipoContato(),
                Cadastros = clientes,
                Cliente = cliente
            };

            return model;
        }
    }
}