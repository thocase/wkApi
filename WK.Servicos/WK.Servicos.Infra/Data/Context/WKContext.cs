using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WK.Servicos.Domain.DomainObjects;
using WK.Servicos.Domain.Entidade.Produto;

namespace WK.Servicos.Infra.Data.Context
{
    public class WKContext : DbContext, IUnitOfWork
    {
        public WKContext(DbContextOptions<WKContext> options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ProdutoCategoria> Categorias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProdutoCategoria>().ToTable("ProdutoCategoria");
            modelBuilder.Entity<Produto>().ToTable("Produto");
            base.OnModelCreating(modelBuilder);
        }

        public bool Commit()
        {
            return base.SaveChanges() > 0;
        }
    }
}
