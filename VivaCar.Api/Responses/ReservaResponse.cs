namespace VivaCar.Api.Responses;

public class ReservaResponse
{
    public Guid Id { get; set; }
    public ClienteResponse? Cliente { get; set; }
    public AutomovelResponse? Automovel { get; set; }
}
