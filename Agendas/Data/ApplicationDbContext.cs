using Agendas.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Agendas.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Especialidade> Especialidades { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Agenda> Agendas { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Especialidade>().ToTable("Especialidades");
            builder.Entity<Medico>().ToTable("Medicos");
            builder.Entity<Paciente>().ToTable("Pacientes");
            builder.Entity<Agenda>().ToTable("Agendas");
        }
        public DbSet<Agendas.Models.Medico> Medico { get; set; } = default!;
    }
}
