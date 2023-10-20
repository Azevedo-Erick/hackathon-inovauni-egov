using HackatonInovaUniEGov.Models;
using Microsoft.EntityFrameworkCore;

namespace HackatonInovaUniEGov.Data;

public class ApplicationContext  : DbContext
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseMySql("server=localhost;port=3306;database=hackaton;uid=root;pwd=123", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.42-mysql"));
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);
    }

    public virtual DbSet<CategoriaServicoPublico> CategoriasServicoPublico { get; set; } = null!;
    public virtual DbSet<Questao> Questoes { get; set; } = null!;

    public virtual DbSet<RespostaPergunta> RespostasPerguntas { get; set; } = null!;

    public virtual DbSet<Questionario> Questionarios { get; set; } = null!;
    public virtual DbSet<ServicoPublico> ServicosPublicos { get; set; } = null!;
    public virtual DbSet<Usuario> Usuarios { get; set; } = null!;
    
}