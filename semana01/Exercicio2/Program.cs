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
        if (notaNumerica >= 90)
        {
            Console.WriteLine($"Sua nota corresponde a: A");
        }
        else if (notaNumerica >= 80)
        {
            Console.WriteLine($"Sua nota corresponde a: B");
        }
        else if(notaNumerica > 70)
        {
            Console.WriteLine($"Sua nota corresponde a: C");
        }
        else if(notaNumerica > 60)
        {
            Console.WriteLine($"Sua nota corresponde a: D");
        }
        else 
        {
            Console.WriteLine($"Sua nota corresponde a: F");
        }


    }
}