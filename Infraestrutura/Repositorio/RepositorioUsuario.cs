using Dominio.Interfaces;
using Entidades.Entidades;
using Infraestrutura.Configuracoes;
using Infraestrutura.Repositorio.Genericos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using static System.Net.Mime.MediaTypeNames;

namespace Infraestrutura.Repositorio;

public class RepositorioUsuario : RepositorioGenerico<ApplicationUser>, IUsuario
{
    private readonly DbContextOptions<Contexto> _optionsBuilder;

    public RepositorioUsuario()
    {
        _optionsBuilder = new DbContextOptions<Contexto>();
    }

    public async Task<bool> AdicionarUsuario(string email, string senha, int idade, string celular)
    {
        try
        {
            using (var data = new Contexto(_optionsBuilder))
            {
                await data.ApplicationUser.AddAsync(new ApplicationUser
                {
                    Email = email,
                    PasswordHash = senha,
                    Idade = idade,
                    Celular = celular
                });

                await data.SaveChangesAsync();
            }
        }
        catch (Exception)
        {
            return false;
        }

        return true;
    }

    public async Task<bool> ExisteUsuario(string email, string senha)
    {
        try
        {
            using (var data = new Contexto(_optionsBuilder))
            {
                return await data.ApplicationUser
                    .Where(u => u.Email.Equals(email) && u.PasswordHash.Equals(senha))
                    .AsNoTracking()
                    .AnyAsync();
            }
        }
        catch (Exception)
        {
            return false;
        }
    }

}
