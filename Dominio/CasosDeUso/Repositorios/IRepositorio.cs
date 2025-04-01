namespace Dominio.CasosDeUso.Repositorios;

public interface IRepositorio <T>
{
    IEnumerable<T> ListarTodos();
    T BuscarPorId(int id);
    T Salvar(T obj);
    T Atualizar(T obj);
    void Excluir(T obj);
}
