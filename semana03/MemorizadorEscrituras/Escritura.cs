using System.Collections.Specialized;

public class Escritura
{
    private Referencia _referencia;
    private List<Palavra> _palavras = new List<Palavra>();

    public Escritura(Referencia referencia, string texto)
    {
        _referencia = referencia;
        string[] partes = texto.Split(" ");
        foreach (string parte in partes)
        {
            Palavra palavra = new Palavra(parte);
            _palavras.Add(palavra);
        }


    }

    public void OcultarPalavrasAleatorias(int numeroParaOcultar)
    {
        _palavras[numeroParaOcultar].Ocultar();
    }

    public string ObterTexto()
    {
        string texto = "";
        foreach (Palavra palavra in _palavras)
        {
            if (palavra.EstaOculta())
            {
                foreach (char letra in palavra.ObterTexto())
                {
                    texto = texto + '_';
                }
            }
            else
            {
                texto = texto + palavra.ObterTexto();
            }
            texto = texto + " ";
        }
        return texto;
    }

    public bool EstaCompletamenteOculta()
    {
        bool flag = true;
        foreach (Palavra palavra in _palavras)
        {
            if (palavra.EstaOculta() == false)
            {
                return false;
            }
        }
        return flag;
    }

    public int QuantPalavras()
    {
        int quant = _palavras.Count();
        return quant;
    }


}