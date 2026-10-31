using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Qual é o seu número mágico? ");
        string numeroDesc = Console.ReadLine();
        int numero = int.Parse(numeroDesc);
        Console.Write("Qual é o seu palpite? ");
        string palpiteDesc = Console.ReadLine();
        int palpite = int.Parse(palpiteDesc);

        if (palpite == numero)
        {
            Console.WriteLine("Você adivinhou!");
        }
        else if(palpite > numero)
        {
            Console.WriteLine("Mais baixo");
        }
        else
        {
            Console.WriteLine("Mais alto");
        }

    }
}