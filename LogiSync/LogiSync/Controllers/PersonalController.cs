using LogiSync.Models;
using Microsoft.AspNetCore.Mvc;
using System.Web.Mvc;

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

        [HttpPost]
        public Iactionresult buscarpersonal([bind()] personal personal)
        {
            if (!modelstate.isvalid)
            {
                if (personal != null)
                {
                    var temp = _context.personal.firtsordefault(x => x.cedula.equals(personal.cedula));

                    if (temp != null)
                    {
                        return view (temp);
                    }
                   else
                    {
                        tempdata["personalerror"] = "no existe un personal con esa cédula. intente nuevamente.";
                        return view();
                    }
                }
                else
                {
                    tempdata["personalerror"] = "error al buscar el personal. comuniquese con el administrador.";
                    return view();
                }
            }
            else
            {
                tempdata["personalerror"] = "debe de llenar todos los campos.";
                return view();
           }
        }

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
