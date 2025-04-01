using Dados.Contexto;
using Dominio.CasosDeUso.Repositorios;
using Dominio.Entidades;
using Dominio.Entidades.Enums;

namespace Dados.Repositorios
{
    public class ReservaRepositorio(MeuContexto _contexto) : IRepositorio<Reserva>
    {
        public Reserva Atualizar(Reserva obj)
        {
            try
            {
                var obj2 = BuscarPorId(obj.Id);
                obj2.DtEntrada = obj.DtEntrada;
                obj2.DtSaida = obj.DtSaida;
                obj2.ValorHora = obj.ValorHora;
                obj2.Horas = obj.Horas;
                obj2.Subtotal = obj.Subtotal;
                obj2.Desconto = obj.Desconto;
                obj2.Total = obj.Total;
                obj2.ValorPago = obj.ValorPago;
                obj2.Troco = obj.Troco;
                obj2.Status = obj.Status;
                obj2.Veiculo = obj.Veiculo;
                _contexto.Update(obj2);
                _contexto.SaveChanges();
                return obj2;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Reserva BuscarPorId(int id)
        {
            try
            {
                return _contexto.Reservas.FirstOrDefault(x => x.Id.Equals(id))!;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Excluir(Reserva obj)
        {
            try
            {
                _contexto.Reservas.Remove(obj);
                _contexto.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<Reserva> ListarTodos()
        {
            try
            {
                return _contexto.Reservas.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Reserva Salvar(Reserva obj)
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
