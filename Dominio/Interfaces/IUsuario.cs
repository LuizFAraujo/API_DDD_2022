
namespace Dominio.Interfaces;

public interface IUsuario
{
    Task<bool> AcionarUsuario(string email, string senha, int idade, string celular);
}
