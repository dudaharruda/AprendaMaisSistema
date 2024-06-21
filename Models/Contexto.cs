using Microsoft.EntityFrameworkCore;

namespace AprendaMaisSistema.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Materias> Materias { get; set; }

        public DbSet<Professores> Professores { get; set; }

        public DbSet<Alunos> Alunos { get; set; }
    }
}
