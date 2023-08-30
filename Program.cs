using Classes;
using Request;

TPDV tpdv = new();

tpdv.FacaPagamento(new PagamentoRequest() {
    Agente = "Dinheiro",
    Valor = 1000,
});