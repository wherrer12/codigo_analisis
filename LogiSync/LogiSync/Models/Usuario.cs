using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LogiSync.Models
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        [Required]
        [DisplayName("Nombre de usuario")]
        public string NombreUsuario { get; set; }

        [Required]
        [DisplayName("Contraseña")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DisplayName]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
