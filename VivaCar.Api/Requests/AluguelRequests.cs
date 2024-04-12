namespace VivaCar.Api.Requests;

public record CheckinRequest(Guid ReservaId, DateTime DataCheckin, string LocalCheckin);
public record CheckoutRequest(Guid ReservaId, DateTime DataCheckout, string LocalCheckout);