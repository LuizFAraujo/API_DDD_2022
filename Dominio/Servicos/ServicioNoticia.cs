using Dominio.Interfaces;
using Dominio.Interfaces.InterfaceServicos;
using Entidades.Entidades;

namespace Dominio.Servicos;

public class ServicioNoticia : IServicoNoticia
{
    private readonly INoticia _INoticia;

    public ServicioNoticia(INoticia iNoticia)
    {
        _INoticia = iNoticia;
    }

    public async Task AdicionaNoticia(Noticia noticia)
    {
        var validadarTitulo = noticia.ValidarPropriedadeString(noticia.Titulo, "Titulo");
        var validadarInformacao = noticia.ValidarPropriedadeString(noticia.Informacao, "Informacao");

        if (validadarTitulo && validadarInformacao)
        {
            noticia.DataAltecao = DateTime.Now;
            noticia.DataCadastro = DateTime.Now;
            noticia.Ativo = true;
            await _INoticia.Adicionar(noticia);
        }
    }

    public async Task AtualizaNoticia(Noticia noticia)
    {
        var validadarTitulo = noticia.ValidarPropriedadeString(noticia.Titulo, "Titulo");
        var validadarInformacao = noticia.ValidarPropriedadeString(noticia.Informacao, "Informacao");

        if (validadarTitulo && validadarInformacao)
        {
            noticia.DataAltecao = DateTime.Now;
            noticia.DataCadastro = DateTime.Now;
            noticia.Ativo = true;
            await _INoticia.Atualizar(noticia);
        }
    }

    public async Task<List<Noticia>> ListarNoticiasAtivas()
    {
        return await _INoticia.ListarNoticias(n => n.Ativo);
    }
}
