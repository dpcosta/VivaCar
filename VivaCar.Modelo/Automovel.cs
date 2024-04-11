namespace VivaCar.Modelo;

public class Automovel
{
    public Guid Id { get; set; }
    public Categoria Categoria { get; set; }
    public int Passageiros { get; set; }
    public string Placa { get; set; }
    public string Modelo { get; set; }
    public string Fabricante { get; set; }
    public double ValorDiaria { get; set; }
    public SituacaoAutomovel Situacao { get; set; }
    public ICollection<Reserva> Reservas { get; set; }
}
