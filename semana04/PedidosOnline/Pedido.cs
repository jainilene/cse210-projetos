public class Pedido
{
    private List<Produto> _produtos = new List<Produto>();
    private Cliente _cliente;

    public double CalcularCustoTotal()
    {
        double valorTotal = 0;

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