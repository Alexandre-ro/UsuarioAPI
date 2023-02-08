using System.ComponentModel.DataAnnotations;

namespace UsuarioAPI.DTO
{
    public class CreateUsuarioDTO
    {
        [Required]
        public string Nome { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string RePassord { get; set; }
    }
}
