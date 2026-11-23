public class Comentario
{
    private string _nomePessoa;
    private string _comentario;

    public Comentario(string nome, string comentario)
    {
        _nomePessoa = nome;
        _comentario = comentario;
    }

    public string RastrearComentario()
    {
        string rastreio = "Nome: " + _nomePessoa + "\n";
        rastreio = rastreio + "Comentário: " + _comentario + "\n";
        return rastreio;
    }
}