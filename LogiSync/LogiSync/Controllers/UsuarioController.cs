using LogiSync.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        private string GenerarClave()
        {
            Random randow = new Random();
            string clave = string.Empty;
            clave = "ABCDEFGHIJKLMNOPQRSTUVWQXZ0123456789";
            return new string(Enumerable.Repeat(clave, 12).Select(s => s[randow.Next(s.Length)]).ToArray());
        }


        private bool EnviarEmail(Usuario temp)
        {
            try
            {
                //variable control 
                bool enviado = false;

                //ser instancia el objeto 
                Email email = new Email();

                //se utiliza el metodo para enviar el email
                email.EnviarCorreo(temp);

                //se indica yupii se envio 
                enviado = true;

                //enviamos el valor 
                return enviado;
            }
            catch (Exception ex)
            {
                return false;
            }
        }//cierre enviar email

        //--------------------------------------------------


        [HttpGet]
        public IActionResult CrearUsuario()
        {
            return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult CrearCuenta([Bind] Usuario user)
        //{
        //    if (user != null)
        //    {
               

        //        //Se le asigna una password temporal
        //        user.Password = this.GenerarClave();
        //        _context.Usuarios.Add(user);

        //        try
        //        {
        //            _context.SaveChanges();
        //            if (this.EnviarEmail(user))
        //            {
        //                TempData["MensajeCreado"] = "Usuario creado correctamente. Su contraseña fue enviada por email.";
        //            }
        //            else
        //            {
        //                TempData["MensajeCreado"] = "Usuario creado pero no fue posible enviar el correo. Comuníquese con el administrador.";
        //            }

        //        }
        //        catch (Exception ex)
        //        {
        //            TempData["MensajeCreado"] = "No se logró crear la cuenta..." + ex.Message;
        //        }
        //        return View();
        //    }
        //    else
        //    {
        //        TempData["MensajeCreado"] = "No se logró crear la cuenta...";
        //        return View();
        //    }
        //}



        //--------------------------------------------------
    }
}
