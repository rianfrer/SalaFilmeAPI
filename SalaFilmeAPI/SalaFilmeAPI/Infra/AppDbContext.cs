using Microsoft.EntityFrameworkCore;
using SalaFilmeAPI.Entity;

namespace SalaFilmeAPI.Infra
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Sala> Salas { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Cinema> Cinema { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Configuração de chave primária
            builder.Entity<Sala>().HasKey(s => s.Id);
            builder.Entity<Filme>().HasKey(f => f.Id);
            builder.Entity<Cinema>().HasKey(c => c.Id);

            // Configuração de relacionamento muitos-para-muitos via tabela Cinema
            builder.Entity<Cinema>()
                .HasOne(c => c.Sala)
                .WithMany(s => s.Cinemas)
                .HasForeignKey(c => c.SalaId);

            builder.Entity<Cinema>()
                .HasOne(c => c.Filme)
                .WithMany(f => f.Cinemas)
                .HasForeignKey(c => c.FilmeId);

            base.OnModelCreating(builder);
        }
    }
}
