using ProjetoZenvia.Models;
using ProjetoZenvia.Repositorio;
using ProjetoZenviaDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace ProjetoZenvia.Controllers
{
    public class HomeController : Controller
    {
        private readonly HomeRepositorio _repositorio;


        public HomeController()
        {
            _repositorio = new HomeRepositorio();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cadastro(int id)
        {

            if(id == 0)
            {
                return View(HModel());
            }

            return View("Cadastro", HModel(cliente: _repositorio.Obter(id)));
        }

        //[Route("editar-cadastro/{id}")]
        //public ActionResult Cadastro(int id)
        //{
        //    return View("Cadastro", HModel(cliente: _repositorio.Obter(id)));
        //}

        [HttpPost]
        public ActionResult Cadastro(HomeModel homeModel, int[] idTipoContato, string[] idTelefone, string[] idLogradouro, string[] idComplemento, string[] idNumeroEnd)
        {
            try
            {
                if (idTipoContato != null)
                {
                    homeModel.Cliente.ClienteContatos = new List<ClienteContato>();

                    for (var i = 0; i <= idTipoContato.Length - 1; i++)
                    {
                        var contato = new ClienteContato
                        {
                            ClienteID = homeModel.Cliente.ClienteID,
                            TipoContatoID = idTipoContato[i],
                            Numero = idTelefone[i]
                        };

                        homeModel.Cliente.ClienteContatos.Add(contato);
                    }

                }

                if (idLogradouro != null)
                {
                    homeModel.Cliente.ClienteEnderecos = new List<ClienteEndereco>();

                    for (var i = 0; i <= idLogradouro.Length - 1; i++)
                    {
                        var endereco = new ClienteEndereco
                        {
                            ClienteID = homeModel.Cliente.ClienteID,
                            Logradouro = idLogradouro[i],
                            Complemento = idComplemento[i],
                            Numero = idNumeroEnd[i]

                        };
                        homeModel.Cliente.ClienteEnderecos.Add(endereco);
                    }
                }

                _repositorio.SalvarCliente(homeModel.Cliente);

                TempData["Mensagem"] = "Cadastro realizado com sucesso!!";

                return RedirectToAction("Cadastro", "Home");
                
            }
            catch (Exception ex)
            {
                TempData["Alerta"] = $"Ocorreu um erro ao submeter formulário : {ex.Message}";

                throw new InvalidOperationException(ex.Message);
            }
        }

        public ActionResult ListarCadastros()
        {
            return View(HModel());
        }

        public HomeModel HModel(Cliente cliente = null)
        {
            var model = new HomeModel()
            {
                TipoContato = _repositorio.ListarTipoContato(),
                Cadastros = _repositorio.ListarCliente(),
                Cliente = cliente ?? new Cliente(),
            };

            return model;
        }
    }
}