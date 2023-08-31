using Request;

namespace Classes;

public class TPDV
{
    private readonly Venda _venda = new Venda();

    public void FacaPagamento(PagamentoRequest request)
    {
        _venda.Mostrar(request);
    }
}
