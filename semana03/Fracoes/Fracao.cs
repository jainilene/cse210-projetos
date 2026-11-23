using System.Data;

public class Fracao
{
    private int _numerador;
    private int _denominador;

    public Fracao()
    {
        _numerador = 1;
        _denominador = 1;
    }

    public Fracao(int numerador)
    {
        _numerador = numerador;
        _denominador = 1;
    }

    public Fracao(int numerador, int denominador)
    {
        _numerador = numerador;
        _denominador = denominador;
    }

    public int GetNumerador()
    {
        return _numerador;
    }
    public int GetDenominador()
    {
        return _denominador;
    }

    public void SetNumerador(int numerador)
    {
        _numerador = numerador;
    }
    public void SetDenominador(int denominador)
    {
        _denominador = denominador;
    }

    public string ObterFracaoEmTexto()
    {
        string texto = _numerador + "/" + _denominador;
        return texto;
    }

    public double ObterFracaoEmDecimal()
    {
        double numerador = _numerador;
        double denominador = _denominador;
        double fracao = numerador/denominador;
        return fracao;
    }
}