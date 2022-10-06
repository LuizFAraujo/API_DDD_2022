

namespace Dominio.Interfaces.Generics;

public interface IGenericos<T> where T : class
{
    Task Adicionar(T Objeto);
    Task Atualizar(T Objeto);
    Task Excluir(T Objeto);
    Task<T> BuscarPorId(int Id);
    Task<List<T>> Listar();
}
