using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Qual é o seu número mágico? ");
        string numeroDesc = Console.ReadLine();
        int numero = int.Parse(numeroDesc);
        bool repetir = true;
        while (repetir)
        {
            Console.Write("Qual é o seu palpite? ");
            string palpiteDesc = Console.ReadLine();
            int palpite = int.Parse(palpiteDesc);

            if (palpite == numero)
            {
                Console.WriteLine("Você adivinhou!");
                repetir = false;
            }
            else if (palpite > numero)
            {
                Console.WriteLine("Mais baixo");
            }
            else
            {
                Console.WriteLine("Mais alto");
            }
        }

    }
}