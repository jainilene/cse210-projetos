public class GeradorDePerguntas
{
    public List<string> _listaPerguntas = new List<string>();


    public GeradorDePerguntas()
    {
        CarregarListaPerguntas();
    }
    public void CarregarListaPerguntas()
    {
        _listaPerguntas.Add("Qual foi o momento mais legal do seu dia? ");
        _listaPerguntas.Add("Como você resumiria seu dia hoje? ");
        _listaPerguntas.Add("Pelo que você é grato hoje? ");
        _listaPerguntas.Add("Você orou hoje por algo específico? Se sim, o quê: ");
        _listaPerguntas.Add("Qual a pessoa mais interessante com quem você conversou hoje?");
    }

    public string GerarPergunta()
    {
        Random geradorNum = new Random();
        int numero = geradorNum.Next(0, _listaPerguntas.Count);
        string pergunta = _listaPerguntas[numero];
        return pergunta;
    }
}