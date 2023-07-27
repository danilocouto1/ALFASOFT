using ALFASOFT.Models;
using Microsoft.EntityFrameworkCore;

namespace ALFASOFT.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<Contato> Contato { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Garante restrições únicas para os campos Contato e Email
            modelBuilder.Entity<Contato>()
                .HasIndex(c => c.ContatoNumero)
                .IsUnique();

            modelBuilder.Entity<Contato>()
                .HasIndex(c => c.Email)
                .IsUnique();
        }
    }
}
