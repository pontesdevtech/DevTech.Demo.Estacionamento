using Dominio.Entidades;
using Dominio.Entidades.Enums;

namespace Dominio.CasosDeUso;

public static class RegistrarEntradaVeiculo
{
    public static Reserva RegistrarEntrada(this Veiculo obj, DateTime datahora, double valorhora)
    {
        Reserva reserva = new()
        {
            Veiculo = obj,
            DtEntrada = datahora,
            ValorHora = valorhora,
            Status = EStatus.Pagamento_Pendente
        };

        return reserva;
    }
}
