using System.IO;
/*
    Requisitos complementares: Fiz alteração para que ao carregar o arquivo não substitua todos os registros.
    Os registros salvos em arquivos e registros novos (não salvos ainda) são tratados separadamente.
    Dessa forma se o usuário inserir dados e, antes de salvar, ele carregar o arquivo, os registros não serão perdidos, e poderão ser salvos ainda.
*/
public class Diario
{
    List<Registro> _registrosCarregadosArquivo = new List<Registro>();
    List<Registro> _registrosNaoSalvos = new List<Registro>();
    GeradorDePerguntas _gerador = new GeradorDePerguntas();

    public void EscreverRegistro()
    {
        string perguntaUsuario = _gerador.GerarPergunta();
        Console.Write(perguntaUsuario);
        string respostaUsuario = Console.ReadLine();
        Registro registroUsuario = CriarRegistro(perguntaUsuario, respostaUsuario);
        _registrosNaoSalvos.Add(registroUsuario);
    }

    public Registro CriarRegistro(string pergunta, string resposta)
    {
        Registro r = new Registro();
        DateTime horaAtual = DateTime.Now;
        r._data = horaAtual.ToShortDateString();
        r._pergunta = pergunta;
        r._resposta = resposta;
        return r;
    }

    public void ExibirDiario()
    {
        foreach (Registro reg in _registrosCarregadosArquivo)
        {
            reg.ExibirRegistro();
        }
        foreach (Registro reg in _registrosNaoSalvos)
        {
            reg.ExibirRegistro();
        }
    }

    public void CarregarRegistrosDiario(string nomeDoArquivo)
    {
        string[] linhas = System.IO.File.ReadAllLines(nomeDoArquivo);

        foreach (string linha in linhas)
        {
            if (!linha.Equals(""))
            {
                string[] partes = linha.Split("|");
                Registro r = new Registro();
                r._data = partes[0];
                r._pergunta = partes[1];
                r._resposta = partes[2];
                _registrosCarregadosArquivo.Add(r);
            }
        }
    }

    public void SalvarDiario()
    {
        Console.Write("Informe nome do arquivo: ");
        string nomeArquivo = Console.ReadLine();

        foreach (Registro registro in _registrosNaoSalvos)
        {
            string linha = registro._data + "|" + registro._pergunta + "|" + registro._resposta;
            File.AppendAllText(nomeArquivo, linha + Environment.NewLine);
        }
        _registrosNaoSalvos = new List<Registro>();

    }


}