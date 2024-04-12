using VivaCar.Modelo;

namespace VivaCar.Api.Commands;

public interface IPesquisaCommand
{
    Task<IEnumerable<Automovel>> ExecutarAsync(DateTime dataRetirada, DateTime dataDevolucao, Categoria? categoria);
}
