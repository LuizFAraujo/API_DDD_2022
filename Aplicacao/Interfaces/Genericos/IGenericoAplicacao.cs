﻿namespace Aplicacao.Interfaces.Genericos;

public interface IGenericoAplicacao<T> where T : class
{
    Task Adicionar(T Objeto);
    Task Atualizar(T Objeto);
    Task Excluir(T Objeto);
    Task<T> BuscarPorId(int Id);
    Task<List<T>> Listar();
}
