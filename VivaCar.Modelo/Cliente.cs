namespace VivaCar.Modelo;

public class Cliente
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public ICollection<Reserva> Reservas { get; set; }
}
