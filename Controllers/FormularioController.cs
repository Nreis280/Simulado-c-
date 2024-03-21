using Microsoft.AspNetCore.Mvc;

namespace Simulado.Controllers
{
    public class FormularioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
