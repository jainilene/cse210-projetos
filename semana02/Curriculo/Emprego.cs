public class Emprego
{
    public string _cargo;
    public string _empresa;
    public int _anoInicial;
    public int _anoTermino;

    public Emprego()
    {

    }

    public void ExibirEmprego()
    {
        Console.WriteLine(_cargo + " (" + _empresa + ") " + _anoInicial + "-" + _anoTermino);
    }
}