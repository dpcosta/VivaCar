namespace VivaCar.Api.Responses;

public class AluguelResponse
{
    public Guid Id { get; set; }
    public ReservaResponse? Reserva { get; set; }
}
