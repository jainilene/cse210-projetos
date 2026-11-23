/*
    Desafio adicional implementado: Foi modificado para selecionar aleatoriamente apenas as palavras que ainda não foram ocultadas.
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        bool sair = false;
        // Console.WriteLine("Olá, Mundo! Este é o Projeto MemorizadorEscrituras.");
        Referencia referencia = new Referencia("João", 3, 16);
        Escritura escritura = new Escritura(referencia, "Porque Deus amou o mundo de tal maneira que deu o seu Filho unigênito, para que todo aquele que nele crê não pereça, mas tenha a vida eterna.");
        Console.Clear();
        string texto = escritura.ObterTexto();
        List<int> indicesNaoOCultos = new List<int>();
        indicesNaoOCultos = IdentificaIndices(escritura.QuantPalavras());

        while (!sair)
        {
            Console.Clear();
            Console.WriteLine(texto);
            Console.Write("Aperte Enter para continuar ou digite 'sair' para finalizar.");
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
                int sorteio = random.Next(0, indicesNaoOCultos.Count() - 1);
                int indice = indicesNaoOCultos[sorteio];
                indicesNaoOCultos.Remove(indice);
                escritura.OcultarPalavrasAleatorias(indice);
                texto = escritura.ObterTexto();

            }
        }
    }

    public static List<int> IdentificaIndices(int quantidade)
    {
        List<int> indices = new List<int>();
        for (int i = 0; i < quantidade; i++)
        {
            indices.Add(i);
        }
        return indices;
    }
}