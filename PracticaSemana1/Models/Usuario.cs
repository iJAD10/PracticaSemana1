using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracticaSemana1.Models
{
    [Table("Users")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de usuario es obligatorio")]
        public required string Username { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria")]
        [Column("PasswordHash")]
        public required string Password { get; set; }
    }
}
