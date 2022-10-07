using Aplicacao.Interfaces;
using Dominio.Interfaces;

namespace Aplicacao.Aplicacoes;

public class AplicacaoUsuario : IAplicacaoUsuario
{
    IUsuario _iUsuario;
    public AplicacaoUsuario(IUsuario IUsuario)
    {
        _iUsuario = IUsuario;
    }



    public async Task<bool> AdicionarUsuario(string email, string senha, int idade, string celular)
    {
        return await _iUsuario.AdicionarUsuario(email, senha, idade, celular);
    }

    public async Task<bool> ExisteUsuario(string email, string senha)
    {
        return await _iUsuario.ExisteUsuario(email, senha);
    }
}