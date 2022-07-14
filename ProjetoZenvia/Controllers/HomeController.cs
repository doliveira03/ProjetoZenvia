using ProjetoZenviaDominio.Interfaces.IServices;
using System.Web.Mvc;

namespace ProjetoZenvia.Controllers
{
    public class HomeController : Controller
    {


        public ActionResult Index()
        {
            return View();
        }
   
    }
}