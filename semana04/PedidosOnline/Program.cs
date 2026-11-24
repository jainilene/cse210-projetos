using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, Mundo! Este é o Projeto PedidosOnline.\n");
        //string nome, int id, double preco, int quant)
        List<Produto> lista1 = new List<Produto>();
        List<Produto> lista2 = new List<Produto>();
        
        Endereco end1 = new Endereco("Rua dos Professores", "São Luis", "MA", "Brasil");
        Cliente cliente1 = new Cliente("Adriana Sá", end1);
        Produto p1 = new Produto("Espelho 5x7 rosa", 11, 5.70, 10);
        Produto p2 = new Produto("Toalha de Mesa branca", 12, 30.00, 1);
        lista1.Add(p1);
        lista1.Add(p2);
        Pedido pedido1 = new Pedido(cliente1, lista1);

        Endereco end2 = new Endereco("Rua X", "New York", "NY", "EUA");
        Cliente cliente2 = new Cliente("Joyse Magalhães", end2);
        Produto p3 = new Produto("Luminária", 13, 60.00, 1);
        Produto p4 = new Produto("Papel de parece", 14, 70.00, 2);
        Produto p5 = new Produto("Jogo de Luzes de Natal", 15, 100.00, 1);
        lista2.Add(p3);
        lista2.Add(p4);
        lista2.Add(p5);
        Pedido pedido2 = new Pedido(cliente2, lista2);

        Console.WriteLine("PEDIDO 1\n");
        Console.WriteLine("Etiqueta da Embalagem\n");
        Console.WriteLine(pedido1.GerarEtiquetaEmbalagem());
        Console.WriteLine("Etiqueta de Envio\n");
        Console.WriteLine(pedido1.GerarEtiquetaEnvio());
        Console.WriteLine("Preço total do pedido: " + pedido1.CalcularCustoTotal());

        Console.WriteLine("PEDIDO 2\n");
        Console.WriteLine("Etiqueta da Embalagem\n");
        Console.WriteLine(pedido2.GerarEtiquetaEmbalagem());
        Console.WriteLine("Etiqueta de Envio\n");
        Console.WriteLine(pedido2.GerarEtiquetaEnvio());
        Console.WriteLine("Preço total do pedido: " + pedido2.CalcularCustoTotal());

        





    }
}