using System;

class Exercicio03
{
    public static void Run()
    {
        Console.Write("Digite a primeira nota: ");
        double nota1 = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Digite a segunda nota: ");
        double nota2 = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Digite a terceira nota: ");
        double nota3 = double.Parse(Console.ReadLine() ?? "0");

        double media = (nota1 + nota2 + nota3) / 3;

        Console.WriteLine($"A média das notas é: {media:F2}");
    }
}
