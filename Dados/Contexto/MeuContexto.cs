using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Dados.Contexto
{
    public class MeuContexto(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Veiculo> Veiculos {  get; set; }
        public DbSet<Reserva> Reservas {  get; set; }
    }
}
