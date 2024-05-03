using System.ComponentModel.DataAnnotations;

namespace SisControleVenda.Models
{
    public class Cliente
    {
        [Display(Name = "ID")]
        public int ClienteID { get; set; }

        [Display(Name = "Nível de Acesso")]
        public int NivelDeAcessoID { get; set; }

        [Display(Name = "Nome")]
        public string? ClienteNome { get; set; }

        [Display(Name = "Sobrenome")]
        public string? ClienteSobrenome { get; set; }

        [Display(Name = "CPF")]
        public string? ClienteCPF { get; set; }

        [Display(Name = "Data de Nascimento")]
        public DateOnly ClienteDtNasc { get; set; }

        [Display(Name = "Telefone")]
        public string? Telefone { get; set; }

        [Display(Name = "Email")]
        public string? Email { get; set; }

       
    }
}
