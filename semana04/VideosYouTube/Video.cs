using System.Data;

public class Video
{
    private string _titulo;
    private string _autor; 
    private int _duracao; //em segundos
    private List<Comentario> _comentarios = new List<Comentario>();

    public Video(string titulo, string autor, int duracao)
    {
        _titulo = titulo;
        _autor = autor;
        _duracao = duracao;
    }

    public int GetNumeroComentarios()
    {
        return _comentarios.Count;
    }

    public string RastrearVideo()
    {
        string rastreio = "Video: " + _titulo + "\n";
        rastreio = rastreio + "Autor: " + _autor + "\n";
        rastreio = rastreio + "Duração: " + _duracao +"s \n";
        return rastreio;
    }

    public void AdicionarComentario(string autor, string coment)
    {
        Comentario comentario = new Comentario(autor, coment);
        _comentarios.Add(comentario);
    }

    public string MostrarComentarios()
    {
        string texto = "";
        foreach(Comentario comentario in _comentarios)
        {
            texto = texto + comentario.RastrearComentario();
        }
        return texto;
    }


}