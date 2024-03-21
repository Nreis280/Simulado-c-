using Microsoft.AspNetCore.Mvc;

namespace Simulado.Controllers
{
    public class NavController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
