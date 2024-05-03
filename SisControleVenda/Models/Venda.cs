using System.ComponentModel.DataAnnotations;

namespace SisControleVenda.Models
{
    public class Venda
    {
        public int VendaID { get; set; }
        [Required]

        [Display(Name = "Cliente")]
        public int ClienteID { get; set; }

        [Display(Name = "Funcionário")]
        public int FuncionarioID { get; set; }

        [Display(Name = "Data da Venda")]
        public DateTime DataHora { get; set; }

        [Display(Name = "Produto")]
        public int ProdutoID { get; set; }

        [Display(Name = "Valor da Venda")]
        public decimal ValorTotal { get; set; }

        [Display(Name = "Status")]
        public string? Status { get; set; }
    }
}
