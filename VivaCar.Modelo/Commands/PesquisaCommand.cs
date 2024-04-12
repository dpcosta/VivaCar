namespace VivaCar.Modelo.Commands;

public class PesquisaCommand : IPesquisaCommand
{
    readonly List<Automovel> automoveis = new();

    public PesquisaCommand()
    {
        GerarDadosFicticios();
    }

    private void IncluirAutomoveis(Categoria categoria)
    {
        for (int i = 0; i < 10; i++)
        {
            Automovel automovel = new Automovel
            {
                Id = Guid.NewGuid(),
                Categoria = categoria,
                Passageiros = 5,
                Placa = $"ABC-{i}{i}{i}",
                Modelo = $"Modelo {i}",
                Fabricante = $"Fabricante {i}",
                ValorDiaria = 100.0 + i,
                Situacao = SituacaoAutomovel.Disponivel,  
                Reservas = new List<Reserva>()
            };

            automoveis.Add(automovel);
        }
    }

    private void GerarDadosFicticios()
    {

        IncluirAutomoveis(Categoria.Utilitario);
        IncluirAutomoveis(Categoria.Economico);
        IncluirAutomoveis(Categoria.Luxo);
        IncluirAutomoveis(Categoria.Esportivo);

        for (int i = 0; i < automoveis.Count; i++)
        {
            var automovel = automoveis[i];
            for (int j = 0; j < 5; j++)
            {
                Cliente cliente = new Cliente
                {
                    Id = Guid.NewGuid(),
                    Nome = $"Cliente {j}",
                    Cpf = $"000.000.000-{j}{j}",
                    Email = $"cliente{j}@exemplo.com",
                    Telefone = $"(11) 90000-000{j}",
                    Reservas = new List<Reserva>()
                };

                Reserva reserva = new Reserva
                {
                    Id = Guid.NewGuid(),
                    DataInicio = DateTime.Now.AddDays(i + j),
                    DataFim = DateTime.Now.AddDays(i + j + 2),
                    AutomovelId = automovel.Id,
                    Automovel = automovel,
                    ClienteId = cliente.Id,
                    Cliente = cliente,
                    ValorTotal = automovel.ValorDiaria * 2,
                    Situacao = SituacaoReserva.Pendente
                };

                cliente.Reservas.Add(reserva);
                automovel.Reservas.Add(reserva);
            }
        }
    }

    public Task<IEnumerable<Automovel>> ExecutarAsync(
        DateTime dataRetirada, 
        DateTime dataDevolucao, 
        Categoria? categoria)
    {
        var resultado = automoveis
            .Where(a =>
                a.Reservas.All(r => r.DataInicio > dataDevolucao || r.DataFim < dataRetirada)
                && (categoria == null || a.Categoria == categoria)
            );

        return Task.FromResult(resultado);
    }
}
