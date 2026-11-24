public class Cliente
{
    private string _nome;
    private Endereco _endereco;

    public Cliente(string nome, Endereco endereco)
    {
        _nome = nome;
        _endereco = endereco;
    }

    public bool VerificaSeMoraEUA()
    {
        bool verificacao = _endereco.VerificaPaisEUA();
        return verificacao;
    }

    public string GetNomeCliente()
    {
        return _nome;
    }

    public string GetNomeEnderecoCliente()
    {
        string texto = "Nome do Cliente: " + _nome + "\nEndereço: \n" + _endereco.GetEnderecoCompleto();
        return texto;
    }
}