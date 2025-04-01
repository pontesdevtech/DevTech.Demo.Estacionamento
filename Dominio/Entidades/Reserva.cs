using Dominio.Entidades.Enums;

namespace Dominio.Entidades;

public class Reserva
{
    public int Id { get; set; }
    public DateTime DtEntrada { get; set; }
    public DateTime DtSaida { get; set; }
    public double ValorHora { get; set; }
    public double Horas { get; set; }
    public double Subtotal { get; set; }
    public double Desconto { get; set; }
    public double Total { get; set; }
    public double ValorPago { get; set; }
    public double Troco { get; set; }
    public EStatus Status { get; set; }

    public Veiculo Veiculo { get; set; } = null!;
}
