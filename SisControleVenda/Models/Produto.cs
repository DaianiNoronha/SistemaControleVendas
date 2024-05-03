using System.ComponentModel.DataAnnotations;

namespace SisControleVenda.Models
{
    public class Produto
    {
        public int ProdutoID { get; set; }

        [Display(Name = "Livro")]
        public string? NomeLivro { get; set; }

        [Display(Name = "Gênero")]
        public string? Genero { get; set; }

        [Display(Name = "Autor")]
        public string? NomeAutor { get; set; }

        [Display(Name = "Ano de Publicação")]
        public string? AnoPublic { get; set; }

        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        [Display(Name = "Estoque")]
        public int QauntidadeEmEstoque { get; set; }

    }
}
