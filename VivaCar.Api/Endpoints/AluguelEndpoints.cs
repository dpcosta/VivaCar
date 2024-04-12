using Microsoft.AspNetCore.Mvc;
using VivaCar.Api.Requests;
using VivaCar.Api.Responses;

namespace VivaCar.Api.Endpoints;

public static class AluguelEndpoints
{
    public static IEndpointRouteBuilder MapAluguelEndpoints(this IEndpointRouteBuilder endpoints)
    {
        var groupBuilder = endpoints.MapGroup("/aluguel").WithTags("Aluguel");

        groupBuilder.MapGet("{aluguelId}", (Guid aluguelId) =>
        {
            return Results.Ok();
        })
        .Produces<ProblemDetails>(404)
        .Produces<AluguelResponse>(200)
        .WithName("GetAluguel")
        .WithDescription("Retorna o aluguel identificado por seu id.")
        .WithOpenApi();

        groupBuilder.MapPost("", ([FromBody] CheckinRequest request) =>
        {
            return TypedResults.Created();
        })
        .Produces<ProblemDetails>(404)
        .Produces<ProblemDetails>(400)
        .Produces<AluguelResponse>(201)
        .WithName("Checkin")
        .WithDescription("Realiza o checkin da reserva.")
        .WithOpenApi();

        groupBuilder.MapDelete("", ([FromBody] CheckoutRequest request) =>
        {
            return TypedResults.NoContent();
        })
        .Produces(404)
        .Produces<ProblemDetails>(400)
        .Produces<AluguelResponse>(201)
        .WithName("Checkout")
        .WithDescription("Realiza o checkout da reserva.")
        .WithOpenApi();

        return endpoints;
    }
}
