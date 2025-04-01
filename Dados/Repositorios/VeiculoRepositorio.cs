using Dados.Contexto;
using Dominio.CasosDeUso.Repositorios;
using Dominio.Entidades;

namespace Dados.Repositorios
{
    public class VeiculoRepositorio(MeuContexto _contexto) : IRepositorio<Veiculo>
    {
        public Veiculo Atualizar(Veiculo obj)
        {
            try
            {
                var obj2 = BuscarPorId(obj.Id);
                obj2.Descricao = obj.Descricao;
                obj2.Placa = obj.Placa;
                _contexto.Update(obj2);
                _contexto.SaveChanges();
                return obj2;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Veiculo BuscarPorId(int id)
        {
            try
            {
                return _contexto.Veiculos.FirstOrDefault(x => x.Id.Equals(id))!;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Excluir(Veiculo obj)
        {
            try
            {
                _contexto.Veiculos.Remove(obj);
                _contexto.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<Veiculo> ListarTodos()
        {
            try
            {
                return _contexto.Veiculos.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Veiculo Salvar(Veiculo obj)
        {
            try
            {
                _contexto.Add(obj);
                _contexto.SaveChanges();
                return obj;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
