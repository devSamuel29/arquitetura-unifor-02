namespace Classes;

public class Pagamento
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public required string Agente { get; set; }

    public required double Valor { get; set; }

    public DateTime DataPagemento { get; set; } = DateTime.UtcNow;
}
