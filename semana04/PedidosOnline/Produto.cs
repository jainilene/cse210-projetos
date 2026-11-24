public class Produto
{
    private string _nomeProduto;
    private int _id;
    private double _preco;
    private int _quantidade;

    public Produto(string nome, int id, double preco, int quant)
    {
        _nomeProduto = nome;
        _id= id;
        _preco = preco;
        _quantidade = quant;
    }

    public double CalcularCustoProduto()
    {
        double valorTotal = _preco*_quantidade;
        return valorTotal;
    }

    public string GetProduto()
    {
        string texto = "";
        texto = texto + _id + " " + _nomeProduto + " ["+_quantidade+" ] " + _preco +"\n";
        return texto;
    }

}