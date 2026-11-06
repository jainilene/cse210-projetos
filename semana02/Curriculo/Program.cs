using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, Mundo! Este é o Projeto Curriculo.");
        Emprego emprego1 = new Emprego();
        emprego1._cargo = "Engenheiro de Software";
        emprego1._empresa = "Microsoft";
        emprego1._anoInicial = 2019;
        emprego1._anoTermino = 2022;

        Emprego emprego2 = new Emprego();
        emprego2._cargo = "Analista de TI";
        emprego2._empresa = "RFB";
        emprego2._anoInicial = 2010;
        emprego2._anoTermino = 2020;

        Curriculo curriculo = new Curriculo();
        curriculo._nomePessoa = "Jainilene Nascimento";
        curriculo._listaEmpregos.Add(emprego1);
        curriculo._listaEmpregos.Add(emprego2);

        curriculo.ExibirCurriculo();

    }
}