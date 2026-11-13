using System.Runtime.InteropServices;

public class Palavra
{
    private string _texto;
    private bool _estaOculta;

    public Palavra(string texto)
    {
        _texto = texto;
    }

    public void Ocultar()
    {
        _estaOculta = true;
    }

    public void Exibir()
    {
        Console.Write(_texto);
    }

    public bool EstaOculta()
    {
        return _estaOculta;
    }

    public string ObterTexto()
    {
        return _texto;
    }
}