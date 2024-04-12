using VivaCar.Modelo;

namespace VivaCar.Api.Responses;

public class AutomovelResponse
{
    public Guid Id { get; set; }
    public string? Placa { get; set; }
    public string? Descricao { get; set; }
    public double? ValorDiaria { get; set; }

    public static AutomovelResponse From(Automovel automovel) => new AutomovelResponse
    {
        Id = automovel.Id,
        Placa = automovel.Placa,
        Descricao = $"{automovel.Fabricante} {automovel.Modelo}",
        ValorDiaria = automovel.ValorDiaria
    };
}
