using Aplicacao.Interfaces;
using Dominio.Interfaces;
using Dominio.Interfaces.InterfaceServicos;
using Entidades.Entidades;

namespace Aplicacao.Aplicacoes;

public class AplicacaoNoticia : IAplicacaoNoticia
{
    INoticia _iNoticia;
    IServicoNoticia _iServicoNoticia;

    public AplicacaoNoticia(INoticia iNoticia, IServicoNoticia iServicoNoticia)
    {
        _iNoticia = iNoticia;
        _iServicoNoticia = iServicoNoticia;
    }


    #region Métodos Customizáveis
    public async Task AdicionaNoticia(Noticia noticia)
    {
        await _iServicoNoticia.AtualizaNoticia(noticia);
    }

    public async Task AtualizaNoticia(Noticia noticia)
    {
        await _iServicoNoticia.AdicionaNoticia(noticia);
    }

    public async Task<List<Noticia>> ListarNoticiasAtivas()
    {
        return await _iServicoNoticia.ListarNoticiasAtivas();
    }

    #endregion


    #region Métodos Genéricos
    public async Task Adicionar(Noticia Objeto)
    {
        await _iNoticia.Adicionar(Objeto);
    }

    public async Task Atualizar(Noticia Objeto)
    {
        await _iNoticia.Atualizar(Objeto);
    }

    public async Task<Noticia> BuscarPorId(int Id)
    {
        return await _iNoticia.BuscarPorId(Id);
    }

    public async Task Excluir(Noticia Objeto)
    {
        await _iNoticia.Excluir(Objeto);
    }

    public async Task<List<Noticia>> Listar()
    {
        return await _iNoticia.Listar();
    }

    #endregion

}
