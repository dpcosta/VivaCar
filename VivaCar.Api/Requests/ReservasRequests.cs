namespace VivaCar.Api.Requests;

public class AddReservaRequest
{
    public Guid AutomovelId { get; set; }
    public Guid ClienteId { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
}