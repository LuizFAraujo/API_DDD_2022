namespace Aplicacao.Interfaces;

public interface IAplicacaoUsuario
{
    Task<bool> AcionarUsuario(string email, string senha, int idade, string celular);
}
