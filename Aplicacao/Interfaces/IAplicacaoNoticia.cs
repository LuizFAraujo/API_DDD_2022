using Aplicacao.Interfaces.Genericos;
using Entidades.Entidades;

namespace Aplicacao.Interfaces;

public interface IAplicacaoNoticia: IGenericoAplicacao<Noticia>
{
    Task AdicionaNoticia(Noticia noticia);
    Task AtualizaNoticia(Noticia noticia);
    Task<List<Noticia>> ListarNoticiasAtivas();
}
