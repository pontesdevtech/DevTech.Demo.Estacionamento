using Dominio.Entidades;

namespace Dominio.CasosDeUso;

public static class RegistrarSaidaVeiculo
{
    public static Reserva RegistrarSaida(this Reserva reserva, DateTime datahora)
    {
        reserva.DtSaida = datahora;
        reserva.Horas = CalcularHoras(reserva.DtEntrada, reserva.DtSaida);

        return reserva;
    }

    private static double CalcularHoras(DateTime dataentrada, DateTime datasaida)
    {
        TimeSpan diferencaHoras = datasaida.Subtract(dataentrada);
        return diferencaHoras.TotalHours;
    }
}
