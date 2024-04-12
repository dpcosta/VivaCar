using VivaCar.Modelo;
using VivaCar.Modelo.Commands;

namespace VivaCar.Testes;

public class PesquisaCommandTests
{
    [Fact]
    public async Task DadoPeriodoRecenteECategoriaUtilitario_AoPesquisar_DeveRetornarListaNaoNula()
    {
        // arrange: cenário, entrada
        var dataRetirada = new DateTime(2024, 4, 10);
        var dataDevolucao = new DateTime(2024, 4, 13);
        var categoria = Categoria.Utilitario;
        var command = new PesquisaCommand();

        // act: execução, ação
        var resultado = await command.ExecutarAsync(dataRetirada, dataDevolucao, categoria);

        // assert: verificação das expectativas - AAA, triplo A
        Assert.NotNull(resultado);
        Assert.NotEmpty(resultado);
    }

    [Fact]
    public async Task Test2()
    {
        var dataRetirada = new DateTime(2024, 4, 10);
        var dataDevolucao = new DateTime(2024, 4, 13);
        var categoria = Categoria.Utilitario;
        var command = new PesquisaCommand();

        var resultado = await command.ExecutarAsync(dataRetirada, dataDevolucao, categoria);

        Assert.NotNull(resultado);
        Assert.NotEmpty(resultado);
    }

    [Fact]
    public async Task Test3()
    {
        var dataRetirada = new DateTime(2024, 4, 10);
        var dataDevolucao = new DateTime(2024, 4, 13);
        var categoria = Categoria.Utilitario;
        var command = new PesquisaCommand();

        var resultado = await command.ExecutarAsync(dataRetirada, dataDevolucao, categoria);

        Assert.NotNull(resultado);
        Assert.NotEmpty(resultado);
    }
}