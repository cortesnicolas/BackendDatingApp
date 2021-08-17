using System;
using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required(ErrorMessage = "El nombre de usuario es obligatorio")]
        [MinLength(3, ErrorMessage = "El minimo de caracteres es de 3")]
        [MaxLength(50, ErrorMessage = "Maximo de caracteres es de 50")]
        public string Username { get; set; }

        [Required(ErrorMessage = "El campo me conocen como es obligatorio")]
        public string KnownAs { get; set; }

        [Required(ErrorMessage = "El genero es obligatorio")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento es obligatorio")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "La ciudad es obligatorio")]
        public string City { get; set; }

        [Required(ErrorMessage = "El pais es obligatorio")]
        public string Country { get; set; }
        
        [Required(ErrorMessage = "La contraseña es obligatoria")]
        [MinLength(3, ErrorMessage = "El minimo de caracteres es de 3")]
        public string Password { get; set; }
    }
}