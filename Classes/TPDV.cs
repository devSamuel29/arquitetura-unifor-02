using Request;

namespace Classes;

public class TPDV
{
    private readonly Venda _venda = new Venda();

    public void FacaPagamento(PagamentoRequest request)
    {
        var response = _venda.FacaPagamento(request);
        
        Console.WriteLine("VENDA -> PAGAMENTO:");
        Console.WriteLine($"Id: {response.Id}");
        Console.WriteLine($"Agente: {response.Agente}");
        Console.WriteLine($"Valor: {response.Valor}");
                
        Console.WriteLine($"Data: {response.DataPagemento}");
    }
}
