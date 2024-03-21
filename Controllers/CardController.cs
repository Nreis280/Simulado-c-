using Microsoft.AspNetCore.Mvc;

namespace Simulado.Controllers
{
    public class CardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
