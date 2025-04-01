using Dominio.Entidades;

namespace Dominio.CasosDeUso;

public static class ProcessarPagamentoReserva
{
    public static Reserva ProcessarPagamento(this Reserva reserva, double valorpago, double desconto = 0.00)
    {
        reserva.Subtotal = reserva.Horas * reserva.ValorHora;
        reserva.Total = reserva.Subtotal - desconto;
        reserva.ValorPago = valorpago;
        reserva.Troco = reserva.ValorPago - reserva.Total;

        return reserva;
    }
}
