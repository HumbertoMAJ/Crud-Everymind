using Microsoft.EntityFrameworkCore;
using NunesSports.Models;


namespace NunesSports.Data
{
    public class ProdutoDbContext : DbContext
    {

        public ProdutoDbContext(DbContextOptions<ProdutoDbContext> options)
           : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }

       
    }
}
