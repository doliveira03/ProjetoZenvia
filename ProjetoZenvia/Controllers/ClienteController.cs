using Ninject;
using ProjetoZenvia.Mapper;
using ProjetoZenvia.Models;
using ProjetoZenviaDominio.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ProjetoZenvia.Controllers
{
    public class ClienteController : BaseController
    {

        private readonly IClienteService _clienteService;
        private readonly ITipoContatoService _tipoContatoService;

        [Inject]
        public ClienteController(IClienteService clienteService, ITipoContatoService tipoContato) : base(tipoContato)
        {
            _clienteService = clienteService;
            _tipoContatoService = tipoContato;
        }

        public ActionResult Cadastro(int id = 0)
        {
            if(id > 0)
            {
                return View("Cadastro", baseVM(cliente: ClienteDomainToViewModel.MapCliente(_clienteService.Obter(id))));
            }

            return View(baseVM());
        }


        [HttpPost]
        public ActionResult Cadastro(ClienteVM cliente, int[] idTipoContato, string[] idTelefone, string[] idLogradouro, string[] idComplemento, string[] idNumeroEnd)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

           var retorno = _clienteService.Cadastro(ClienteViewModelToDomain.MapCliente(cliente, idTipoContato, idTelefone, idLogradouro, idComplemento, idNumeroEnd));


            if(retorno == true)
            {
                return RedirectToAction("Cadastro", "Cliente");
            }

            return View();
        }

        public ActionResult ListarCadastros()
        {

            var retorno = _clienteService.ListarCliente();

            return View(baseVM(clientes: ClienteDomainToViewModel.MapListCliente(retorno)));

        }    

    }
}