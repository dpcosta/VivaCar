using Microsoft.AspNetCore.Mvc;
using VivaCar.Api.Requests;
using VivaCar.Api.Responses;

namespace VivaCar.Api.Endpoints;

internal static class PesquisaEndpoints
{
    public static IEndpointRouteBuilder MapPesquisaEndpoints(this IEndpointRouteBuilder endpoints)
    {
        var groupBuilder = endpoints.MapGroup("/pesquisa").WithTags("Pesquisa");

        groupBuilder.MapGet("", ([FromBody] PesquisaRequest request) =>
        {
            return Results.Ok();
        })
        .Produces<IEnumerable<AutomovelResponse>>(200)
        .WithName("GetPesquisaAutos")
        .WithDescription("Pesquisa os automóveis disponíveis que atendem os critérios informados.")
        .WithOpenApi();

        return endpoints;
    }
}