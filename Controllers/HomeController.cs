using Microsoft.AspNetCore.Mvc;

namespace SistemaVendasWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
