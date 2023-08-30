namespace Request;

public class PagamentoRequest
{
    public required string Agente { get; set; }

    public required double Valor { get; set; }
}
