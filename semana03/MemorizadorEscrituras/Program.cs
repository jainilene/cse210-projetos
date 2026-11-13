using System;

class Program
{
    static void Main(string[] args)
    {
        bool sair = false;
        // Console.WriteLine("Olá, Mundo! Este é o Projeto MemorizadorEscrituras.");
        Referencia referencia = new Referencia("João", 3, 16);
        Escritura escritura = new Escritura(referencia, "Porque Deus amou o mundo de tal maneira que deu o seu Filho unigênito, para que todo aquele que nele crê não pereça, mas tenha a vida eterna.");
        Console.WriteLine(escritura.ObterTexto());
        while (!sair)
        {
            string infoUsuario = Console.ReadLine();
            if (infoUsuario == "sair")
            {
                sair = true;
            }
            else if (escritura.EstaCompletamenteOculta())
            {
                sair = true;
            }
            else
            {
                Random random = new Random();
                int index = random.Next(0, escritura.QuantPalavras());
                escritura.OcultarPalavrasAleatorias(index);
                string texto = escritura.ObterTexto();
                Console.WriteLine(texto);
            }
        }
    }
}