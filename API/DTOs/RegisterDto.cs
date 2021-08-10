using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required(ErrorMessage = "El nombre de usuario es obligatorio")]
        [MinLength(3, ErrorMessage = "El minimo de caracteres es de 3")]
        [MaxLength(50, ErrorMessage = "Maximo de caracteres es de 50")]
        public string Username { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria")]
        [MinLength(3, ErrorMessage = "El minimo de caracteres es de 3")]
        public string Password { get; set; }
    }
}