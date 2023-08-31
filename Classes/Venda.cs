using Request;

namespace Classes;

public class Venda
{
    public Pagamento FacaPagamento(PagamentoRequest request)
    {
        return new Pagamento() { Agente = request.Agente, Valor = request.Valor, };
    }

    public void Mostrar(PagamentoRequest request)
    {
        var response = FacaPagamento(request);

        Console.WriteLine("VENDA -> PAGAMENTO:");
        Console.WriteLine($"Id: {response.Id}");
        Console.WriteLine($"Agente: {response.Agente}");
        Console.WriteLine($"Valor: {response.Valor}");
        Console.WriteLine($"Data: {response.DataPagemento}");
    }
}
