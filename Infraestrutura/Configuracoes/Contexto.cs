using Entidades.Entidades;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infraestrutura.Configuracoes;

public class Contexto : IdentityDbContext<ApplicationUser>
{
    public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
    {
    }

    public DbSet<Noticia> Noticia { get; set; }
    public DbSet<ApplicationUser> ApplicationUser { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseNpgsql(ObterStringConexao());
            base.OnConfiguring(optionsBuilder);
        }
    }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<ApplicationUser>().ToTable("AspNetUsers").HasKey(t => t.Id);
        base.OnModelCreating(builder);
    }


    public string ObterStringConexao()
    {
        string strcon = "Server=127.0.0.1;Port=5432;Database=dbDDD_CursoYoutube;User Id=postgres;Password=postgres;";
        return strcon;
    }
}
