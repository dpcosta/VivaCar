using VivaCar.Modelo;

namespace VivaCar.Api.Requests;

public record PesquisaRequest(
    DateTime DataRetirada, 
    DateTime DataDevolucao, 
    Categoria? Categoria, 
    int? Passageiros);
