using System;
using System.Reflection;

class Program
{
    public const int Escrever = 1;
    public const int Exibir = 2;
    public const int Carregar = 3;
    public const int Salvar = 4;
    public const int Sair = 5;

    static void Main(string[] args)
    {
        Diario diario = new Diario();

        bool continuar = true;
        int opcao;
        Console.WriteLine("Olá, Mundo! Este é o Projeto Diario.");
        while (continuar)
        {
            CarregarMenu();
            Console.Write("Opção: ");
            string opcaoS = Console.ReadLine();
            opcao = int.Parse(opcaoS);

            if (opcao == Escrever)
            {
                diario.EscreverRegistro();
            }
            else if (opcao == Exibir)
            {
                diario.ExibirDiario();
            }
            else if (opcao == Carregar)
            {
                Console.Write("Informe o nome do arquivo: ");
                string nomeArquivo = Console.ReadLine();
                diario.CarregarRegistrosDiario(nomeArquivo);
            }
            else if (opcao == Salvar)
            {
                diario.SalvarDiario();
            }
            else if (opcao == Sair)
            {
                continuar = false;
                Console.WriteLine("Até mais!");
                return;
            }
            else
            {
                Console.WriteLine("Por favor, informe o número correspondente (de 1 a 5): ");
            }


        }
    }

    public static void CarregarMenu()
    {
        Console.WriteLine("Por favor, selecione uma das opções:");
        Console.WriteLine("1. Escrever um registro");
        Console.WriteLine("2. Exibir registros");
        Console.WriteLine("3. Carregar arquivo");
        Console.WriteLine("4. Salvar diário");
        Console.WriteLine("5. Sair");
    }






}