using Request;

namespace Classes;

public class Venda
{
    public Pagamento FacaPagamento(PagamentoRequest request)
    {
        return new Pagamento() 
        { 
            Agente = request.Agente,
            Valor = request.Valor,
        };
    }
}
