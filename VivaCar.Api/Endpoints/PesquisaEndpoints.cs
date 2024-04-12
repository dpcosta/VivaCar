using Microsoft.AspNetCore.Mvc;
using VivaCar.Api.Responses;
using VivaCar.Modelo;
using VivaCar.Modelo.Commands;

namespace VivaCar.Api.Endpoints;

internal static class PesquisaEndpoints
{
    public static IEndpointRouteBuilder MapPesquisaEndpoints(this IEndpointRouteBuilder endpoints)
    {
        var groupBuilder = endpoints.MapGroup("/pesquisa").WithTags("Pesquisa");

        groupBuilder.MapGet("", async (
            [FromQuery] DateTime dataRetirada,
            [FromQuery] DateTime dataDevolucao,
            [FromQuery] Categoria categoria,
            [FromServices] IPesquisaCommand command) =>
        {
            IEnumerable<Automovel> lista = await command.ExecutarAsync(dataRetirada, dataDevolucao, categoria);
            return TypedResults.Ok(lista.Select(AutomovelResponse.From));
        })
        .Produces<IEnumerable<AutomovelResponse>>(200)
        .WithName("GetPesquisaAutos")
        .WithDescription("Pesquisa os automóveis disponíveis que atendem os critérios informados.")
        .WithOpenApi();

        return endpoints;
    }
}