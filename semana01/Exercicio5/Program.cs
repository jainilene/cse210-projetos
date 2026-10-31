using System;
using System.Globalization;
using System.Runtime.InteropServices;

class Program
{
    //string[] args
    static void ExibirBoasVindas()
    {
        Console.WriteLine("Bem-Vindo ao Programa!");
    }

    static string PerguntarNomeUsuario()
    {
        Console.Write("Por favor, insira o seu nome: ");
        string nome = Console.ReadLine();
        return nome;
    }
    static int PerguntarNumeroFavorito()
    {
        Console.Write("Por favor, insira o seu número favorito: ");
        string numeroDesc = Console.ReadLine();
        int numero = int.Parse(numeroDesc);
        return numero;
    }

    static int ElevarAoQuadrado(int numero)
    {
        return numero * numero;
    }

    static void ExibirResultado(string nome, int numero)
    {
        Console.WriteLine($"Irmã(o) {nome}, o quadrado do seu número é {numero}");

    }

    public static void Main(string[] args)
    {
        ExibirBoasVindas();
        string nome = PerguntarNomeUsuario();
        int numeroFavorito = PerguntarNumeroFavorito();
        int numeroQuadrado = ElevarAoQuadrado(numeroFavorito);
        ExibirResultado(nome, numeroQuadrado);

    }


}