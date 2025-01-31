using Microsoft.EntityFrameworkCore;
using SalaFilmeAPI.Entity;

namespace SalaFilmeAPI.Infra
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Sala> Salas { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Cinema> Cinema { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Configuração de chave primária
            builder.Entity<Sala>().HasKey(s => s.Id);
            builder.Entity<Filme>().HasKey(f => f.Id);
            builder.Entity<Cinema>().HasKey(c => c.Id);

            base.OnModelCreating(builder);
        }
    }
}