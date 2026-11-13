using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, Mundo! Este é o Projeto Fracoes.");
        Fracao fracao1 = new Fracao();


        Console.WriteLine("Fracao [1] :: " + fracao1.GetNumerador() + "/" + fracao1.GetDenominador());
        Fracao fracao2 = new Fracao(3);
        Console.WriteLine("Fracao [2] :: " + fracao2.GetNumerador() + "/" + fracao2.GetDenominador());
        Fracao fracao3 = new Fracao(8, 3);
        Console.WriteLine("Fracao [3] :: " + fracao3.GetNumerador() + "/" + fracao3.GetDenominador());
        Fracao fracao4 = new Fracao(3, 4);
        Console.WriteLine("Fracao [4] em Texto: " + fracao4.ObterFracaoEmTexto());
        Console.WriteLine("Fracao [4] em Decimal: " + fracao4.ObterFracaoEmDecimal());

        // fracao1.setNumerador(3);
        // fracao1.setDenominador(5);
        // Console.WriteLine("Fracao1: Numerador: " + fracao1.getNumerador());
        // Console.WriteLine("Fracao1: Denomiador: " + fracao1.getDenominador());
    }


}