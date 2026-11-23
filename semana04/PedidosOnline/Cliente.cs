public class Cliente
{
    private string _nome;
    private Endereco _endereco;

    public bool VerificaSeMoraEUA()
    {
        bool verificacao = _endereco.VerificaPaisEUA();
        return verificacao;
    }
}