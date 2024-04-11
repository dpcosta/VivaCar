using VivaCar.Api.Requests;

internal static class PesquisaEndpoints
{
    public static IEndpointRouteBuilder MapPesquisaEndpoints(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/pesquisa", (PesquisaRequest request) =>
        {
            return Results.Ok();
        })
        .WithName("GetPesquisaAutos")
        .WithOpenApi(); ;

        return endpoints;
    }
}