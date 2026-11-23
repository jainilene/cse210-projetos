public class Produto
{
    private string _nomeProduto;
    private int _id;
    private double _preco;
    private int _quantidade;

    public double CalcularCustoProduto()
    {
        double valorTotal = _preco*_quantidade;
        return valorTotal;
    }

}