using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int>();
        float soma = 0;
        float quantidade = 0;
        int maior = 0;
        float media = 0;
        Console.WriteLine("Insira uma lista de números e digite 0 quando terminar.");
        bool dif_zero = true;
        while (dif_zero)
        {
            Console.Write("Insira o número: ");
            string numeroDesc = Console.ReadLine();
            int numero = int.Parse(numeroDesc);
            if (numero == 0)
            {
                dif_zero = false;
                media = soma / quantidade;
                Console.WriteLine($"A soma é: {soma:F0}");
                Console.WriteLine($"A média é: {media:F2}");
                Console.WriteLine($"O maior número é: {maior:F0}");
            }
            else
            {
                numeros.Add(numero);
                quantidade++;
                soma = soma + numero;
                if (numero > maior)
                {
                    maior = numero;
                }
            }
        }

    }
}