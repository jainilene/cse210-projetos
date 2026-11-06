public class Curriculo
{
    public string _nomePessoa;
    public List<Emprego> _listaEmpregos = new List<Emprego>();

    public void ExibirCurriculo()
    {
        Console.WriteLine("Nome: " + _nomePessoa);
        Console.WriteLine("Empregos: ");
        foreach (Emprego emp in _listaEmpregos)
        {
            emp.ExibirEmprego();
        }
    }

}
