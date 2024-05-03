using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SisControleVenda.Models;

namespace SisControleVenda.Data
{
    public class SisControleVendaContext : DbContext
    {
        public SisControleVendaContext (DbContextOptions<SisControleVendaContext> options)
            : base(options)
        {
        }

        public DbSet<SisControleVenda.Models.Login> Login { get; set; } = default!;
        public DbSet<SisControleVenda.Models.NivelDeAcesso> NivelDeAcesso { get; set; } = default!;
        public DbSet<SisControleVenda.Models.Funcionario> Funcionario { get; set; } = default!;
        public DbSet<SisControleVenda.Models.Produto> Produto { get; set; } = default!;
        public DbSet<SisControleVenda.Models.Venda> Venda { get; set; } = default!;
        public DbSet<SisControleVenda.Models.Cliente> Cliente { get; set; } = default!;
    }
}
