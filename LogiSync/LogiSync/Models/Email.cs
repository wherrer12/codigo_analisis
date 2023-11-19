using System.Net.Mail;
using System.Net.Mime;
using System.Net;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LogiSync.Models
{
    public class Email
    {
        public void EnviarCorreo(Usuario user) {

            //Se crea una instancia del objeto email
            MailMessage Email = new MailMessage();

            Email.Subject = "Cambio de contraseña para el sistema LogiSync";

            //Destinarios
            Email.To.Add(new MailAddress("logisyncUCR2@outlook.com"));
            Email.To.Add(new MailAddress(user.Email));

            //Emisor del correo
            Email.From = new MailAddress("logisyncUCR2@outlook.com");

            string html = "Bienvenidos a LogiSync. Gracias por formar parte de nuestra plataforma.";
            html += "<br>A continuación detallamos la contraseña temporal:";
            html += "<br><b>Su contraseña temporal: </b>" + user.Password;
            html += "<br><b>No responda a este correo porque fue generado de manera automatica.";
            html += "LogiSync: Planificación de recursos empresariales.</b>";


            //Se indica el contenido en ese html
            Email.IsBodyHtml = true;

            //Se indica la prioridad recomendacion debe ser prioridad normal
            Email.Priority = MailPriority.Normal;

            //Se instncia la vista del html para el cuerpo del body del email

            AlternateView view = AlternateView.CreateAlternateViewFromString(html, Encoding.UTF8, MediaTypeNames.Text.Html);

            Email.AlternateViews.Add(view);

            //Configuracion del protocolo de comunicacion smtp
            SmtpClient smtp = new SmtpClient();

            //Servidor de correo a implentar
            smtp.Host = "smtp-mail.outlook.com";

            //Puerto de comunicacion
            smtp.Port = 587;

            //Se indica si el buzon utiliza seguridad tipo SSL

            smtp.EnableSsl = true;

            //Se indica si el buzon utiliza credenciales por defecto
            smtp.UseDefaultCredentials = false;

            //Se asignan los datos para las credenciales
            smtp.Credentials = new NetworkCredential("logisyncUCR2@outlook.com", "Wakjv123");

            //Metodo para enviar el email
            smtp.Send(Email);
            Email.Dispose();
            smtp.Dispose();
        }
    }
}
