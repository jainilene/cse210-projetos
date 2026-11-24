public class Pedido
{
    private List<Produto> _produtos = new List<Produto>();
    private Cliente _cliente;

    public Pedido(Cliente cliente, List<Produto> produtos)
    {
        _cliente = cliente;
        _produtos = produtos;
    }

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
        string etiquetaEmbalagem = ""; //listar nome e a identificação de cada produto
        etiquetaEmbalagem = etiquetaEmbalagem + "Cliente: " + _cliente.GetNomeCliente() + "\n";
        foreach(Produto prod in _produtos)
        {
            etiquetaEmbalagem = etiquetaEmbalagem + prod.GetProduto();
        }
        return etiquetaEmbalagem;
    }

    public string GerarEtiquetaEnvio()
    {
        return _cliente.GetNomeEnderecoCliente();
    }

    public void AdicionarProduto(Produto p)
    {
        _produtos.Add(p);
    }
}