using LogiSync.Models;
using Microsoft.AspNetCore.Mvc;

namespace LogiSync.Controllers
{
    public class PersonalController : Controller
    {

        //AppDbContext _context;

        //public PersonalController(AppDbContext context)
        //{
        //    _context = context;
        //}

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult RegistroPersonal()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult RegistrarPersonal([Bind()] Personal personal)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        if (personal != null)
        //        {
        //            var temp = _context.personal.FirtsOrDefault(x => x.cedula.Equals(personal.Cedula));

        //            if (temp == null)
        //            {
        //                _context.personal.Add(temp);
        //                _context.SaveChange();

        //                return RedirectToAction("Index", "Administrador");
        //            } 
        //            else
        //            {
        //                TempData["PersonalError"] = "Ya existe un personal con esa cédula. Intente nuevamente.";
        //                return View();
        //            }
        //        }
        //        else
        //        {
        //            TempData["PersonalError"] = "Error al registrar el personal. Comuniquese con el administrador.";
        //            return View();
        //        }
        //    }
        //    else
        //    {
        //        TempData["PersonalError"] = "Debe de llenar todos los campos.";
        //        return View();
        //    }
        //}

        [HttpGet]
        public IActionResult ExcluirPersonal()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult ExcluirPersonal([Bind()] Personal personal)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        if (personal != null)
        //        {
        //            var temp = _context.personal.FirtsOrDefault(x => x.cedula.Equals(personal.Cedula));

        //            if (temp != null)
        //            {
        //                _context.ChangeTracker.Clear();
        //                _context.personal.Update(temp);
        //                _context.SaveChange();

        //                return RedirectToAction("Index", "Administrador");
        //            }
        //            else
        //            {
        //                TempData["PersonalError"] = "No existe un personal con esa cédula. Intente nuevamente.";
        //                return View();
        //            }
        //        }
        //        else
        //        {
        //            TempData["PersonalError"] = "Error al excluir el personal. Comuniquese con el administrador.";
        //            return View();
        //        }
        //    }
        //    else
        //    {
        //        TempData["PersonalError"] = "Debe de llenar todos los campos.";
        //        return View();
        //    }
        //}

        [HttpGet]
        public IActionResult BuscarPersonal()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult BuscarPersonal([Bind()] Personal personal)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        if (personal != null)
        //        {
        //            var temp = _context.personal.FirtsOrDefault(x => x.cedula.Equals(personal.Cedula));

        //            if (temp != null)
        //            {
        //                return View (temp);
        //            }
        //            else
        //            {
        //                TempData["PersonalError"] = "No existe un personal con esa cédula. Intente nuevamente.";
        //                return View();
        //            }
        //        }
        //        else
        //        {
        //            TempData["PersonalError"] = "Error al buscar el personal. Comuniquese con el administrador.";
        //            return View();
        //        }
        //    }
        //    else
        //    {
        //        TempData["PersonalError"] = "Debe de llenar todos los campos.";
        //        return View();
        //    }
        //}

        [HttpGet]
        public IActionResult ModificarPersonal()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult ModificarPersonal([Bind()] Personal personal)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        if (personal != null)
        //        {
        //            var temp = _context.personal.FirtsOrDefault(x => x.cedula.Equals(personal.Cedula));

        //            if (temp != null)
        //            {
        //                _context.ChangeTracker.Clear();
        //                _context.personal.Update(temp);
        //                _context.SaveChange();

        //                return RedirectToAction("Index", "Administrador");
        //            }
        //            else
        //            {
        //                TempData["PersonalError"] = "No existe un personal con esa cédula. Intente nuevamente.";
        //                return View();
        //            }
        //        }
        //        else
        //        {
        //            TempData["PersonalError"] = "Error al modificar el personal. Comuniquese con el administrador.";
        //            return View();
        //        }
        //    }
        //    else
        //    {
        //        TempData["PersonalError"] = "Debe de llenar todos los campos.";
        //        return View();
        //    }
        //}
    }
}
