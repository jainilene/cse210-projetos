using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
/*
A >= 90
B >= 80
C >= 70
D >= 60
F < 60
*/

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe a nota: ");
        string notaDesc = Console.ReadLine();
        float notaNumerica = float.Parse(notaDesc);
        int minimoAprovacao = 70;
        string letraNota;
        if (notaNumerica >= 90)
        {
            letraNota = "A";
        }
        else if (notaNumerica >= 80)
        {
            letraNota = "B";
        }
        else if (notaNumerica > 70)
        {
            letraNota = "C";
        }
        else if (notaNumerica > 60)
        {
            letraNota = "D";
        }
        else
        {
            letraNota = "F";
        }

        if (letraNota != null)
        {
            Console.WriteLine($"Sua nota conceitual foi: {letraNota}");
        }

        if (notaNumerica >= minimoAprovacao)
        {
            Console.WriteLine("Parabéns, Você foi aprovado no curso!");
        }
        else
        {
            Console.WriteLine("Incentivamos a realizar o curso novamente, você está cada vez mais perto!");
        }


    }
}