using System.ComponentModel.DataAnnotations;

namespace SisControleVenda.Models
{
    public class Login
    {
        [Required]
        [Key]
        public int NivelDeAcessoID { get; set; }
        [Required]
        public string? Email { get; set; }

        [StringLength(10, MinimumLength = 4, ErrorMessage = "Máximo de 10, mínimo de 4 caracteres")]
        public string? Senha { get; set; }
    }
}
