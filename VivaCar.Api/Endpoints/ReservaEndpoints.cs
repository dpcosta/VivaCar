using Microsoft.AspNetCore.Mvc;
using VivaCar.Api.Requests;
using VivaCar.Api.Responses;

namespace VivaCar.Api.Endpoints;

public static class ReservaEndpoints
{
    public static IEndpointRouteBuilder MapReservaEndpoints(this IEndpointRouteBuilder endpoints)
    {
        var groupBuilder = endpoints.MapGroup("/reservas").WithTags("Reservas");

        groupBuilder.MapPost("", ([FromBody] AddReservaRequest request) =>
        {
            return TypedResults.Created();
        })
        .Produces<ProblemDetails>(400)
        .Produces<ReservaResponse>(201)
        .WithName("PostReserva")
        .WithDescription("Cria uma reserva de um automóvel.")
        .WithOpenApi();

        groupBuilder.MapGet("{reservaId}", (Guid reservaId) =>
        {
            return TypedResults.Ok();
        })
        .Produces(404)
        .Produces<ReservaResponse>(200)
        .WithName("GetReserva")
        .WithDescription("Retorna a reserva identificada por seu Id.")
        .WithOpenApi();

        groupBuilder.MapPut("{reservaId}", (Guid reservaId) =>
        {
            return TypedResults.Ok();
        })
        .Produces(404)
        .Produces<ReservaResponse>(200)
        .WithName("UpdateReserva")
        .WithDescription("Atualiza a reserva identificada por seu Id.")
        .WithOpenApi();

        groupBuilder.MapPatch("{reservaId}", (Guid reservaId) =>
        {
            return TypedResults.Ok();
        })
        .Produces(404)
        .Produces<ReservaResponse>(200)
        .WithName("ConfirmReserva")
        .WithDescription("Confirma a reserva identificada por seu Id.")
        .WithOpenApi();

        groupBuilder.MapDelete("{reservaId}", (Guid reservaId) =>
        {
            return TypedResults.NoContent();
        })
        .Produces(400)
        .Produces(404)
        .Produces(204)
        .WithName("DeleteReserva")
        .WithDescription("Cancela a reserva identificada por seu Id.")
        .WithOpenApi();


        return endpoints;
    }
}
