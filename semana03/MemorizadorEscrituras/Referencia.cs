public class Referencia
{
    private string _livro;
    private int _capitulo;
    private int _versiculo;
    private int _ultimoVersiculo;

    public Referencia(string livro, int capitulo, int versiculo)
    {
        _livro = livro;
        _capitulo = capitulo;
        _versiculo = versiculo;
        _ultimoVersiculo = 0;
    }
    public Referencia(string livro, int capitulo, int versiculo, int _ultimoVersiculo)
    {
        _livro = livro;
        _capitulo = capitulo;
        _versiculo = versiculo;
        _ultimoVersiculo
    = _ultimoVersiculo;
    }

    public string ObterTexto()
    {
        string referencia = "";
        if (_ultimoVersiculo == 0)
        {
            referencia = _livro + " " + _capitulo + ":" + _versiculo;
        }
        else
        {
            referencia = _livro + " " + _capitulo + ":" + _versiculo + "-" + _ultimoVersiculo;
        }
        return referencia;
    }


}