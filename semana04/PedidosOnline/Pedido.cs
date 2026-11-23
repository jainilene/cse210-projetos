public class Pedido
{
    private List<Produto> _produtos = new List<Produto>();
    private Cliente _cliente;

    public double CalcularCustoTotal()
    {
        double custoEnvio = 5; //Se mora nos EUA
        if (!_cliente.VerificaSeMoraEUA()) 
        {
            custoEnvio = 35; //Se não mora nos EUA
        }
        double custoProdutos = 0;
        foreach(Produto prod in _produtos)
        {
            custoProdutos = custoProdutos + prod.CalcularCustoProduto();
        }

        double valorTotal = custoEnvio + custoProdutos;
        return valorTotal;
    }

    public string GerarEtiquetaEmbalagem()
    {
        string etiquetaEmbalagem = "";

        return etiquetaEmbalagem;
    }

    public string GerarEtiquetaEnvio()
    {
        string etiquetaEnvio = "";

        return etiquetaEnvio;
    }
}