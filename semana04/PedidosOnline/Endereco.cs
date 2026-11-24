public class Endereco
{
    private string _rua;
    private string _cidade;
    private string _estado;
    private string _pais;

    public Endereco(string rua, string cidade, string estado, string pais)
    {
        _rua = rua;
        _cidade = cidade;
        _estado = estado;
        _pais = pais;
    }

    public bool VerificaPaisEUA()
    {
        if (_pais == "EUA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetEnderecoCompleto()
    {
        string completo = "Rua: " + _rua + "\nCidade: " + _cidade + "\nEstado: " + _estado + "\nPais: " + _pais +"\n";
        return completo;
    }
}