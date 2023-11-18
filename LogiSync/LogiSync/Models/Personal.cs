using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace LogiSync.Models
{
    public class Personal
    {
        [Key]
        public int IdPersonal { get; set; }

        [Required]
        [DisplayName("Cédula")]
        public string Cedula { get; set; }

        [Required]
        [DisplayName("Nombre completo")]
        public string Nombre { get; set; }

        [Required]
        [DisplayName("Teléfono")]
        public string Telefono { get; set; }

        [Required]
        [DisplayName("Correo")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Por favor, introduce una dirección de correo electrónico válida.")]
        public string Email { get; set; }

        [Required]
        [DisplayName("Estado")]
        public string Estado { get; set; }

        [Required]
        [DisplayName("Departamento")]
        public string Departamento { get; set; }
    }
}
