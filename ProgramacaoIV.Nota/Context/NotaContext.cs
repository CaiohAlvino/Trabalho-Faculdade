using Microsoft.EntityFrameworkCore;
using ProgramacaoIV.Nota.Model;

namespace ProgramacaoIV.Nota.Context;

public sealed class NotaContext : DbContext
{
    public DbSet<NotaC> Notas { get; set; }

    public NotaContext(DbContextOptions<NotaContext> options) : base(options) 
    {
        if (Database.GetPendingMigrations().Any())
            Database.Migrate();
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        #region nota

        modelBuilder.Entity<NotaC>().HasKey(t => t.Id);
        modelBuilder.Entity<NotaC>().Property(t => t.Aluno).IsRequired();
        modelBuilder.Entity<NotaC>().Property(t => t.Disciplina).IsRequired();
        modelBuilder.Entity<NotaC>().Property(t => t.Valor).IsRequired();
        modelBuilder.Entity<NotaC>().Property(t => t.Data).IsRequired();

        #endregion nota
    }
}