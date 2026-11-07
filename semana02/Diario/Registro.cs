public class Registro
{
    public string _data;
    public string _pergunta;
    public string _resposta;

    public void ExibirRegistro()
    {
        Console.WriteLine("------------------------------------------");
        Console.Write("Data: ");
        Console.WriteLine(_data);

        Console.Write("Pergunta: ");
        Console.WriteLine(_pergunta);

        Console.Write("Resposta: ");
        Console.WriteLine(_resposta);
        Console.WriteLine("------------------------------------------");
    }
}