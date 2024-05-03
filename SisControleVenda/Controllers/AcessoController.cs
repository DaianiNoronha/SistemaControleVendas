using Microsoft.AspNetCore.Mvc;

namespace SisControleVenda.Controllers
{
    public class AcessoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
