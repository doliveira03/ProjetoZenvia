using ProjetoZenvia.Mapper;
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
                TipoContato = TipoContatoDomainToViewModel.MapListTipoContato(_tipoContatoService.ListarTipoContato().ToList()),
                Cadastros = clientes,
                Cliente = cliente
            };

            return model;
        }
    }
}