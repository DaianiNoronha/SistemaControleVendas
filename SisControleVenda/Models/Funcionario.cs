using System.ComponentModel.DataAnnotations;

namespace SisControleVenda.Models
{
    public class Funcionario
    {
        [Display(Name = "ID")]
        public int FuncionarioID {  get; set; }

        [Display(Name = "Nível de Acesso")]
        public int NivelDeAcessoID { get; set; }

        [Display(Name = "Nome")]
        public string? AdministradorNome { get; set; }

        [Display(Name = "Telefone")]
        public string? Telefone { get; set; }

        [Display(Name = "Email")]
        public string? Email { get; set; }

        [Display(Name = "Cargo")]
        public string? Cargo { get; set; }

        [Display(Name = "Data Admissão")]
        public DateTime DtCad { get; set; }

        [Display(Name = "Salário")]
        public decimal Salario { get; set; }
    }
}
