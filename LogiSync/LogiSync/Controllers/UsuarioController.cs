using Microsoft.AspNetCore.Mvc;

namespace LogiSync.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        //--------------------------------------------------


        [HttpGet]
        public IActionResult CrearUsuario()
        {
            return View();
        }



        //--------------------------------------------------
    }
}
