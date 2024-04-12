namespace VivaCar.Modelo;

public class Reserva
{
    public Guid Id { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
    public Guid AutomovelId { get; set; }
    public Automovel Automovel { get; set; }
    public Guid ClienteId { get; set; }
    public Cliente Cliente { get; set; }
    public double ValorTotal { get; set; }
    public SituacaoReserva Situacao { get; set; }
}
