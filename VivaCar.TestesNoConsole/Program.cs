using VivaCar.Modelo;
using VivaCar.Modelo.Commands;

var dataRetirada = new DateTime(2024, 4, 10);
var dataDevolucao = new DateTime(2024, 4, 13);
var categoria = Categoria.Utilitario;
var command = new PesquisaCommand();

var resultado = await command.ExecutarAsync(dataRetirada, dataDevolucao, categoria);

var foregroundColor = Console.ForegroundColor;
if (resultado is not null && resultado.Any())
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("SUCESSO: pesquisa retornou resultado!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("FALHA: pesquisa deveria ter retornado algum resultado!");
}
Console.ForegroundColor = foregroundColor;