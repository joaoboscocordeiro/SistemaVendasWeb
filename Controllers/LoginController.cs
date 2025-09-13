using Microsoft.AspNetCore.Mvc;
using SistemaVendasWeb.Services.Usuario;

namespace SistemaVendasWeb.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioInterface _usuarioInterface;

        public LoginController(IUsuarioInterface usuarioInterface)
        {
            _usuarioInterface = usuarioInterface;
        }
        
        public IActionResult Login()
        {
            return View();
        }
    }
}
